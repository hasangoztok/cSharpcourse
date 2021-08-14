
namespace PharmacyWarehouseManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSearchCustomerName = new System.Windows.Forms.Label();
            this.txtSearchByCustomerName = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtCustomerIdNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnClearTab2 = new System.Windows.Forms.Button();
            this.dgwSaleTab2 = new System.Windows.Forms.DataGridView();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dgwSaleTab1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearTab1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtBarcodeNo = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.dgwStockTab = new System.Windows.Forms.DataGridView();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblBarcodeNo = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaleTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaleTab1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockTab)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.lblSearchCustomerName);
            this.tabPage2.Controls.Add(this.txtSearchByCustomerName);
            this.tabPage2.Controls.Add(this.txtMedicineName);
            this.tabPage2.Controls.Add(this.txtCustomerIdNumber);
            this.tabPage2.Controls.Add(this.txtCustomerSurname);
            this.tabPage2.Controls.Add(this.txtCustomerName);
            this.tabPage2.Controls.Add(this.btnClearTab2);
            this.tabPage2.Controls.Add(this.dgwSaleTab2);
            this.tabPage2.Controls.Add(this.lblMedicineName);
            this.tabPage2.Controls.Add(this.btnConfirm);
            this.tabPage2.Controls.Add(this.lblAmount);
            this.tabPage2.Controls.Add(this.numericUpDownAmount);
            this.tabPage2.Controls.Add(this.lblIdNumber);
            this.tabPage2.Controls.Add(this.lblCustomerSurname);
            this.tabPage2.Controls.Add(this.lblCustomerName);
            this.tabPage2.Controls.Add(this.dgwSaleTab1);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sale";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSearchCustomerName
            // 
            this.lblSearchCustomerName.AutoSize = true;
            this.lblSearchCustomerName.Location = new System.Drawing.Point(6, 282);
            this.lblSearchCustomerName.Name = "lblSearchCustomerName";
            this.lblSearchCustomerName.Size = new System.Drawing.Size(145, 13);
            this.lblSearchCustomerName.TabIndex = 15;
            this.lblSearchCustomerName.Text = "Search by Customer Name";
            // 
            // txtSearchByCustomerName
            // 
            this.txtSearchByCustomerName.Location = new System.Drawing.Point(9, 298);
            this.txtSearchByCustomerName.Name = "txtSearchByCustomerName";
            this.txtSearchByCustomerName.Size = new System.Drawing.Size(152, 20);
            this.txtSearchByCustomerName.TabIndex = 14;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(127, 106);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(120, 20);
            this.txtMedicineName.TabIndex = 10;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            // 
            // txtCustomerIdNumber
            // 
            this.txtCustomerIdNumber.Location = new System.Drawing.Point(127, 72);
            this.txtCustomerIdNumber.Name = "txtCustomerIdNumber";
            this.txtCustomerIdNumber.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerIdNumber.TabIndex = 6;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(127, 38);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerSurname.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerName.Location = new System.Drawing.Point(127, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // btnClearTab2
            // 
            this.btnClearTab2.BackColor = System.Drawing.Color.White;
            this.btnClearTab2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearTab2.BackgroundImage")));
            this.btnClearTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearTab2.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearTab2.Location = new System.Drawing.Point(138, 162);
            this.btnClearTab2.Name = "btnClearTab2";
            this.btnClearTab2.Size = new System.Drawing.Size(109, 60);
            this.btnClearTab2.TabIndex = 13;
            this.btnClearTab2.Text = "Clear";
            this.btnClearTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearTab2.UseVisualStyleBackColor = false;
            this.btnClearTab2.Click += new System.EventHandler(this.btnClearTab2_Click);
            // 
            // dgwSaleTab2
            // 
            this.dgwSaleTab2.AllowDrop = true;
            this.dgwSaleTab2.AllowUserToAddRows = false;
            this.dgwSaleTab2.AllowUserToDeleteRows = false;
            this.dgwSaleTab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSaleTab2.GridColor = System.Drawing.SystemColors.Control;
            this.dgwSaleTab2.Location = new System.Drawing.Point(3, 322);
            this.dgwSaleTab2.Name = "dgwSaleTab2";
            this.dgwSaleTab2.ReadOnly = true;
            this.dgwSaleTab2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSaleTab2.Size = new System.Drawing.Size(991, 258);
            this.dgwSaleTab2.TabIndex = 12;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Location = new System.Drawing.Point(23, 109);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(85, 13);
            this.lblMedicineName.TabIndex = 11;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.Location = new System.Drawing.Point(9, 162);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 60);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(39, 137);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(127, 135);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAmount.TabIndex = 7;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(30, 75);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(61, 13);
            this.lblIdNumber.TabIndex = 3;
            this.lblIdNumber.Text = "Id Number";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Location = new System.Drawing.Point(3, 41);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(115, 13);
            this.lblCustomerSurname.TabIndex = 2;
            this.lblCustomerSurname.Text = "Customer\'s Surname";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(11, 10);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(97, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer\'s Name";
            // 
            // dgwSaleTab1
            // 
            this.dgwSaleTab1.AllowUserToAddRows = false;
            this.dgwSaleTab1.AllowUserToDeleteRows = false;
            this.dgwSaleTab1.AllowUserToOrderColumns = true;
            this.dgwSaleTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSaleTab1.Location = new System.Drawing.Point(266, 3);
            this.dgwSaleTab1.Name = "dgwSaleTab1";
            this.dgwSaleTab1.RowHeadersWidth = 40;
            this.dgwSaleTab1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSaleTab1.Size = new System.Drawing.Size(734, 310);
            this.dgwSaleTab1.TabIndex = 0;
            this.dgwSaleTab1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSaleTab1_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.lblSearch);
            this.tabPage1.Controls.Add(this.txtSearchProduct);
            this.tabPage1.Controls.Add(this.dtPurchaseDate);
            this.tabPage1.Controls.Add(this.btnClearTab1);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtUnitPrice);
            this.tabPage1.Controls.Add(this.txtStockAmount);
            this.tabPage1.Controls.Add(this.txtManufacturer);
            this.tabPage1.Controls.Add(this.txtBarcodeNo);
            this.tabPage1.Controls.Add(this.txtProductName);
            this.tabPage1.Controls.Add(this.txtStockCode);
            this.tabPage1.Controls.Add(this.dgwStockTab);
            this.tabPage1.Controls.Add(this.lblUnitPrice);
            this.tabPage1.Controls.Add(this.lblStockAmount);
            this.tabPage1.Controls.Add(this.lblPurchaseDate);
            this.tabPage1.Controls.Add(this.lblManufacturer);
            this.tabPage1.Controls.Add(this.lblBarcodeNo);
            this.tabPage1.Controls.Add(this.lblProductName);
            this.tabPage1.Controls.Add(this.lblStockCode);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(619, 239);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 19);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Search";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(619, 258);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(100, 26);
            this.txtSearchProduct.TabIndex = 32;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.Location = new System.Drawing.Point(482, 38);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(271, 26);
            this.dtPurchaseDate.TabIndex = 31;
            // 
            // btnClearTab1
            // 
            this.btnClearTab1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearTab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearTab1.BackgroundImage")));
            this.btnClearTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearTab1.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearTab1.Location = new System.Drawing.Point(461, 214);
            this.btnClearTab1.Name = "btnClearTab1";
            this.btnClearTab1.Size = new System.Drawing.Size(109, 64);
            this.btnClearTab1.TabIndex = 30;
            this.btnClearTab1.Text = "Clear";
            this.btnClearTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearTab1.UseVisualStyleBackColor = false;
            this.btnClearTab1.Click += new System.EventHandler(this.btnClearTab1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(307, 214);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 64);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(175, 214);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 64);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(40, 214);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 64);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(482, 134);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(249, 26);
            this.txtUnitPrice.TabIndex = 25;
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(482, 82);
            this.txtStockAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(249, 26);
            this.txtStockAmount.TabIndex = 24;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(175, 158);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(152, 26);
            this.txtManufacturer.TabIndex = 22;
            // 
            // txtBarcodeNo
            // 
            this.txtBarcodeNo.Location = new System.Drawing.Point(175, 109);
            this.txtBarcodeNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcodeNo.Name = "txtBarcodeNo";
            this.txtBarcodeNo.Size = new System.Drawing.Size(152, 26);
            this.txtBarcodeNo.TabIndex = 21;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(175, 67);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(152, 26);
            this.txtProductName.TabIndex = 13;
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(175, 26);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(152, 26);
            this.txtStockCode.TabIndex = 12;
            // 
            // dgwStockTab
            // 
            this.dgwStockTab.AllowUserToAddRows = false;
            this.dgwStockTab.AllowUserToDeleteRows = false;
            this.dgwStockTab.AllowUserToOrderColumns = true;
            this.dgwStockTab.ColumnHeadersHeight = 50;
            this.dgwStockTab.Location = new System.Drawing.Point(4, 295);
            this.dgwStockTab.Margin = new System.Windows.Forms.Padding(4);
            this.dgwStockTab.Name = "dgwStockTab";
            this.dgwStockTab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStockTab.Size = new System.Drawing.Size(958, 284);
            this.dgwStockTab.TabIndex = 29;
            this.dgwStockTab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStockTab_CellClick);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(349, 141);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(99, 19);
            this.lblUnitPrice.TabIndex = 20;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(346, 89);
            this.lblStockAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(117, 19);
            this.lblStockAmount.TabIndex = 18;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(349, 38);
            this.lblPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(126, 19);
            this.lblPurchaseDate.TabIndex = 19;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(45, 161);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(117, 19);
            this.lblManufacturer.TabIndex = 15;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblBarcodeNo
            // 
            this.lblBarcodeNo.AutoSize = true;
            this.lblBarcodeNo.Location = new System.Drawing.Point(53, 112);
            this.lblBarcodeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcodeNo.Name = "lblBarcodeNo";
            this.lblBarcodeNo.Size = new System.Drawing.Size(99, 19);
            this.lblBarcodeNo.TabIndex = 14;
            this.lblBarcodeNo.Text = "Barcode No";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(50, 67);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(117, 19);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "Product Name";
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(53, 26);
            this.lblStockCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(99, 19);
            this.lblStockCode.TabIndex = 16;
            this.lblStockCode.Text = "Stock Code";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 534);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaleTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaleTab1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockTab)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSearchCustomerName;
        private System.Windows.Forms.TextBox txtSearchByCustomerName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtCustomerIdNumber;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnClearTab2;
        private System.Windows.Forms.DataGridView dgwSaleTab2;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dgwSaleTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClearTab1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtBarcodeNo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtStockCode;
        private System.Windows.Forms.DataGridView dgwStockTab;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblBarcodeNo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}

