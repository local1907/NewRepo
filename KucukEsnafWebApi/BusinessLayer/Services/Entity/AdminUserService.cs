using BusinessLayer.Services.Base;
using DataLayer.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Dto.Admin;

namespace BusinessLayer.Services.Entity
{
   public class AdminUserService : BaseService<AdminUser>
    {
        public bool LoginControl(LoginDto _dto)
        {
            return db.A.Any(x => x.Email == _dto.Email && x.Password == _dto.Password);
        }

    }
}
