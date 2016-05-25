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
    [Table("Customers")]
    public class Customers : BaseEntity 
    {
        public Customers()
        {
            this.Orders = new List<Orders>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int CustomerID { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Ad boş bırakılamaz.")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Soyad boş bırakılamaz.")]
        public string LastName { get; set; }
        [MaxLength]
        public string Adress1 { get; set; }
        [MaxLength]
        [Required(ErrorMessage = "Adres boş bırakılamaz.")]
        public string Adress2 { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Şehir ismi boş bırakılamaz.")]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Ülke boş bırakılamaz.")]
        public string Country { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Telefon boş bırakılamaz.")]
        public string Phone { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Email boş bırakılamaz"), EmailAddress(ErrorMessage = "Lütfen mail formatında giriniz.")]
        public string Email { get; set; }
        [MaxLength]
        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        public string Password { get; set; }
        [MaxLength]
        public string BillingAdress { get; set; }
        [MaxLength(50)]
        public string BillingCity { get; set; }
        [MaxLength(50)]
        public string BillingRegion { get; set; }
        [MaxLength(10)]
        public string BillingPostalCode { get; set; }
        [MaxLength(50)]
        public string BillingCountry { get; set; }
        [MaxLength]
        public string ShipAdress { get; set; }
        [MaxLength(50)]
        public string ShipCity { get; set; }
        [MaxLength(50)]
        public string ShipRegion { get; set; }
        [MaxLength(50)]
        public string ShipCountry { get; set; }
        [Required(ErrorMessage = "Giriş tarihi boş bırakılamaz.")]
        public DateTime DateEntered { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }

        public virtual List<Orders> Orders { get; set; }
    }


}
