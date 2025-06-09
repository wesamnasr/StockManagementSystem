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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("برجاء ادخال اسم العميل !");
                return;
            }
            var context = new AppDBContext();
            if (CurrentCustomer == null)
            { //add new
                var newCustomer = new Customer
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Debt = int.Parse(txtDept.Text) 
                };

                context.Customers.Add(newCustomer);
             }
            else
            {
                var updatedCustomer=context.Customers.Find(CurrentCustomer.CustomerID);
                if (updatedCustomer != null) {
                    updatedCustomer.Name = txtName.Text.Trim();
                    updatedCustomer.Phone = txtPhone.Text.Trim();
                    updatedCustomer.Email = txtEmail.Text.Trim();
                    updatedCustomer.Address = txtAddress.Text.Trim();
                    updatedCustomer.Debt= int.Parse(txtDept.Text);
                }

            }
             context.SaveChanges();

            MessageBox.Show("تم حفظ العميل بنجاح");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            addLabel.Text = "اضافه عميل";
            if (CurrentCustomer != null) //  Edit mode
            {
                addLabel.Text = "تعديل بيانات العميل";

                txtName.Text = CurrentCustomer.Name;
                txtPhone.Text = CurrentCustomer.Phone;
                txtEmail.Text = CurrentCustomer.Email;
                txtAddress.Text = CurrentCustomer.Address;
                txtDept.Text=CurrentCustomer.Debt.ToString();
            }
        }

        public Customer CurrentCustomer { get; set; }

    }
}
