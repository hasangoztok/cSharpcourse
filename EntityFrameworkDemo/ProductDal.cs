using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
               /* dgwProducts.DataSource =*/ return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                return context.Products.Where(p=>p.ProductName.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }


        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                return context.Products.Where(p => p.UnitPrice>=min || p.UnitPrice<=max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                /* var result= context.Products.FirstOrDefault(p=>p.Id==id);  */     //data bulamazsan null, eşleşen data bulursan onu getir
                var result = context.Products.SingleOrDefault(p => p.Id == id);      //aynı nitelikte birden fazla ürün varsa hata verir, id ile çalışılıyorsa problem değil.
                return result;
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* dgwProducts.DataSource =*/
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
