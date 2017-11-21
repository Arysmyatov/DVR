using System.Collections.Generic;
using System.Threading.Tasks;
using DVR.Models;

namespace DVR.Services
{
    public interface IDouVacancyResearcheService
    {
         string RootPath { get; set; }
         Task UpdateCompanyRepository();
    }
}