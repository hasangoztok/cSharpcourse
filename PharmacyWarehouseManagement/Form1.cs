using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyWarehouseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ProductDal _productDal = new ProductDal();
        private SaleDal _saleDal = new SaleDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSales();
        }
        private void LoadProducts()
        {
            dgwStockTab.DataSource = _productDal.GetAll();
            dgwSaleTab1.DataSource = _productDal.GetAll();
        }
        private void LoadSales()
        {
            dgwSaleTab2.DataSource = _saleDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            var result = _productDal.GetByName(key);
            dgwStockTab.DataSource = result;
            dgwSaleTab1.DataSource = result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                StockCode = txtStockCode.Text,
                ProductName = txtProductName.Text,
                BarcodeNo = txtBarcodeNo.Text,
                Manufacturer = txtManufacturer.Text,
                PurchaseDate = Convert.ToDateTime(dtPurchaseDate.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Saved!!!");
            TxtClear();
        }
        private void dgwStockTab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStockCode.Text = dgwStockTab.CurrentRow.Cells[1].Value.ToString();
            txtProductName.Text = dgwStockTab.CurrentRow.Cells[2].Value.ToString();
            txtBarcodeNo.Text = dgwStockTab.CurrentRow.Cells[3].Value.ToString();
            txtManufacturer.Text = dgwStockTab.CurrentRow.Cells[4].Value.ToString();
            txtStockAmount.Text = dgwStockTab.CurrentRow.Cells[6].Value.ToString();
            txtUnitPrice.Text = dgwStockTab.CurrentRow.Cells[7].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedProduct = _productDal.GetById(Convert.ToInt32(dgwStockTab.CurrentRow.Cells[0].Value));
            updatedProduct.StockCode = txtStockCode.Text;
            updatedProduct.ProductName = txtProductName.Text;
            updatedProduct.BarcodeNo = txtBarcodeNo.Text;
            updatedProduct.Manufacturer = txtManufacturer.Text;
            updatedProduct.PurchaseDate = Convert.ToDateTime(dtPurchaseDate.Text);
            updatedProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            updatedProduct.StockAmount = Convert.ToInt32(txtStockAmount.Text);
            LoadProducts();
            MessageBox.Show("Updated!!!");
            TxtClear();
        }
        private void TxtClear()
        {
            txtStockCode.Clear();
            txtProductName.Clear();
            txtBarcodeNo.Clear();
            txtManufacturer.Clear();
            txtStockAmount.Clear();
            txtUnitPrice.Clear();
            txtCustomerName.Clear();
            txtCustomerSurname.Clear();
            txtCustomerIdNumber.Clear();
            txtMedicineName.Clear();
            numericUpDownAmount.Value = 1;
        }
        private void btnClearTab1_Click(object sender, EventArgs e)
        {
            TxtClear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TxtClear();
            var deletedProduct = _productDal.GetById(Convert.ToInt32(dgwStockTab.CurrentRow.Cells[0].Value));
            _productDal.Delete(deletedProduct);

            LoadProducts();
            MessageBox.Show("Deleted!!!");
        }
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearchProduct.Text);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDownAmount.Value) <= Convert.ToInt32(dgwSaleTab1.CurrentRow.Cells[6].Value))
            {
                _saleDal.Add(new Sale()
                {
                    CustomerName = txtCustomerName.Text,
                    CustomerSurname = txtCustomerSurname.Text,
                    CustomerIdNumber = txtCustomerIdNumber.Text,
                    SaleAmount = Convert.ToInt16(numericUpDownAmount.Value),
                    ProductName = Convert.ToString(dgwSaleTab1.CurrentRow.Cells[2].Value),
                    TotalCost = (decimal)Convert.ToInt16(numericUpDownAmount.Value) * Convert.ToInt16(dgwSaleTab1.CurrentRow.Cells[7].Value)

                });
                var updatedProduct = _productDal.GetById(Convert.ToInt32(dgwStockTab.CurrentRow.Cells[0].Value));
                updatedProduct.StockAmount = Convert.ToInt32(dgwSaleTab1.CurrentRow.Cells[6].Value) -
                                             Convert.ToInt32(numericUpDownAmount.Value);
                _productDal.Update(updatedProduct);

                LoadProducts();
                LoadSales();
                MessageBox.Show("Confirmed");
                TxtClear();
            }
            else
            {
                MessageBox.Show("The amount of product you requested is not available in the stock", "Warning", MessageBoxButtons.OK);
            }
        }
        private void btnClearTab2_Click(object sender, EventArgs e)
        {
            TxtClear();

        }
        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtMedicineName.Text);
        }
        private void dgwSaleTab1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineName.Text = dgwStockTab.CurrentRow.Cells[2].Value.ToString();
        }
    }
}


