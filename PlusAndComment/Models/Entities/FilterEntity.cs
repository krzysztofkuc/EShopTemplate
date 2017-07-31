using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlusAndComment.Models.Entities
{
    [Table("FilterEntity")]
    public class FilterEntity
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