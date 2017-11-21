using System.IO;

namespace DVR.Constants
{
    public static class FileLocation
    {
        private const string BaseFilePath = "data";
        private const string UrlFileName = "vacancies.txt";
        private const string JsonFileName = "companies.json";

        public static string GetPath(){
            return Path.Combine(BaseFilePath, UrlFileName);
        }

        public static string GetJsonPath(){
            return Path.Combine(BaseFilePath, JsonFileName);
        } 

        public static string GetPath(string basePath){
            return Path.Combine(basePath, GetPath());
        }        

        public static string GetJsonPath(string basePath){
            return Path.Combine(basePath, GetJsonPath());
        }
    }
}