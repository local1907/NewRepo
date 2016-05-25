using DataLayer.Orm.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Orm
{
    public class AdminUser : BaseEntity
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

    }
}
