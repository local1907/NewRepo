using DataLayer.Orm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Orm
{
    [Table("UnderCategory")]
    public class UnderCategory : BaseEntity
    {
        public UnderCategory()
        {
            this.Products = new List<Products>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Under Cat ID is required")]
        public int UnderCatID { get; set; }
        [MaxLength]
        [Required(ErrorMessage = "Under Cat Name is required")]
        public string UnderCatName { get; set; }
        [MaxLength]
        public string UnderCatDesc { get; set; }
        public int? CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        public virtual List<Products> Products { get; set; }
    }

}
