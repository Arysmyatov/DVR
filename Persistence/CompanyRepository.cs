using System.Collections.Generic;
using DVR.Models;
using DVR.Services;

namespace DVR.Persistence
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly XmlContext _context;
        private IEnumerable<Company> _companies;

        public CompanyRepository(XmlContext context){
            _context = context;
            _companies = _context.Companies;
        }


        public IEnumerable<Company> GetCompanies()
        {
            return _companies;
        }


        public void UpdateCompanies(IEnumerable<Company> companies)
        {
            _companies = companies;
            _context.Companies = companies;
            _context.UpdateComapnies();
        }
    }
}