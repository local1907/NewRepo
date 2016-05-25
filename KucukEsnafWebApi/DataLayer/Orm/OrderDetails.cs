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
    [Table("OrderDetails")]
    public class OrderDetails : BaseEntity
    {
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? OrderNumber { get; set; }
        public decimal? Price { get; set; }
        public int? Quanty { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Total { get; set; }
        [MaxLength(50)]
        public string Size { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        [MaxLength(50)]
        public string Fulfilled { get; set; }
        public DateTime? ShipDate { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int OrderDetailID { get; set; }
        public DateTime? BillDate { get; set; }

        [ForeignKey("OrderID")]
        public virtual Orders Order { get; set; }
        [ForeignKey("ProductID")]
        public virtual Products Product { get; set; }
    }

}
