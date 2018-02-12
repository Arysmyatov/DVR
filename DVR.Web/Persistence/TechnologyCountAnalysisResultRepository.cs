using System.Collections.Generic;
using System.Linq;
using DVR.Models;
using DVR.Services;

namespace DVR.Persistence
{
    public class TechnologyCountAnalysisResultRepository : ITechnologyCountAnalysisResultRepository
    {
        private readonly XmlContext _context;
        private IList<TechnologyCountAnalysisResult> _technologyCountAnalysisResults;

        public TechnologyCountAnalysisResultRepository(XmlContext context){
            _context = context;
            _technologyCountAnalysisResults = _context.TechnologyCountAnalysisResults.ToList();
        }


        public IEnumerable<TechnologyCountAnalysisResult> GetResults()
        {
            return _technologyCountAnalysisResults;
        }


        public void AddResult(TechnologyCountAnalysisResult technologyCountAnalysisResult)
        {
            _technologyCountAnalysisResults.Add(technologyCountAnalysisResult);
            _context.TechnologyCountAnalysisResults = _technologyCountAnalysisResults;
            _context.UpdateTechnologyCountAnalysisResults();
        }
    }
}