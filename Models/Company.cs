using System.Collections.Generic;

namespace DVR.Models
{
    public class Company
    {
        public string Name { get; set; }
        public List<Vacancy> Vacancies { get; set; }
    }
}