using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVR.Models;
using DVR.Persistence;

namespace DVR.Services
{
    public class TagResultsService : ITagResultsService
    {
        #region private fields

        private readonly ITechnologyCountAnalysisResultRepository _technologyCountAnalysisResultRepository;   

        private TechnologyCountAnalysisResult technologyCountAnalysisResult;

        #endregion private fields


        #region constructors

        public TagResultsService(ITechnologyCountAnalysisResultRepository technologyCountAnalysisResultRepository)
        {
            _technologyCountAnalysisResultRepository = technologyCountAnalysisResultRepository;
        }

        public string RootPath { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IEnumerable<TagGroupResult> GetResults()
        {
            var technologyResults = _technologyCountAnalysisResultRepository.GetResults();
            var tagGroupResults = new List<TagGroupResult>();

            foreach(var technologyResult in technologyResults) {
                foreach(var tagGroup in technologyResult.TagGroups){
                    var tagGroupResult = tagGroupResults.FirstOrDefault(t => t.Name == tagGroup.Name);
                    if(tagGroupResult == null) {
                        tagGroupResult = new TagGroupResult {
                            Name = tagGroup.Name,
                            TagResults = new List<TagResults>()
                        };
                        tagGroupResults.Add(tagGroupResult);
                    }

                    foreach(var tagDescription in tagGroup.TagDescriptions) {
                        var tagResults = tagGroupResult.TagResults.FirstOrDefault(t => t.Name == tagDescription.Name);
                        if(tagResults == null) {
                            tagResults = new TagResults {
                                Name = tagDescription.Name,
                                Results = new List<TagResult>()
                            };
                            tagGroupResult.TagResults.Add(tagResults);
                        };

                        var tagResult = new TagResult {
                            Date  = technologyResult.Date,
                            Count = tagDescription.Count
                        };

                        tagResults.Results.Add(tagResult);
                    }
                }
            }
            return tagGroupResults;
        }


        #endregion constructors
    }
}