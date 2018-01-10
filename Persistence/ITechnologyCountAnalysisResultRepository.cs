using System.Collections.Generic;
using DVR.Models;

namespace DVR.Persistence
{
    public interface ITechnologyCountAnalysisResultRepository
    {
         void AddResult(TechnologyCountAnalysisResult technologyCountAnalysisResult);
         IEnumerable<TechnologyCountAnalysisResult> GetResults();
    }
}