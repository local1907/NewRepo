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
    [Table("Shippers")]
    public class Shippers : BaseEntity
    {
        public Shippers()
        {
            this.Orders = new List<Orders>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int ShipperID { get; set; }
        [MaxLength]
        public string CompanyName { get; set; }
        [MaxLength(50)]
        public string CompanyPhone { get; set; }

        public virtual List<Orders> Orders { get; set; }
    }

}
