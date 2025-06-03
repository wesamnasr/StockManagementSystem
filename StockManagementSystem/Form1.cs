using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            CustomerBillForm customerBillForm = new CustomerBillForm();
            customerBillForm.Dock = DockStyle.Fill;
           
            this.Controls.Add(customerBillForm);
            this.Text = "Customer Bill Management System";
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            customerBillForm.Show();

        }

    }
}
