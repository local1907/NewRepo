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
    [Table("Category")]
    public class Category : BaseEntity
    {
        public Category()
        {
            this.UnderCategories = new List<UnderCategory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int CategoryID { get; set; }
        [MaxLength]
        [Required(ErrorMessage = "Category Name is required")]
        public string CategoryName { get; set; }
        [MaxLength]
        [Required(ErrorMessage = "Category Desc is required")]
        public string CategoryDesc { get; set; }

        public virtual List<UnderCategory> UnderCategories { get; set; }
    }



}
