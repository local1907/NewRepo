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
    [Table("Payment")]
    public class Payment :BaseEntity
    {
        public Payment()
        {
            this.Orders = new List<Orders>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int PaymentID { get; set; }
        [MaxLength(50)]
        public string PaymentType { get; set; }
        public bool? Allowed { get; set; }

        public virtual List<Orders> Orders { get; set; }
    }

}
