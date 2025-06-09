using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using StockManagementSystem;
using StockManagementSystem.Models;

namespace Stock_Management_Dev
{
    public partial class Addsupbill : Form
    {
        private List<SupplierBillItem> tempBillItems = new List<SupplierBillItem>();

        public Addsupbill()
        {
            InitializeComponent();
            Load += Addsupbill_Load;

            btnUpdateQuantities.Click += btnUpdateQuantities_Click;
            btnAddProductt.Click += BtnAddProductt_Click;
            btnAddSupplierBillItem.Click += btnAddSupplierBillItem_Click_1;
        }

        private void Addsupbill_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("ar-EG");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            dgvProducts.Columns.Clear();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AllowUserToAddRows = false;

            dgvProducts.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Select", HeaderText = "اختر", Width = 50 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProductID", HeaderText = "ID", Visible = false });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "اسم المنتج", ReadOnly = true });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuantityInStock", HeaderText = "الكمية الحالية", ReadOnly = true });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "UnitPrice", HeaderText = "سعر الوحدة", ReadOnly = true });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "AddedQuantity", HeaderText = "الكمية المضافة" });

     

            LoadProductsFromDatabase();
        }

        private void LoadProductsFromDatabase()
        {
            dgvProducts.Rows.Clear();
            using (var db = new AppDBContext())
            {
                var products = db.Products.ToList();
                foreach (var product in products)
                {
                    dgvProducts.Rows.Add(false, product.ProductID, product.Name, product.QuantityInStock, product.UnitPrice, "0");
                }
            }
        }

        private void BtnAddProductt_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("يرجى إدخال اسم المنتج");
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("أدخل كمية صحيحة أكبر من صفر");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("أدخل سعر وحدة صحيح أكبر من صفر");
                return;
            }

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["Name"].Value != null &&
                    row.Cells["Name"].Value.ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("هذا المنتج موجود بالفعل في القائمة.");
                    return;
                }
            }

            dgvProducts.Rows.Add(false, 0, name, 0, unitPrice, quantity.ToString());
            MessageBox.Show("تمت إضافة المنتج مؤقتاً إلى الفاتورة.\nيرجى الضغط على \"تحديث الكميات\" ثم \"حفظ\" لتثبيته في قاعدة البيانات.");

            txtProductName.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
        }

        private void btnUpdateQuantities_Click(object sender, EventArgs e)
        {
            tempBillItems.Clear();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                bool isSelected = row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value;
                if (!isSelected) continue;

                string name = row.Cells["Name"].Value?.ToString();
                if (!int.TryParse(row.Cells["AddedQuantity"].Value?.ToString(), out int addedQty) || addedQty <= 0)
                    continue;

                if (!decimal.TryParse(row.Cells["UnitPrice"].Value?.ToString(), out decimal unitPrice))
                    unitPrice = 0;

                if (!int.TryParse(row.Cells["QuantityInStock"].Value?.ToString(), out int currentStock))
                    currentStock = 0;

                int productId = int.TryParse(row.Cells["ProductID"].Value?.ToString(), out var id) ? id : 0;

                row.Cells["QuantityInStock"].Value = currentStock + addedQty;
                row.Cells["AddedQuantity"].Value = "0";

                tempBillItems.Add(new SupplierBillItem
                {
                    ProductID = productId,
                    Quantity = addedQty,
                    UnitPrice = unitPrice,
                    Description = name
                });
            }

            MessageBox.Show("تم تحديث الكميات مؤقتاً. اضغط حفظ لحفظ التعديلات.");
        }

        private void btnAddSupplierBillItem_Click_1(object sender, EventArgs e)
        {
            if (tempBillItems.Count == 0)
            {
                MessageBox.Show("لا توجد تعديلات للحفظ.");
                return;
            }

            using (var db = new AppDBContext())
            {
                var newSupplierBill = new SupplierBill
                {
                    SupplierID = 1,
                    BillDate = DateTime.Now
                };

                db.SupplierBills.Add(newSupplierBill);
                db.SaveChanges();

                foreach (var item in tempBillItems)
                {
                    string name = item.Description;
                    int quantity = item.Quantity;
                    decimal unitPrice = item.UnitPrice;
                    int productId = item.ProductID;

                    if (string.IsNullOrWhiteSpace(name) || quantity <= 0 || unitPrice <= 0)
                        continue;

                    if (productId == 0)
                    {
                        var existingProduct = db.Products.FirstOrDefault(p => p.Name == name);
                        if (existingProduct != null)
                        {
                            existingProduct.QuantityInStock += quantity;
                            existingProduct.UnitPrice = unitPrice;
                            db.SaveChanges();
                            productId = existingProduct.ProductID;
                        }
                        else
                        {
                            var newProduct = new Product
                            {
                                Name = name,
                                QuantityInStock = quantity,
                                UnitPrice = unitPrice
                            };

                            db.Products.Add(newProduct);
                            db.SaveChanges();
                            productId = newProduct.ProductID;
                        }
                    }
                    else
                    {
                        var product = db.Products.FirstOrDefault(p => p.ProductID == productId);
                        if (product != null)
                        {
                            product.QuantityInStock += quantity;
                            product.UnitPrice = unitPrice;
                            db.SaveChanges();
                        }
                    }

                    var billItem = new SupplierBillItem
                    {
                        SupplierBillID = newSupplierBill.SupplierBillID,
                        ProductID = productId,
                        Quantity = quantity,
                        UnitPrice = unitPrice,
                        TotalPrice = quantity * unitPrice,
                        PurchaseDate = DateTime.Now,
                        Description = name
                    };

                    db.SupplierBillItems.Add(billItem);
                }

                db.SaveChanges();
                tempBillItems.Clear();
                LoadProductsFromDatabase();

                MessageBox.Show("تم حفظ الفاتورة وتحديث قاعدة البيانات بنجاح.");
            }
        }

      
    }
}
