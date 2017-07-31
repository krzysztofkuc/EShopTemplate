using System.Collections.Generic;

namespace PlusAndComment.Models
{
    public class CategoryVM
    {
        public int ID { get; set; }
        public ICollection<CategoryVM> Categories { get; set; }
    }
}