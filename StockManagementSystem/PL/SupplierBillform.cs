using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using StockManagementSystem;
using StockManagementSystem.Models;

namespace Stock_Management_Dev
{
    public partial class SupplierBillform : DevExpress.XtraEditors.XtraForm
    {
        public SupplierBillform()
        {
            InitializeComponent();
            Load += SupplierBillform_Load;
        }

        private void SupplierBillform_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                var suppliers = db.Suppliers.ToList();
                var supplierBills = db.SupplierBills.ToList();

                searchId.Properties.DataSource = suppliers;
                searchId.Properties.DisplayMember = "SupplierID";
                searchId.Properties.ValueMember = "SupplierID";
                searchId.Properties.NullText = "اختر المورد";
                searchId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                billID.Properties.DataSource = supplierBills;
                billID.Properties.DisplayMember = "SupplierBillID";
                billID.Properties.ValueMember = "SupplierBillID";
                billID.Properties.NullText = "اختر الفاتورة";
                billID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }

            searchId.EditValueChanged += searchId_EditValueChanged;
            billID.EditValueChanged += billID_EditValueChanged;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }

        private void searchId_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSupplier = searchId.GetSelectedDataRow() as Supplier;

            if (selectedSupplier != null)
            {
                txtname.Text = selectedSupplier.Name;
                txtphone.Text = selectedSupplier.Phone;
                txtEmail.Text = selectedSupplier.Email;
                txtcompany.Text = selectedSupplier.CompanyName;
                txtaddress.Text = selectedSupplier.Address;

                LoadBillsBySupplierID(selectedSupplier.SupplierID);
            }
        }

        private void billID_EditValueChanged(object sender, EventArgs e)
        {
            if (billID.EditValue == null) return;

            if (int.TryParse(billID.EditValue.ToString(), out int selectedBillID))
            {
                ShowBillDetails(selectedBillID);
            }
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridView1.GetFocusedRow();
            if (row == null) return;

            var prop = row.GetType().GetProperty("SupplierBillID");
            if (prop != null && int.TryParse(prop.GetValue(row)?.ToString(), out int billId))
            {
                ShowBillDetails(billId);
            }
        }

        private void LoadBillsBySupplierID(int supplierID)
        {
            using (var db = new AppDBContext())
            {
                var bills = db.SupplierBillItems
                    .Where(b => b.SupplierBillID == supplierID)
                    .Select(b => new
                    {
                 
                        b.ProductID,
                        b.Quantity,
                        b.TotalPrice,
                        b.PurchaseDate,
                        
                      
                    })
                    .ToList();

                gridControlProducts.DataSource = bills;
                gridView1.BestFitColumns();
            }
        }

        private void ShowBillDetails(int billId)
        {
            using (var db = new AppDBContext())
            {
                var bill = db.SupplierBills
                    .Include(b => b.Supplier)
                    .FirstOrDefault(b => b.SupplierBillID == billId);

                if (bill != null)
                {
                    dateTimePicker1.Value = bill.BillDate;
                    billID.EditValue = bill.SupplierBillID;
                    searchId.EditValue = bill.SupplierID;

                    txtname.Text = bill.Supplier?.Name;
                    txtphone.Text = bill.Supplier?.Phone;
                    txtcompany.Text = bill.Supplier?.CompanyName;
                    txtEmail.Text = bill.Supplier?.Email;
                    txtaddress.Text = bill.Supplier?.Address;

                    Total.Text = bill.TotalAmount.ToString("0.00");
                    unit.Text = bill.PaidAmount.ToString("0.00");

                    LoadProductsByBillID(bill.SupplierBillID);
                }
            }
        }

        private void LoadProductsByBillID(int billId)
        {
            using (var db = new AppDBContext())
            {
                var products = db.SupplierBillItems
                    .Include(i => i.Product)
                    .Where(i => i.SupplierBillID == billId)
                    .Select(i => new
                    {
                        i.ProductID,
                        ProductName = i.Product.Name,
                        i.Quantity,
                        i.UnitPrice,
                        i.TotalPrice,
                        i.Description,
                        i.PurchaseDate
                    })
                    .ToList();

                gridControlProducts.DataSource = products;
                gridView1.BestFitColumns();
            }
        }

        private void addnewbill_Click(object sender, EventArgs e)
        {
            var form2 = new Addsupbill();
            form2.ShowDialog();  
        }

        public void RefreshSupplierBills()
        {
            if (searchId.EditValue != null && int.TryParse(searchId.EditValue.ToString(), out int supplierId))
            {
                LoadBillsBySupplierID(supplierId);
            }
        }
    }
}
