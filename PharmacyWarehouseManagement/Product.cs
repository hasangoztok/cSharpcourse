using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyWarehouseManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string StockCode { get; set; }
        public string ProductName { get; set; }
        public string BarcodeNo { get; set; }
        public string Manufacturer { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int StockAmount { get; set; }
        public decimal UnitPrice { get; set; }

    }
   
}
