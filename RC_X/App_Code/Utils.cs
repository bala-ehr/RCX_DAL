using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.Web.Internal;
using OfficeOpenXml;

namespace RC_X
{

    public class SourceCodePage
    {
        public string Title = "";
        public string Code = "";
        public bool Expanded = false;

        public SourceCodePage(string title, string code, bool expanded)
        {
            Title = title;
            Code = code;
            Expanded = expanded;
        }
    }

    public class FeaturedDemoInfo
    {
        public string Title
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string NavigateUrl
        {
            get;
            set;
        }
        public string ImageUrl
        {
            get;
            set;
        }
    }

    public class ProductInfo
    {
        public string Title
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string NavigateUrl
        {
            get;
            set;
        }
        public string ImageUrl
        {
            get;
            set;
        }
    }

    public static class Utils
    {
        const string
            CurrentDemoKey = "DXCurrentDemo",
            CurrentThemeCookieKeyPrefix = "DXCurrentTheme",
            DefaultTheme = "Metropolis",
            BogusDemoTitle = "Delivered!";

        static readonly object sourceCodeCacheLock = new object();

        static string _codeLanguage;

        static HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }

        static HttpRequest Request
        {
            get
            {
                return Context.Request;
            }
        }

        public static string CodeLanguage
        {
            get
            {
                if (_codeLanguage == null)
                {
                    try
                    {
                        using (FileStream _file = File.OpenRead(Context.Server.MapPath("~/Site.master")))
                        using (TextReader reader = new StreamReader(_file))
                        {
                            string line = reader.ReadLine();
                            Match match = Regex.Match(line, @"language=""([^""]+)", RegexOptions.IgnoreCase);
                            if (match.Success)
                            {
                                _codeLanguage = match.Groups[1].Value.ToUpper();
                            }
                        }
                    }
                    catch
                    {
                    }
                    if (String.IsNullOrEmpty(_codeLanguage))
                        _codeLanguage = "C#";
                }
                return _codeLanguage;
            }
        }

