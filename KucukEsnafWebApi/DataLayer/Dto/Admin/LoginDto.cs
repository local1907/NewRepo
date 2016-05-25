using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dto.Admin
{
    class LoginDto
    {
        [Required(ErrorMessage = "Mail adresi boş bırakılamaz"), EmailAddress(ErrorMessage = "Lütfen mail formatında giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        public string Password { get; set; }
    }
}
