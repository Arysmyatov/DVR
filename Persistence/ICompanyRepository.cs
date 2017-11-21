using System.Collections.Generic;
using DVR.Models;

namespace DVR.Persistence
{
    public interface ICompanyRepository
    {
         void UpdateCompanies(IEnumerable<Company> companies);
         IEnumerable<Company> GetCompanies();
    }
}