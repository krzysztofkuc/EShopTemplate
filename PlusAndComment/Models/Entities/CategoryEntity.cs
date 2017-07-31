using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlusAndComment.Models.Entities
{
    [Table("CategoryEntity")]
    public class CategoryEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoryEntity()
        {
            this.Categories = new HashSet<CategoryEntity>();
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Categories")]
        public Nullable<int> Category_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryEntity> Categories { get; set; }
    }
}