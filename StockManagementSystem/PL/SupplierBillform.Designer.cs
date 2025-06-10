namespace Stock_Management_Dev
{
	partial class SupplierBillform
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
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            addnewbill = new DevExpress.XtraEditors.SimpleButton();
            unit = new DevExpress.XtraEditors.TextEdit();
            Total = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            totalprice = new DevExpress.XtraEditors.LabelControl();
            billID = new DevExpress.XtraEditors.SearchLookUpEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            txtaddress = new System.Windows.Forms.TextBox();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            searchId = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtphone = new DevExpress.XtraEditors.TextEdit();
            txtcompany = new DevExpress.XtraEditors.TextEdit();
            txtname = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridControlProducts = new DevExpress.XtraGrid.GridControl();
            gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Total.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtphone.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtcompany.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("LBC", 11.999999F);
            dateTimePicker1.Location = new System.Drawing.Point(29, 165);
            dateTimePicker1.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(237, 33);
            dateTimePicker1.TabIndex = 1;
            // 
            // groupControl1
            // 
            groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupControl1.Controls.Add(addnewbill);
            groupControl1.Controls.Add(unit);
            groupControl1.Controls.Add(Total);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(totalprice);
            groupControl1.Controls.Add(billID);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label1);
            groupControl1.Controls.Add(dateTimePicker1);
            groupControl1.Location = new System.Drawing.Point(523, 13);
            groupControl1.Name = "groupControl1";
            groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupControl1.Size = new System.Drawing.Size(443, 395);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "بيانات الفاتورة";
            // 
            // addnewbill
            // 
            addnewbill.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            addnewbill.Appearance.Options.UseFont = true;
            addnewbill.Location = new System.Drawing.Point(5, 36);
            addnewbill.Name = "addnewbill";
            addnewbill.Size = new System.Drawing.Size(166, 40);
            addnewbill.TabIndex = 4;
            addnewbill.Text = "اضافة فاتورة جديدة";
            addnewbill.Click += addnewbill_Click;
            // 
            // unit
            // 
            unit.Location = new System.Drawing.Point(29, 290);
            unit.Name = "unit";
            unit.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            unit.Properties.Appearance.Options.UseFont = true;
            unit.Size = new System.Drawing.Size(236, 32);
            unit.TabIndex = 9;
            // 
            // Total
            // 
            Total.Location = new System.Drawing.Point(29, 226);
            Total.Name = "Total";
            Total.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            Total.Properties.Appearance.Options.UseFont = true;
            Total.Size = new System.Drawing.Size(236, 32);
            Total.TabIndex = 8;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(299, 287);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(139, 30);
            labelControl8.TabIndex = 7;
            labelControl8.Text = "المبلغ المدفوع";
            // 
            // totalprice
            // 
            totalprice.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            totalprice.Appearance.Options.UseFont = true;
            totalprice.Location = new System.Drawing.Point(291, 229);
            totalprice.Name = "totalprice";
            totalprice.Size = new System.Drawing.Size(144, 30);
            totalprice.TabIndex = 6;
            totalprice.Text = "المبلغ المطلوب";
            // 
            // billID
            // 
            billID.Location = new System.Drawing.Point(29, 105);
            billID.Name = "billID";
            billID.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            billID.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            billID.Properties.Appearance.Options.UseFont = true;
            billID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            billID.Properties.PopupView = gridView1;
            billID.Properties.UseReadOnlyAppearance = false;
            billID.Size = new System.Drawing.Size(236, 32);
            billID.TabIndex = 4;
            billID.EditValueChanged += billID_EditValueChanged;
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 368;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 711;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("LBC", 13.7999992F);
            label3.Location = new System.Drawing.Point(326, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 30);
            label3.TabIndex = 4;
            label3.Text = "تاريخ الشراء";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("LBC", 13.7999992F);
            label1.Location = new System.Drawing.Point(315, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 30);
            label1.TabIndex = 2;
            label1.Text = "رقم الفاتورة";
            // 
            // groupControl2
            // 
            groupControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupControl2.Controls.Add(simpleButton1);
            groupControl2.Controls.Add(txtaddress);
            groupControl2.Controls.Add(labelControl6);
            groupControl2.Controls.Add(searchId);
            groupControl2.Controls.Add(labelControl3);
            groupControl2.Controls.Add(txtEmail);
            groupControl2.Controls.Add(txtphone);
            groupControl2.Controls.Add(txtcompany);
            groupControl2.Controls.Add(txtname);
            groupControl2.Controls.Add(labelControl5);
            groupControl2.Controls.Add(labelControl4);
            groupControl2.Controls.Add(labelControl2);
            groupControl2.Controls.Add(labelControl1);
            groupControl2.Location = new System.Drawing.Point(11, 13);
            groupControl2.Name = "groupControl2";
            groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupControl2.Size = new System.Drawing.Size(466, 395);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "بيانات المورد";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new System.Drawing.Point(5, 31);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(153, 41);
            simpleButton1.TabIndex = 14;
            simpleButton1.Text = "اضافة مورد جديد";
            // 
            // txtaddress
            // 
            txtaddress.Font = new System.Drawing.Font("LBC", 11.999999F);
            txtaddress.Location = new System.Drawing.Point(141, 353);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new System.Drawing.Size(167, 28);
            txtaddress.TabIndex = 13;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(337, 351);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(121, 30);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "عنوان الشركة";
            // 
            // searchId
            // 
            searchId.Location = new System.Drawing.Point(141, 78);
            searchId.Name = "searchId";
            searchId.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            searchId.Properties.Appearance.Options.UseFont = true;
            searchId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            searchId.Properties.PopupView = searchLookUpEdit1View;
            searchId.Size = new System.Drawing.Size(166, 32);
            searchId.TabIndex = 11;
            searchId.EditValueChanged += searchId_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.DetailHeight = 368;
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 711;
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(315, 293);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(143, 30);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "البريد الالكتروني";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(141, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Size = new System.Drawing.Size(166, 32);
            txtEmail.TabIndex = 9;
            // 
            // txtphone
            // 
            txtphone.Location = new System.Drawing.Point(141, 241);
            txtphone.Name = "txtphone";
            txtphone.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            txtphone.Properties.Appearance.Options.UseFont = true;
            txtphone.Size = new System.Drawing.Size(166, 32);
            txtphone.TabIndex = 8;
            // 
            // txtcompany
            // 
            txtcompany.Location = new System.Drawing.Point(141, 186);
            txtcompany.Name = "txtcompany";
            txtcompany.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            txtcompany.Properties.Appearance.Options.UseFont = true;
            txtcompany.Size = new System.Drawing.Size(166, 32);
            txtcompany.TabIndex = 7;
            // 
            // txtname
            // 
            txtname.Location = new System.Drawing.Point(142, 133);
            txtname.Name = "txtname";
            txtname.Properties.Appearance.Font = new System.Drawing.Font("LBC", 11.999999F);
            txtname.Properties.Appearance.Options.UseFont = true;
            txtname.Size = new System.Drawing.Size(166, 32);
            txtname.TabIndex = 6;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(350, 184);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(108, 30);
            labelControl5.TabIndex = 4;
            labelControl5.Text = "اسم الشركة";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(362, 239);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(96, 30);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "رقم الهاتف";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(318, 131);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(140, 30);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "الاسم الشخصي";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("LBC", 13.7999992F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(347, 76);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(114, 30);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "معرف المورد";
            // 
            // gridControlProducts
            // 
            gridControlProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            gridControlProducts.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridControlProducts.Location = new System.Drawing.Point(15, 414);
            gridControlProducts.MainView = gridViewProducts;
            gridControlProducts.Name = "gridControlProducts";
            gridControlProducts.Size = new System.Drawing.Size(943, 219);
            gridControlProducts.TabIndex = 4;
            gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewProducts });
            // 
            // gridViewProducts
            // 
            gridViewProducts.DetailHeight = 368;
            gridViewProducts.GridControl = gridControlProducts;
            gridViewProducts.Name = "gridViewProducts";
            gridViewProducts.OptionsEditForm.PopupEditFormWidth = 711;
            // 
            // SupplierBillform
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlProducts);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "SupplierBillform";
            Size = new System.Drawing.Size(988, 636);
            Load += SupplierBillform_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)unit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Total.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)billID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtphone.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtcompany.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtphone;
        private DevExpress.XtraEditors.TextEdit txtcompany;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchId;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtaddress;
        private DevExpress.XtraEditors.SearchLookUpEdit billID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit unit;
        private DevExpress.XtraEditors.TextEdit Total;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl totalprice;
        private DevExpress.XtraEditors.SimpleButton addnewbill;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
    }
}