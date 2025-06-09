namespace Stock_Management_Dev
{
	partial class Addsupbill
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
            txtNewSupplierName = new DevExpress.XtraEditors.TextEdit();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            btnAddSupplierBillItem = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtProductName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dgvProducts = new System.Windows.Forms.DataGridView();
            btnUpdateQuantities = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnAddProductt = new System.Windows.Forms.Button();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtNewSupplierName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewSupplierName
            // 
            txtNewSupplierName.Location = new System.Drawing.Point(461, 74);
            txtNewSupplierName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNewSupplierName.Name = "txtNewSupplierName";
            txtNewSupplierName.Size = new System.Drawing.Size(407, 26);
            txtNewSupplierName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(461, 151);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(406, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(766, -1);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(181, 24);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "اضافة فاتورة جديدة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(901, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 24);
            label1.TabIndex = 3;
            label1.Text = "اسم المورد";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(901, 154);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(113, 24);
            label7.TabIndex = 9;
            label7.Text = "تاريخ الفاتورة";
            // 
            // btnAddSupplierBillItem
            // 
            btnAddSupplierBillItem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddSupplierBillItem.Appearance.Options.UseFont = true;
            btnAddSupplierBillItem.Location = new System.Drawing.Point(12, 767);
            btnAddSupplierBillItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddSupplierBillItem.Name = "btnAddSupplierBillItem";
            btnAddSupplierBillItem.Size = new System.Drawing.Size(294, 67);
            btnAddSupplierBillItem.TabIndex = 10;
            btnAddSupplierBillItem.Text = "اضافة الفاتورة";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(308, 97);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(52, 24);
            labelControl2.TabIndex = 15;
            labelControl2.Text = "الكمية";
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(81, 34);
            txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(166, 34);
            txtProductName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(282, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 24);
            label2.TabIndex = 19;
            label2.Text = "منتج جديد";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new System.Drawing.Point(433, 271);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new System.Drawing.Size(768, 390);
            dgvProducts.TabIndex = 22;
            // 
            // btnUpdateQuantities
            // 
            btnUpdateQuantities.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdateQuantities.Location = new System.Drawing.Point(433, 627);
            btnUpdateQuantities.Name = "btnUpdateQuantities";
            btnUpdateQuantities.Size = new System.Drawing.Size(239, 34);
            btnUpdateQuantities.TabIndex = 23;
            btnUpdateQuantities.Text = "تعديل الكمية ";
            btnUpdateQuantities.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddProductt);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(29, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(398, 412);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة منتج جديد";
            // 
            // btnAddProductt
            // 
            btnAddProductt.Location = new System.Drawing.Point(21, 365);
            btnAddProductt.Name = "btnAddProductt";
            btnAddProductt.Size = new System.Drawing.Size(180, 47);
            btnAddProductt.TabIndex = 24;
            btnAddProductt.Text = "اضافة المنتج";
            btnAddProductt.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(66, 106);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(199, 34);
            txtQuantity.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(116, 148);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(163, 34);
            txtUnitPrice.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(318, 150);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 28);
            label4.TabIndex = 21;
            label4.Text = "السعر";
            // 
            // Addsupbill
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1181, 677);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdateQuantities);
            Controls.Add(dgvProducts);
            Controls.Add(btnAddSupplierBillItem);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(labelControl1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNewSupplierName);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Addsupbill";
            Text = "Addsupbill";
            ((System.ComponentModel.ISupportInitialize)txtNewSupplierName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNewSupplierName;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnAddSupplierBillItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnUpdateQuantities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddProductt;
    }
}