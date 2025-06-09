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
    public partial class CustomerForm : UserControl
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting; 

        }

        private void LoadCustomers()
        {
            var context = new AppDBContext();
            dataGridView1.DataSource = context.Customers.ToList();
            if (dataGridView1.Columns.Contains("Invoices"))
                dataGridView1.Columns["Invoices"].Visible = false;

           SetArabicHeaders();

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var addForm = new AddCustomerForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ////edit custom
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit" && e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);

                using (var db = new AppDBContext())
                {
                    var customer = db.Customers.Find(customerId);
                    if (customer != null)
                    {
                        var editForm = new AddCustomerForm();
                        editForm.CurrentCustomer = customer;

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadCustomers();
                        }
                    }
                }
            }

            ///delete custom
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colDelete" && e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);

                var confirm = MessageBox.Show("هل انت متاكد من حذف هذا العميل؟",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (var db = new AppDBContext())
                    {
                        var cutomerToDelete = db.Customers.Find(customerId);
                        if (cutomerToDelete != null)
                        {
                            db.Customers.Remove(cutomerToDelete);
                            db.SaveChanges();
                            MessageBox.Show("تم حذف العميل");
                            LoadCustomers(); 
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

     
        private void FilterCustomers(string searchText)
        {
            using (var db = new AppDBContext())
            {

                var filtered = db.Customers
                    .Where(s => s.Name.Contains(searchText) ||
                                s.Phone.Contains(searchText) ||
                                s.Email.Contains(searchText) ||
                                s.Address.Contains(searchText)
                                )
                    .ToList();

                dataGridView1.DataSource = filtered;
                SetArabicHeaders(); 
            }
        }

        private void SetArabicHeaders()
        {
            dataGridView1.Columns["CustomerID"].HeaderText = "رقم العميل";
            dataGridView1.Columns["Name"].HeaderText = "الاسم";
            dataGridView1.Columns["Phone"].HeaderText = "رقم الهاتف";
            dataGridView1.Columns["Email"].HeaderText = "البريد الإلكتروني";
            dataGridView1.Columns["Address"].HeaderText = "العنوان";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers(txtSearch.Text);

        }

    }
}
