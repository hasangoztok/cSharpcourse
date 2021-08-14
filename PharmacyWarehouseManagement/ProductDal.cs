using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyWarehouseManagement
{
    class ProductDal
    {
        public List<Product> GetAll()
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                return context.Products.Where(p => p.ProductName.Contains(key)).ToList();
            }
        }
        public Product GetById(int id)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                var result = context.Products.SingleOrDefault(p => p.Id == id);
                return result;
            }
        }
        public void Add(Product product)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (PharmacyContext context = new PharmacyContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
