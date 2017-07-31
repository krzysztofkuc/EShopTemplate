using System.Collections.Generic;

namespace PlusAndComment.Models
{
    public class FilterVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ValueFrom { get; set; }
        public double ValueTo { get; set; }
        public string Unit { get; set; }
        public double DefaultValue { get; set; }
        public string DefaultString { get; set; }
        public List<string> ValueList { get; set; }
    }
}