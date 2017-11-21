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
        public IEnumerable<Company> Companies { get; set; }

        public XmlContext() => Companies = GetComapnies();

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
    }
}