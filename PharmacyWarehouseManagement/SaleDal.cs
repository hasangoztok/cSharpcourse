using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyWarehouseManagement
{
    class SaleDal
    {
        public List<Sale> GetAll()
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                return context.Sales.ToList();
            }
        }
        public void Add(Sale sale)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                var entity = context.Entry(sale);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
