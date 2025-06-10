using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using DevExpress.XtraSpreadsheet.Export;
using Stock_Management_Dev;
namespace StockManagementSystem
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        FORM_Home home = new FORM_Home();
        public Main()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = true;
            FORM_Home homeControl = new FORM_Home();
            homeControl.Dock = DockStyle.Fill; 
            pn_container.Controls.Add(homeControl.pn_stats);
        }
        #region Drag
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion


        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            home.Controls.Clear();
            home.Controls.Add(home.pn_stats);
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            pn_container.Controls.Clear(); 
            switch (e.Element.Text)
            {
                case "الرئيسية": 
                    FORM_Home form = new FORM_Home(); 
                    form.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(form.pn_stats);
                    label_title.Text = "الرئيسية";
                    break;
                case "الموردين": 
                    SupplierForm supplierForm = new SupplierForm();
                    supplierForm.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(supplierForm);
                    label_title.Text = "الموردين";
                    break;
                case "فاتورة عميل":
                    CustomerBillForm customerForm = new CustomerBillForm();
                    customerForm.Dock = DockStyle.Fill;
                    customerForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    pn_container.Controls.Add(customerForm);
                    label_title.Text = "فاتورة عميل";
                    break;
                case "فاتورة مورد":
                    SupplierBillform supplierBillform = new SupplierBillform();
                    supplierBillform.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(supplierBillform);
                    label_title.Text = "فاتورة مورد";
                    break;                              
                case "العملاء":
                    CustomerForm customer = new CustomerForm();
                    customer.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(customer);
                    label_title.Text = "العملاء";
                    break;
                case "الفواتير":
                    BillsView billView = new BillsView();
                    billView.pn_cont.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(billView.pn_cont);
                    label_title.Text = "الفواتير";
                    break;
                case "الأصناف": 
                    ProductsForm products = new ProductsForm();
                    products.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(products);
                    label_title.Text = "الأصناف";
                    break;
                case "تغيير كلمة السر":
                    label_title.Text = "تغيير كلمة السر";
                    ChangePassword change = new ChangePassword();
                    change.Dock = DockStyle.Fill;
                    pn_container.Controls.Add(change);
                    break;
            }
        }
    }
}
