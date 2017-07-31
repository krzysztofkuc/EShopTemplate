using System;
using System.Collections.Generic;

namespace PlusAndComment.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string DescriptionLong { get; set; }
        public string DescriptionShort { get; set; }
        public DateTime BuyDateTime { get; set; }
        public DateTime AddedDateTime { get; set; }

        public int FilterEntity_ID { get; set; }
        public int Category_Id { get; set; }

        public virtual CategoryVM Category { get; set; }

        public virtual List<FilterVM> Filters { get; set; }
    }
}