using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DVR.Constants;
using DVR.Models;
using DVR.Persistence;
using HtmlAgilityPack;

namespace DVR.Services
{
    public class DouVacancyResearcheService : IDouVacancyResearcheService
    {
        #region private fields

        private readonly ICompanyRepository _companyRepository;

        #endregion private fields

        public string RootPath { get; set; }

        #region constructors

        public DouVacancyResearcheService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        #endregion constructors        


        #region public methods

        public async Task UpdateCompanyRepository(){
            var companies = await GetCompaniesAsync();
            _companyRepository.UpdateCompanies(companies);
        }


        private async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            var urls = await GetUrlsAsync();
            var companies = new Dictionary<string, Company>();

            foreach (var url in urls)
            {
                var htmlDoc = await GetVacancyContentAsync(url);

                var pageContent = GetPageContent(htmlDoc);

                if (string.IsNullOrEmpty(pageContent.CompanyName))
                {
                    continue;
                }

                if (!companies.ContainsKey(pageContent.CompanyName))
                {
                    companies.Add(pageContent.CompanyName, new Company
                    {
                        Name = pageContent.CompanyName,
                        Vacancies = new List<Vacancy>()
                    });
                }

                var currentCompany = companies[pageContent.CompanyName];
                var tags = GetTags(pageContent);
                if(!tags.Any()){
                    continue;
                }

                currentCompany.Vacancies.Add(new Vacancy
                {
                    Url = url,
                    PositionName = pageContent.PositionDescription.ToUpper(),
                    Tags = tags
                });
            }

            return companies.Values;
        }

        #endregion public methods        


        #region private methods


        private PageContent GetPageContent(HtmlDocument htmlDocument)
        {
            return new PageContent
            {
                CompanyName = GetCompanyName(htmlDocument),
                CompanyDescription = GetCompanyDescription(htmlDocument),
                Vacancy = GetVacancy(htmlDocument).ToUpper(),
                AboutProject = GetAboutProject(htmlDocument),
                PositionDescription = GetPositionDescription(htmlDocument)
            };
        }


        private async Task<string> ReadFileAsync()
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


        private async Task<IEnumerable<string>> GetUrlsAsync()
        {
            var fileContent = await ReadFileAsync();

            var htmlDoc = new HtmlDocument();
            var content = fileContent;
            htmlDoc.LoadHtml(content);

            return htmlDoc.DocumentNode.SelectNodes(Xpaths.VacancyUrl)
                                       .Select(u => u.Attributes["href"].Value);
        }


        private string GetCompanyName(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(Xpaths.CompanyName);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }


        private string GetCompanyDescription(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(Xpaths.CompanyDescription);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }


        private string GetVacancy(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(Xpaths.Vacancy);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }



        private string GetAboutProject(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(Xpaths.AboutProject);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }

        private string GetPositionDescription(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(Xpaths.Position);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }


        private async Task<HtmlDocument> GetVacancyContentAsync(string url)
        {
            var httpClient = new HttpClient();

            var parameters = new Dictionary<string, string>();

            var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(parameters));
            var content = await response.Content.ReadAsStringAsync();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(content);

            return htmlDoc;
        }


        private IEnumerable<string> GetTags(PageContent pageContent)
        {
            var tags = new List<string>();
            foreach (var tag in TagDescriptions.GetAllTagDescriptions())
            {
                foreach (var technology in tag.Technologies)
                {
                    if (pageContent.Vacancy
                                   .Contains(technology.ToUpper()))
                    {
                        tag.Count++;
                        tags.Add(tag.Name);
                        break;
                    }
                }
            }

            return tags;
        }


        #endregion private methods        
    }
}