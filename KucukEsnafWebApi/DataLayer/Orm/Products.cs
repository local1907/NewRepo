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
    [Table("Products")]
    public class Products : BaseEntity
    {
        public Products()
        {
            this.OrderDetails = new List<OrderDetails>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int ProductID { get; set; }
        public int? SKU { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }
        [MaxLength]
        public string ProductDescription { get; set; }
        public int? SupplierID { get; set; }
        public int? UnderCatID { get; set; }
        [MaxLength(50)]
        public string QuantiyPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        [MaxLength(10)]
        public string AvailableSize { get; set; }
        [MaxLength(50)]
        public string AvailableColor { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Size is required")]
        public string Size { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        public decimal? Discount { get; set; }
        public int? UnitWeight { get; set; }
        public int? UnitInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? RecorderLevel { get; set; }
        public bool? DiscountAvailable { get; set; }
        public int? CurrentOrder { get; set; }
        [MaxLength]
        public string PictureURL { get; set; }
        public int? Ranking { get; set; }
        [MaxLength]
        public string Notes { get; set; }
        public int? IDSKU { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        [ForeignKey("UnderCatID")]
        public virtual UnderCategory UnderCategory { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
    }

}
