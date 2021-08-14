using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyWarehouseManagement
{
    class UserDal
    {
        public bool VerifyLogin(string userName, string password)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                var result = context.Users.SingleOrDefault(p => p.UserName == userName && p.Password == password);
                return result != null;
            }
        }
    }
}
