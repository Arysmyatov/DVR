using System.Collections.Generic;

namespace DVR.Models
{
    public class TagGroupResult
    {
        public string Name { get; set; }
        public IList<TagResults> TagResults { get; set; }
    }
}