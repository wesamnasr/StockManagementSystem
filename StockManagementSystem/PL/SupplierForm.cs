using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class SupplierForm : UserControl
    {
        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting; // Connect the event

        }

        private void LoadSuppliers()
        {
            var context = new AppDBContext();
            dataGridView1.DataSource = context.Suppliers.ToList();
            if (dataGridView1.Columns.Contains("Invoices"))
                dataGridView1.Columns["Invoices"].Visible = false;

            if (dataGridView1.Columns.Contains("Products"))
                dataGridView1.Columns["Products"].Visible = false;
            SetArabicHeaders();

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var addForm = new AddSupplierForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ////edit supp
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit" && e.RowIndex >= 0)
            {
                int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);

                using (var db = new AppDBContext())
                {
                    var supplier = db.Suppliers.Find(supplierId);
                    if (supplier != null)
                    {
                        var editForm = new AddSupplierForm();
                        editForm.CurrentSupplier = supplier;

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadSuppliers();
                        }
                    }
                }
            }

            ///delete supp
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colDelete" && e.RowIndex >= 0)
            {
                int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);

                var confirm = MessageBox.Show("هل انت متاكد من حذف هذا المورد؟",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (var db = new AppDBContext())
                    {
                        var supplierToDelete = db.Suppliers.Find(supplierId);
                        if (supplierToDelete != null)
                        {
                            db.Suppliers.Remove(supplierToDelete);
                            db.SaveChanges();
                            MessageBox.Show("تم حذف المورد");
                            LoadSuppliers(); 
                        }
                        else
                        {
                            MessageBox.Show("لايمكن العثور علي هذا المورد.");
                        }
                    }
                }
            }


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit")
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.IndianRed;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                string searchText = txtSearch.Text.ToLower();

                var filtered = db.Suppliers
                    .Where(s => s.Name.ToLower().Contains(searchText)
                             || s.Phone.Contains(searchText)
                             || s.CompanyName.ToLower().Contains(searchText))
                    .ToList();

                dataGridView1.DataSource = filtered;

                SetArabicHeaders();
            }
        }
        private void FilterSuppliers(string searchText)
        {
            using (var db = new AppDBContext())
            {
               // decimal.TryParse(searchText, out decimal duesAmount);

                var filtered = db.Suppliers
                    .Where(s => s.Name.Contains(searchText) ||
                                s.Phone.Contains(searchText) ||
                                s.CompanyName.Contains(searchText) ||
                                s.Email.Contains(searchText) ||
                                s.Address.Contains(searchText)
                              //  s.Dues == duesAmount
                                )
                    .ToList();

                dataGridView1.DataSource = filtered;
                SetArabicHeaders(); 
            }
        }

        private void SetArabicHeaders()
        {
            dataGridView1.Columns["SupplierID"].HeaderText = "رقم المورد";
            dataGridView1.Columns["Name"].HeaderText = "الاسم";
            dataGridView1.Columns["Phone"].HeaderText = "رقم الهاتف";
            dataGridView1.Columns["CompanyName"].HeaderText = "اسم الشركة";
            dataGridView1.Columns["Description"].HeaderText = "الوصف";
            dataGridView1.Columns["Email"].HeaderText = "البريد الإلكتروني";
            dataGridView1.Columns["Address"].HeaderText = "العنوان";
            dataGridView1.Columns["Dues"].HeaderText = "المستحقات";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterSuppliers(txtSearch.Text);

        }
    }
}
