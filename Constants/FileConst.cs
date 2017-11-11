using System.IO;

namespace DVR.Constants
{
    public static class FileLocation
    {
        private const string BaseFilePath = "data";
        private const string UrlFileName = "vacancies.txt";

        public static string GetPath(){
            return Path.Combine(BaseFilePath, UrlFileName);
        }

        public static string GetPath(string basePath){
            return Path.Combine(basePath, GetPath());
        }        
    }
}