using System.Collections.Generic;

namespace PlusAndComment.Models
{
    public class HomeVM
    {
        public ICollection<MainPostVM> Posts { get; set; }
        public bool ShowNeedAgePics { get; set; }
        public int CurrentPage { get; set; }
        public int PostsCapacity { get; set; }
    }
}