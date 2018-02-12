using System;
using System.Collections.Generic;
using System.IO;
using DVR.Models;
using Newtonsoft.Json;

namespace DVR.Services
{
    public class XmlContext
    {
        private IEnumerable<Company>  _companies;
        private IEnumerable<TechnologyCountAnalysisResult>  _technologyCountAnalysisResults;        
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<TechnologyCountAnalysisResult> TechnologyCountAnalysisResults { get; set; }        

        public XmlContext() { 
            Companies = GetComapnies(); 
            TechnologyCountAnalysisResults = GetTechnologyCountAnalysisResults();
        }
        

        private IEnumerable<Company> GetComapnies()
        {
            var companies = new List<Company>();
            try
            {
                using (StreamReader file = File.OpenText(@"companies.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    companies = (List<Company>)serializer.Deserialize(file, typeof(List<Company>));
                }
            }
            catch
            {

            }
            return companies;
        }


        public void UpdateComapnies()
        {
            using (StreamWriter file = File.CreateText(@"companies.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Companies);
            }
        }


        private IEnumerable<TechnologyCountAnalysisResult> GetTechnologyCountAnalysisResults()
        {
            var technologyCountAnalysisResults = new List<TechnologyCountAnalysisResult>();
            try
            {
                using (StreamReader file = File.OpenText(@"technologyCountAnalysisResults.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    technologyCountAnalysisResults = (List<TechnologyCountAnalysisResult>)serializer
                                    .Deserialize(file, typeof(List<TechnologyCountAnalysisResult>));
                }
            }
            catch
            {

            }
            return technologyCountAnalysisResults;
        }


        public void UpdateTechnologyCountAnalysisResults()
        {
            using (StreamWriter file = File.CreateText(@"technologyCountAnalysisResults.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, TechnologyCountAnalysisResults);
            }
        }
    }
}