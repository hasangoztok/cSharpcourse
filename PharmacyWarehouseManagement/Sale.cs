using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyWarehouseManagement
{
    public class Sale
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerIdNumber { get; set; }
        public string ProductName { get; set; }
        public int SaleAmount { get; set; }
        public decimal TotalCost { get; set; }
    }
}
