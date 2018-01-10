using System.Collections.Generic;

namespace DVR.Models
{
    public class TagResults : Tag
    {
        public IList<TagResult> Results { get; set; }
    }
}