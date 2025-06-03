namespace StockManagementSystem
{
    partial class CustomerBillForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            tb_PillRemainingAmount = new System.Windows.Forms.TextBox();
            tb_PillPaymentAmount = new System.Windows.Forms.TextBox();
            hl_DeleteBillData = new DevExpress.XtraEditors.HyperlinkLabelControl();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            lbl_ShowPillNumber = new DevExpress.XtraEditors.LabelControl();
            btn_PrintPill = new DevExpress.XtraEditors.SimpleButton();
            btn_SaveBill = new DevExpress.XtraEditors.SimpleButton();
            panel6 = new System.Windows.Forms.Panel();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            btn_showtotalPillPrice = new DevExpress.XtraEditors.SimpleButton();
            tb_PillDiscount = new System.Windows.Forms.TextBox();
            tb_TotalPillPrice = new System.Windows.Forms.TextBox();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            btn_DeletePillProduct = new DevExpress.XtraEditors.SimpleButton();
            btn_EditPillProduct = new DevExpress.XtraEditors.SimpleButton();
            panel3 = new System.Windows.Forms.Panel();
            sl_Customers = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            label1 = new System.Windows.Forms.Label();
            btn_AddCutomer = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            hl_DeleteCustomerData = new DevExpress.XtraEditors.HyperlinkLabelControl();
            tb_CustomerPhone = new System.Windows.Forms.TextBox();
            tb_CustomerAddress = new System.Windows.Forms.TextBox();
            tb_CustomerName = new System.Windows.Forms.TextBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            panel4 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel5 = new System.Windows.Forms.Panel();
            sl_Products = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            hl_DeleteProductData = new DevExpress.XtraEditors.HyperlinkLabelControl();
            label2 = new System.Windows.Forms.Label();
            btn_AddProduct = new DevExpress.XtraEditors.SimpleButton();
            btn_showtotalProductPrice = new DevExpress.XtraEditors.SimpleButton();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            tb_ProductPrice = new System.Windows.Forms.TextBox();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            tb_ProductCount = new System.Windows.Forms.TextBox();
            tb_ProductName = new System.Windows.Forms.TextBox();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sl_Customers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sl_Products.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkGray;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(labelControl14);
            panel1.Controls.Add(labelControl13);
            panel1.Controls.Add(tb_PillRemainingAmount);
            panel1.Controls.Add(tb_PillPaymentAmount);
            panel1.Controls.Add(hl_DeleteBillData);
            panel1.Controls.Add(labelControl12);
            panel1.Controls.Add(lbl_ShowPillNumber);
            panel1.Controls.Add(btn_PrintPill);
            panel1.Controls.Add(btn_SaveBill);
            panel1.Controls.Add(panel6);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 391);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(988, 245);
            panel1.TabIndex = 0;
            // 
            // labelControl14
            // 
            labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl14.Appearance.Options.UseFont = true;
            labelControl14.Location = new System.Drawing.Point(818, 56);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new System.Drawing.Size(43, 19);
            labelControl14.TabIndex = 18;
            labelControl14.Text = "الباقي";
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Location = new System.Drawing.Point(764, 21);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new System.Drawing.Size(97, 19);
            labelControl13.TabIndex = 17;
            labelControl13.Text = "المبلغ المدفوع";
            // 
            // tb_PillRemainingAmount
            // 
            tb_PillRemainingAmount.Location = new System.Drawing.Point(477, 54);
            tb_PillRemainingAmount.Name = "tb_PillRemainingAmount";
            tb_PillRemainingAmount.Size = new System.Drawing.Size(150, 21);
            tb_PillRemainingAmount.TabIndex = 16;
            // 
            // tb_PillPaymentAmount
            // 
            tb_PillPaymentAmount.Location = new System.Drawing.Point(477, 19);
            tb_PillPaymentAmount.Name = "tb_PillPaymentAmount";
            tb_PillPaymentAmount.Size = new System.Drawing.Size(150, 21);
            tb_PillPaymentAmount.TabIndex = 15;
            tb_PillPaymentAmount.TextChanged += textBox10_TextChanged;
            // 
            // hl_DeleteBillData
            // 
            hl_DeleteBillData.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            hl_DeleteBillData.Appearance.Options.UseFont = true;
            hl_DeleteBillData.Location = new System.Drawing.Point(664, 198);
            hl_DeleteBillData.Name = "hl_DeleteBillData";
            hl_DeleteBillData.Size = new System.Drawing.Size(40, 23);
            hl_DeleteBillData.TabIndex = 14;
            hl_DeleteBillData.Text = "حذف";
            hl_DeleteBillData.Click += hl_DeleteBillData_Click;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new System.Drawing.Point(785, 87);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new System.Drawing.Size(76, 19);
            labelControl12.TabIndex = 13;
            labelControl12.Text = "رقم الفاتورة";
            // 
            // lbl_ShowPillNumber
            // 
            lbl_ShowPillNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            lbl_ShowPillNumber.Appearance.Options.UseFont = true;
            lbl_ShowPillNumber.Location = new System.Drawing.Point(522, 81);
            lbl_ShowPillNumber.Name = "lbl_ShowPillNumber";
            lbl_ShowPillNumber.Size = new System.Drawing.Size(76, 19);
            lbl_ShowPillNumber.TabIndex = 12;
            lbl_ShowPillNumber.Text = "رقم الفاتورة";
            // 
            // btn_PrintPill
            // 
            btn_PrintPill.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            btn_PrintPill.Appearance.Options.UseFont = true;
            btn_PrintPill.Location = new System.Drawing.Point(477, 156);
            btn_PrintPill.Name = "btn_PrintPill";
            btn_PrintPill.Size = new System.Drawing.Size(150, 41);
            btn_PrintPill.TabIndex = 11;
            btn_PrintPill.Text = "طباعة";
            btn_PrintPill.Click += btn_PrintPill_Click;
            // 
            // btn_SaveBill
            // 
            btn_SaveBill.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            btn_SaveBill.Appearance.Options.UseFont = true;
            btn_SaveBill.Location = new System.Drawing.Point(733, 156);
            btn_SaveBill.Name = "btn_SaveBill";
            btn_SaveBill.Size = new System.Drawing.Size(140, 41);
            btn_SaveBill.TabIndex = 10;
            btn_SaveBill.Text = "حفظ";
            btn_SaveBill.Click += btn_SaveBill_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel6.Controls.Add(simpleButton2);
            panel6.Controls.Add(btn_showtotalPillPrice);
            panel6.Controls.Add(tb_PillDiscount);
            panel6.Controls.Add(tb_TotalPillPrice);
            panel6.Controls.Add(labelControl10);
            panel6.Controls.Add(labelControl9);
            panel6.Controls.Add(labelControl7);
            panel6.Dock = System.Windows.Forms.DockStyle.Left;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(343, 241);
            panel6.TabIndex = 0;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new System.Drawing.Point(184, 1);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(155, 26);
            simpleButton2.TabIndex = 18;
            simpleButton2.Text = "الحساب";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // btn_showtotalPillPrice
            // 
            btn_showtotalPillPrice.Location = new System.Drawing.Point(14, 130);
            btn_showtotalPillPrice.Name = "btn_showtotalPillPrice";
            btn_showtotalPillPrice.Size = new System.Drawing.Size(150, 39);
            btn_showtotalPillPrice.TabIndex = 17;
            // 
            // tb_PillDiscount
            // 
            tb_PillDiscount.Location = new System.Drawing.Point(14, 85);
            tb_PillDiscount.Name = "tb_PillDiscount";
            tb_PillDiscount.Size = new System.Drawing.Size(150, 21);
            tb_PillDiscount.TabIndex = 14;
            // 
            // tb_TotalPillPrice
            // 
            tb_TotalPillPrice.Location = new System.Drawing.Point(14, 50);
            tb_TotalPillPrice.Name = "tb_TotalPillPrice";
            tb_TotalPillPrice.Size = new System.Drawing.Size(150, 21);
            tb_TotalPillPrice.TabIndex = 11;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new System.Drawing.Point(227, 138);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(95, 19);
            labelControl10.TabIndex = 10;
            labelControl10.Text = "السعر النهائي";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new System.Drawing.Point(276, 85);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(34, 19);
            labelControl9.TabIndex = 9;
            labelControl9.Text = "خصم";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new System.Drawing.Point(265, 48);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(57, 19);
            labelControl7.TabIndex = 8;
            labelControl7.Text = "المجموع";
            // 
            // btn_DeletePillProduct
            // 
            btn_DeletePillProduct.Location = new System.Drawing.Point(66, 356);
            btn_DeletePillProduct.Name = "btn_DeletePillProduct";
            btn_DeletePillProduct.Size = new System.Drawing.Size(67, 28);
            btn_DeletePillProduct.TabIndex = 16;
            btn_DeletePillProduct.Text = "حذف";
            btn_DeletePillProduct.Click += btn_DeletePillProduct_Click;
            // 
            // btn_EditPillProduct
            // 
            btn_EditPillProduct.Location = new System.Drawing.Point(195, 358);
            btn_EditPillProduct.Name = "btn_EditPillProduct";
            btn_EditPillProduct.Size = new System.Drawing.Size(71, 26);
            btn_EditPillProduct.TabIndex = 15;
            btn_EditPillProduct.Text = "تعديل";
            btn_EditPillProduct.Click += btn_EditPillProduct_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(sl_Customers);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_AddCutomer);
            panel3.Controls.Add(labelControl3);
            panel3.Controls.Add(labelControl2);
            panel3.Controls.Add(labelControl1);
            panel3.Controls.Add(hl_DeleteCustomerData);
            panel3.Controls.Add(tb_CustomerPhone);
            panel3.Controls.Add(tb_CustomerAddress);
            panel3.Controls.Add(tb_CustomerName);
            panel3.Controls.Add(simpleButton1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Font = new System.Drawing.Font("Tahoma", 12F);
            panel3.Location = new System.Drawing.Point(690, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(298, 391);
            panel3.TabIndex = 2;
            // 
            // sl_Customers
            // 
            sl_Customers.Location = new System.Drawing.Point(5, 60);
            sl_Customers.Name = "sl_Customers";
            sl_Customers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            sl_Customers.Properties.PopupView = searchLookUpEdit1View;
            sl_Customers.Size = new System.Drawing.Size(125, 20);
            sl_Customers.TabIndex = 10;
            sl_Customers.EditValueChanged += sl_Customers_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(100, -1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "بيانات العميل";
            // 
            // btn_AddCutomer
            // 
            btn_AddCutomer.Location = new System.Drawing.Point(100, 275);
            btn_AddCutomer.Name = "btn_AddCutomer";
            btn_AddCutomer.Size = new System.Drawing.Size(140, 41);
            btn_AddCutomer.TabIndex = 9;
            btn_AddCutomer.Text = "اضافة";
            btn_AddCutomer.Click += btn_AddCutomer_Click;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(239, 198);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(45, 19);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "العنوان";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(239, 159);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(42, 19);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "الهاتف";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(238, 115);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(41, 19);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "الاسم";
            // 
            // hl_DeleteCustomerData
            // 
            hl_DeleteCustomerData.Location = new System.Drawing.Point(161, 325);
            hl_DeleteCustomerData.Name = "hl_DeleteCustomerData";
            hl_DeleteCustomerData.Size = new System.Drawing.Size(23, 13);
            hl_DeleteCustomerData.TabIndex = 5;
            hl_DeleteCustomerData.Text = "حذف";
            hl_DeleteCustomerData.Click += hl_DeleteCustomerData_Click;
            // 
            // tb_CustomerPhone
            // 
            tb_CustomerPhone.Location = new System.Drawing.Point(5, 151);
            tb_CustomerPhone.Name = "tb_CustomerPhone";
            tb_CustomerPhone.Size = new System.Drawing.Size(150, 27);
            tb_CustomerPhone.TabIndex = 4;
            // 
            // tb_CustomerAddress
            // 
            tb_CustomerAddress.Location = new System.Drawing.Point(5, 190);
            tb_CustomerAddress.Name = "tb_CustomerAddress";
            tb_CustomerAddress.Size = new System.Drawing.Size(150, 27);
            tb_CustomerAddress.TabIndex = 3;
            // 
            // tb_CustomerName
            // 
            tb_CustomerName.Location = new System.Drawing.Point(5, 115);
            tb_CustomerName.Name = "tb_CustomerName";
            tb_CustomerName.Size = new System.Drawing.Size(150, 27);
            tb_CustomerName.TabIndex = 2;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new System.Drawing.Point(175, 58);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(109, 23);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "عميل موجود سابقا";
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(gridControl1);
            panel4.Controls.Add(btn_EditPillProduct);
            panel4.Controls.Add(btn_DeletePillProduct);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(343, 391);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(97, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 25);
            label3.TabIndex = 0;
            label3.Text = "بيانات الفاتورة";
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(0, 28);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(343, 305);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // panel5
            // 
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Controls.Add(sl_Products);
            panel5.Controls.Add(hl_DeleteProductData);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btn_AddProduct);
            panel5.Controls.Add(btn_showtotalProductPrice);
            panel5.Controls.Add(labelControl8);
            panel5.Controls.Add(labelControl6);
            panel5.Controls.Add(tb_ProductPrice);
            panel5.Controls.Add(labelControl5);
            panel5.Controls.Add(labelControl4);
            panel5.Controls.Add(tb_ProductCount);
            panel5.Controls.Add(tb_ProductName);
            panel5.Controls.Add(simpleButton3);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(343, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(347, 391);
            panel5.TabIndex = 4;
            // 
            // sl_Products
            // 
            sl_Products.Location = new System.Drawing.Point(18, 55);
            sl_Products.Name = "sl_Products";
            sl_Products.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            sl_Products.Properties.PopupView = searchLookUpEdit2View;
            sl_Products.Size = new System.Drawing.Size(150, 20);
            sl_Products.TabIndex = 16;
            sl_Products.EditValueChanged += sl_Products_EditValueChanged;
            // 
            // searchLookUpEdit2View
            // 
            searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // hl_DeleteProductData
            // 
            hl_DeleteProductData.Location = new System.Drawing.Point(159, 320);
            hl_DeleteProductData.Name = "hl_DeleteProductData";
            hl_DeleteProductData.Size = new System.Drawing.Size(23, 13);
            hl_DeleteProductData.TabIndex = 15;
            hl_DeleteProductData.Text = "حذف";
            hl_DeleteProductData.Click += hl_DeleteProductData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(110, -1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 25);
            label2.TabIndex = 0;
            label2.Text = " المنتجات";
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Location = new System.Drawing.Point(87, 275);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new System.Drawing.Size(155, 39);
            btn_AddProduct.TabIndex = 14;
            btn_AddProduct.Text = "اضافة";
            btn_AddProduct.Click += btn_AddProduct_Click;
            // 
            // btn_showtotalProductPrice
            // 
            btn_showtotalProductPrice.Location = new System.Drawing.Point(51, 214);
            btn_showtotalProductPrice.Name = "btn_showtotalProductPrice";
            btn_showtotalProductPrice.Size = new System.Drawing.Size(98, 40);
            btn_showtotalProductPrice.TabIndex = 13;
            btn_showtotalProductPrice.Text = "السعر";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(181, 222);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(134, 19);
            labelControl8.TabIndex = 12;
            labelControl8.Text = "اجمالي سعر المنتج";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(226, 127);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(81, 19);
            labelControl6.TabIndex = 10;
            labelControl6.Text = "سعر القطعة";
            // 
            // tb_ProductPrice
            // 
            tb_ProductPrice.Location = new System.Drawing.Point(18, 127);
            tb_ProductPrice.Name = "tb_ProductPrice";
            tb_ProductPrice.Size = new System.Drawing.Size(150, 21);
            tb_ProductPrice.TabIndex = 9;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(209, 175);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(104, 19);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "الكمية المطلوبة";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(226, 98);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(78, 19);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "اسم المنتج";
            // 
            // tb_ProductCount
            // 
            tb_ProductCount.Location = new System.Drawing.Point(18, 173);
            tb_ProductCount.Name = "tb_ProductCount";
            tb_ProductCount.Size = new System.Drawing.Size(150, 21);
            tb_ProductCount.TabIndex = 4;
            tb_ProductCount.TextChanged += tb_ProductCount_TextChanged;
            // 
            // tb_ProductName
            // 
            tb_ProductName.Location = new System.Drawing.Point(18, 100);
            tb_ProductName.Name = "tb_ProductName";
            tb_ProductName.Size = new System.Drawing.Size(150, 21);
            tb_ProductName.TabIndex = 3;
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new System.Drawing.Point(209, 53);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new System.Drawing.Size(95, 23);
            simpleButton3.TabIndex = 1;
            simpleButton3.Text = "اختيار المنتج";
            // 
            // CustomerBillForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerBillForm";
            Size = new System.Drawing.Size(988, 636);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sl_Customers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sl_Products.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hl_DeleteCustomerData;
        private System.Windows.Forms.TextBox tb_CustomerPhone;
        private System.Windows.Forms.TextBox tb_CustomerAddress;
        private System.Windows.Forms.TextBox tb_CustomerName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_AddCutomer;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_showtotalProductPrice;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox tb_ProductPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox tb_ProductCount;
        private System.Windows.Forms.TextBox tb_ProductName;
        private DevExpress.XtraEditors.SimpleButton btn_AddProduct;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lbl_ShowPillNumber;
        private DevExpress.XtraEditors.SimpleButton btn_PrintPill;
        private DevExpress.XtraEditors.SimpleButton btn_SaveBill;
        private System.Windows.Forms.TextBox tb_PillDiscount;
        private System.Windows.Forms.TextBox tb_TotalPillPrice;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.TextBox tb_PillRemainingAmount;
        private System.Windows.Forms.TextBox tb_PillPaymentAmount;
        private DevExpress.XtraEditors.HyperlinkLabelControl hl_DeleteBillData;
        private DevExpress.XtraEditors.SimpleButton btn_DeletePillProduct;
        private DevExpress.XtraEditors.SimpleButton btn_EditPillProduct;
        private DevExpress.XtraEditors.HyperlinkLabelControl hl_DeleteProductData;
        private DevExpress.XtraEditors.SearchLookUpEdit sl_Customers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit sl_Products;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SimpleButton btn_showtotalPillPrice;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
