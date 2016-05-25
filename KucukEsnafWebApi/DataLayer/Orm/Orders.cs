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
    [Table("Orders")]
    public class Orders : BaseEntity
    {
        public Orders()
        {
            this.OrderDetails = new List<OrderDetails>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int OrderID { get; set; }
        public int? CustomerID { get; set; }
        public int? OrderNumber { get; set; }
        public int? PaymentID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public int? ShipperID { get; set; }
        [MaxLength]
        public string Freight { get; set; }
        public decimal? SalesTax { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
        public bool? TransactStatus { get; set; }
        [MaxLength]
        public string ErrLog { get; set; }
        [MaxLength]
        public string ErrMsg { get; set; }
        [MaxLength(50)]
        public string Fulfilled { get; set; }
        public decimal? Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? IDSKU { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customers Customer { get; set; }
        [ForeignKey("PaymentID")]
        public virtual Payment Payment { get; set; }
        [ForeignKey("ShipperID")]
        public virtual Shippers ShippedBy { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
    }

}
