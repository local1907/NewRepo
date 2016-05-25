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
    [Table("Supplier")]
    public class Supplier : BaseEntity
    {
        public Supplier()
        {
            this.Products = new List<Products>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int SupplierID { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Contact First Name is required")]
        public string ContactFirstName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Contact Last Name is required")]
        public string ContactLastName { get; set; }
        [MaxLength(50)]
        public string ContactTitle { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Adress1 is required")]
        public string Adress1 { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Adress2 is required")]
        public string Adress2 { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [MaxLength(50)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [MaxLength]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Url { get; set; }
        [MaxLength(50)]
        public string PaymentMethod { get; set; }
        public int? Discount { get; set; }
        [MaxLength]
        public string ProductType { get; set; }
        [MaxLength]
        public string Notes { get; set; }
        [MaxLength]
        public string LogoPictureUrl { get; set; }

        public virtual List<Products> Products { get; set; }
    }

}
