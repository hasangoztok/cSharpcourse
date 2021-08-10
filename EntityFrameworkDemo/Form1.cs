using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {

           /* dgwProducts.DataSource = _productDal.GetAll().Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList(); *///kolleksiyondan çekme

            var result = _productDal.GetByName(key);  //direkt veritabanından çekme // veritabanından çekince küçük büyük harf fark etmez
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                ProductName = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt16(tbxStockAmount.Text)

            });
          
            LoadProducts();
            MessageBox.Show("Added!");
        }

     

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product()
            {
                Id = Convert.ToInt16(dgwProducts.CurrentRow.Cells[0].Value),
                ProductName = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt16(tbxStockAmountUpdate.Text)

            });
            LoadProducts();
            MessageBox.Show("Updated");
            UpdateClear();

        }

        private void UpdateClear()
        {
            tbxNameUpdate.Clear();
            tbxStockAmountUpdate.Clear();
            tbxUnitPriceUpdate.Clear();
            tbxNameUpdate.Focus();
        }

        private void AddClear()
        {
            tbxName.Clear();
            tbxStockAmount.Clear();
            tbxUnitPrice.Clear();
            tbxName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateClear();
            AddClear();
            _productDal.Delete(new Product()
            {
                Id = Convert.ToInt16(dgwProducts.CurrentRow.Cells[0].Value)

            });

            LoadProducts();
            MessageBox.Show("Deleted!!!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
            
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(2002);
        }
    }
}
