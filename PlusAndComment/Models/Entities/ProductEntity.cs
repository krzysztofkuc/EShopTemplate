using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlusAndComment.Models.Entities
{
    [Table("ProductEntity")]
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string DescriptionLong { get; set; }
        public string DescriptionShort { get; set; }
        public DateTime BuyDateTime { get; set; }
        public DateTime AddedDateTime { get; set; }

        [ForeignKey("Filters")]
        public int FilterEntity_ID { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        
        public virtual CategoryEntity Category { get; set; }

        public virtual List<FilterEntity> Filters { get; set; }
    }
}