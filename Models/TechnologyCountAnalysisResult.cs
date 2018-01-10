using System;
using System.Collections.Generic;

namespace DVR.Models
{
    public class TechnologyCountAnalysisResult
    {
        public DateTime Date { get; set; }
        public IEnumerable<TagGroup> TagGroups { get; set; }
    }
}