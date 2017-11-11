using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DVR.Constants;
using HtmlAgilityPack;

namespace DVR.Services
{
    public class DouVacancyResearcheService : IDouVacancyResearcheService
    {
        #region private fields

        public string RootPath { get; set; }

        #endregion private fields

        #region constructors

        public DouVacancyResearcheService()
        {
        }

        #endregion constructors        


        #region public methods


        #endregion public methods        


        #region private methods

        private async Task<string> RedaFileAsync()
        {
            var filePath = FileLocation.GetPath(RootPath);

            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            var allText = string.Empty;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                allText = await reader.ReadToEndAsync();
            }

            return allText;
        }


        public async Task<IEnumerable<string>> GetUrlsAsync()
        {
            var fileContent = await RedaFileAsync();

            var htmlDoc = new HtmlDocument();
            var content = fileContent;
            htmlDoc.LoadHtml(content);

            return htmlDoc.DocumentNode.SelectNodes(Xpaths.VacancyUrl)
                                       .Select(u => u.Attributes["href"].Value);
        }

        #endregion private methods        
    }
}