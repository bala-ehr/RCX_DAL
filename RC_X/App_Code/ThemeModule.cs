using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace RC_X
{
    public class ThemeModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.PreRequestHandlerExecute += HandlePreRequest;
        }

        void HandlePreRequest(object sender, EventArgs e)
        {
            Page page = HttpContext.Current.CurrentHandler as Page;
            if (page != null)
            {
                page.PreInit += delegate
                {
                    string theme = string.Empty;

                    theme = HttpContext.Current.Request.Cookies["theme"] != null ? HttpContext.Current.Request.Cookies["theme"].Value : "";
                    if (theme == null || theme == "")
                    {
                        HttpCookie themeCookie = new HttpCookie("theme");
                        themeCookie.Value = "MaterialCompact";
                        HttpContext.Current.Response.Cookies.Add(themeCookie);
                        page.Theme = "MaterialCompact";

                    }
                    else
                    {
                        page.Theme = HttpContext.Current.Request.Cookies["theme"].Value;
                    }

                };
            }
        }
    }
}