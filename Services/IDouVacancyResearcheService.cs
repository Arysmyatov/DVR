using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVR.Services
{
    public interface IDouVacancyResearcheService
    {
         string RootPath { get; set; }
         Task<IEnumerable<string>> GetUrlsAsync();
    }
}