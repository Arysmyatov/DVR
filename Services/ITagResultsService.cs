using System.Collections.Generic;
using System.Threading.Tasks;
using DVR.Models;

namespace DVR.Services
{
    public interface ITagResultsService
    {
        string RootPath { get; set; }
        IEnumerable<TagGroupResult> GetResults();
    }
}