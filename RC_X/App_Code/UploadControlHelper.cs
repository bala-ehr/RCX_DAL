using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RC_X
{
    public static class UploadControlHelper
    {
        const int DisposeTimeout = 5;
        const string FolderKey = "UploadDirectory";
        const string TempDirectory = "~/UploadControl/Temp/";
        static readonly object storageListLocker = new object();

        static HttpContext Context { get { return HttpContext.Current; } }
        static string RootDirectory { get { return Context.Request.MapPath(TempDirectory); } }

        static IList<UploadedFilesStorage> uploadedFilesStorageList;
        static IList<UploadedFilesStorage> UploadedFilesStorageList
        {
            get
            {
                return uploadedFilesStorageList;
            }
        }

        static UploadControlHelper()
        {
            uploadedFilesStorageList = new List<UploadedFilesStorage>();
        }

        static string CreateTempDirectoryCore()
        {
            string uploadDirectory = Path.Combine(RootDirectory, Path.GetRandomFileName());
            Directory.CreateDirectory(uploadDirectory);

            return uploadDirectory;
        }
        public static UploadedFilesStorage GetUploadedFilesStorageByKey(string key)
        {
            lock (storageListLocker)
            {
                return GetUploadedFilesStorageByKeyUnsafe(key);
            }
        }
        static UploadedFilesStorage GetUploadedFilesStorageByKeyUnsafe(string key)
        {
            UploadedFilesStorage storage = UploadedFilesStorageList.Where(i => i.Key == key).SingleOrDefault();
            if (storage != null)
                storage.LastUsageTime = DateTime.Now;
            return storage;
        }
        public static string GenerateUploadedFilesStorageKey()
        {
            return Guid.NewGuid().ToString("N");
        }
        public static void AddUploadedFilesStorage(string key)
        {
            lock (storageListLocker)
            {
                UploadedFilesStorage storage = new UploadedFilesStorage
                {
                    Key = key,
                    Path = CreateTempDirectoryCore(),
                    LastUsageTime = DateTime.Now,
                    Files = new List<UploadedFileInfo>()
                };
                UploadedFilesStorageList.Add(storage);
            }
        }
        public static void RemoveUploadedFilesStorage(string key)
        {
            lock (storageListLocker)
            {
                UploadedFilesStorage storage = GetUploadedFilesStorageByKeyUnsafe(key);
                if (storage != null)
                {
                    Directory.Delete(storage.Path, true);
                    UploadedFilesStorageList.Remove(storage);
                }
            }
        }
        public static void RemoveOldStorages()
        {
            if (!Directory.Exists(RootDirectory))
                Directory.CreateDirectory(RootDirectory);

            lock (storageListLocker)
            {
                string[] existingDirectories = Directory.GetDirectories(RootDirectory);
                foreach (string directoryPath in existingDirectories)
                {
                    UploadedFilesStorage storage = UploadedFilesStorageList.Where(i => i.Path == directoryPath).SingleOrDefault();
                    if (storage == null || (DateTime.Now - storage.LastUsageTime).TotalMinutes > DisposeTimeout)
                    {
                        Directory.Delete(directoryPath, true);
                        if (storage != null)
                            UploadedFilesStorageList.Remove(storage);
                    }
                }
            }
        }
        public static UploadedFileInfo AddUploadedFileInfo(string key, string originalFileName)
        {
            UploadedFilesStorage currentStorage = GetUploadedFilesStorageByKey(key);
            UploadedFileInfo fileInfo = new UploadedFileInfo
            {
                FilePath = Path.Combine(currentStorage.Path, Path.GetRandomFileName()),
                OriginalFileName = originalFileName,
                UniqueFileName = GetUniqueFileName(currentStorage, originalFileName)
            };
            currentStorage.Files.Add(fileInfo);

            return fileInfo;
        }
        public static UploadedFileInfo GetDemoFileInfo(string key, string fileName)
        {
            UploadedFilesStorage currentStorage = GetUploadedFilesStorageByKey(key);
            return currentStorage.Files.Where(i => i.UniqueFileName == fileName).SingleOrDefault();
        }
        public static string GetUniqueFileName(UploadedFilesStorage currentStorage, string fileName)
        {
            string baseName = Path.GetFileNameWithoutExtension(fileName);
            string ext = Path.GetExtension(fileName);
            int index = 1;

            while (currentStorage.Files.Any(i => i.UniqueFileName == fileName))
                fileName = string.Format("{0} ({1}){2}", baseName, index++, ext);

            return fileName;
        }

    }

    public class UploadedFilesStorage
    {
        public string Path { get; set; }
        public string Key { get; set; }
        public DateTime LastUsageTime { get; set; }

        public IList<UploadedFileInfo> Files { get; set; }
    }

    public class UploadedFileInfo
    {
        public string UniqueFileName { get; set; }
        public string OriginalFileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
    }
}