        static bool HasCodeFile(string url)
        {
            string filePath = GetHighlightedFilePath(url);
            string text = File.ReadAllText(filePath);
            return Regex.IsMatch(text, @"<[^>]*\bCodeFile\s*=\s*""[\w\.]+\""[^>]*>");
        }

        static string GetHighlightedFilePath(string virtualPath)
        {
            string result = new DirectoryInfo(Context.Server.MapPath("~/")).FullName;
            result = Path.Combine(result, ".Source");
            result = Path.Combine(result, virtualPath.Substring(2));
            if (File.Exists(result))
                return result;

            result = Context.Server.MapPath(virtualPath);
            if (!File.Exists(result))
                result = CorrectSourceFilePath(result);
            return result;
        }

        static string CorrectSourceFilePath(string filePath)
        {
            string csPathItem = String.Format("{0}cs{0}", Path.DirectorySeparatorChar);
            string vbPathItem = String.Format("{0}vb{0}", Path.DirectorySeparatorChar);
            filePath = filePath.ToLower();
            if (filePath.EndsWith(".cs"))
                return filePath.Replace(vbPathItem, csPathItem);
            if (filePath.EndsWith(".vb"))
                return filePath.Replace(csPathItem, vbPathItem);
            return filePath;
        }

        public static string GetVersionText()
        {
            string[] parts = AssemblyInfo.Version.Split('.');
            return string.Format("v{0} vol {1}.{2}", 2000 + int.Parse(parts[0]), parts[1], parts[2]);
        }

        public static string GetVersionSuffix()
        {
            return AssemblyInfo.Version.Replace(".", "_");
        }


        public static void EnsureRequestValidationMode()
        {
            try
            {
                if (Environment.Version.Major >= 4)
                {
                    Type type = typeof(WebControl).Assembly.GetType("System.Web.Configuration.RuntimeConfig");
                    MethodInfo getConfig = type.GetMethod("GetConfig", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { }, null);
                    object runtimeConfig = getConfig.Invoke(null, null);
                    MethodInfo getSection = type.GetMethod("GetSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(string), typeof(Type) }, null);
                    HttpRuntimeSection httpRuntimeSection = (HttpRuntimeSection)getSection.Invoke(runtimeConfig, new object[] { "system.web/httpRuntime", typeof(HttpRuntimeSection) });
                    FieldInfo bReadOnly = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                    bReadOnly.SetValue(httpRuntimeSection, false);

                    PropertyInfo pi = typeof(HttpRuntimeSection).GetProperty("RequestValidationMode");
                    if (pi != null)
                    {
                        Version version = (Version)pi.GetValue(httpRuntimeSection, null);
                        Version RequiredRequestValidationMode = new Version(2, 0);
                        if (version != null && !Version.Equals(version, RequiredRequestValidationMode))
                        {
                            pi.SetValue(httpRuntimeSection, RequiredRequestValidationMode, null);
                        }
                    }
                    bReadOnly.SetValue(httpRuntimeSection, true);
                }
            }
            catch
            {
            }
        }

        static bool? _isSiteMode;
        public static bool IsSiteMode
        {
            get
            {
                if (!_isSiteMode.HasValue)
                {
                    _isSiteMode = ConfigurationManager.AppSettings["SiteMode"].Equals("true", StringComparison.InvariantCultureIgnoreCase);
                }
                return _isSiteMode.Value;
            }
        }


        public static bool IsIE6()
        {
            return RenderUtils.Browser.IsIE && RenderUtils.Browser.Version < 7;
        }

        public static bool IsIE9()
        {
            return RenderUtils.Browser.IsIE && RenderUtils.Browser.Version > 8;
        }

        public static bool IsIE10()
        {
            return RenderUtils.Browser.IsIE && RenderUtils.Browser.Version > 9;
        }

        public static string EncodeUrl(string url)
        {
            return Uri.EscapeUriString(url.Trim());
        }

        public static string FormatSize(object value)
        {
            double amount = Convert.ToDouble(value);
            string unit = "KB";
            if (amount != 0)
            {
                if (amount <= 1024)
                    amount = 1;
                else
                    amount /= 1024;

                if (amount > 1024)
                {
                    amount /= 1024;
                    unit = "MB";
                }
                if (amount > 1024)
                {
                    amount /= 1024;
                    unit = "GB";
                }
            }
            return String.Format("{0:#,0} {1}", Math.Round(amount, MidpointRounding.AwayFromZero), unit);
        }

        private static bool IsErrorPage(string demoKey)
        {
            return demoKey.Equals("Error404", StringComparison.OrdinalIgnoreCase) ||
                demoKey.Equals("Error500", StringComparison.OrdinalIgnoreCase);
        }

        public static DataTable ToDataTable(this ExcelPackage package)
        {
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
            DataTable table = new DataTable();
            foreach (var firstRowCell in workSheet.Cells[1, 1, 1, workSheet.Dimension.End.Column])
            {
                table.Columns.Add(firstRowCell.Text);
            }
            for (var rowNumber = 2; rowNumber <= workSheet.Dimension.End.Row; rowNumber++)
            {
                var row = workSheet.Cells[rowNumber, 1, rowNumber, workSheet.Dimension.End.Column];
                var newRow = table.NewRow();
                foreach (var cell in row)
                {
                    newRow[cell.Start.Column - 1] = cell.Text;
                }
                table.Rows.Add(newRow);
            }
            return table;
        }

        public static List<string> ValidateExcelData(DataTable data)
        {
            List<string> errors = new List<string>();
           
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (data.Columns.Count == 12)
                    {
                        if (!Enum.IsDefined(typeof(BooleanAliases), row[9].ToString().ToLower()))
                        {
                            errors.Add(string.Format("Error in row {0}. Critical Column value should be Yes or No.", i + 1));
                        }
                    }
                    
                    else
                    {
                        if (!Enum.IsDefined(typeof(BooleanAliases), row[7].ToString().ToLower()))
                        {
                            errors.Add(string.Format("Error in row {0}. Critical Column value should be Yes or No.", i + 1));
                        }
                    }

                }
            
        return errors;
        }
    }

    public class Mecl
    {
        public string Checklist { get; set; }
        public string ChecklistType { get; set; }
        public string BusinessObjective { get; set; }
        public string SrcID { get; set; }
        public string Source { get; set; }
        public string Criteria { get; set; }
        public bool Critical { get; set; }
    }

    public enum BooleanAliases
    {
        yes = 0,
        no = 1
    }
}
