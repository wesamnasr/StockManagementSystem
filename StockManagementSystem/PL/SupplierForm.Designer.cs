namespace StockManagementSystem
{
    partial class SupplierForm
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
            components = new System.ComponentModel.Container();
            txtSearch = new System.Windows.Forms.TextBox();
            btnAddSupplier = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            duesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierBindingSource = new System.Windows.Forms.BindingSource(components);
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            txtSearch.Location = new System.Drawing.Point(669, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(126, 26);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(56, 184, 151);
            btnAddSupplier.Location = new System.Drawing.Point(801, 3);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new System.Drawing.Size(98, 35);
            btnAddSupplier.TabIndex = 1;
            btnAddSupplier.Text = "اضافه مورد";
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colEdit, colDelete, duesDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, companyNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, supplierIDDataGridViewTextBoxColumn });
            dataGridView1.DataSource = supplierBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            dataGridView1.Location = new System.Drawing.Point(0, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(902, 407);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "تعديل";
            colEdit.Name = "colEdit";
            colEdit.Text = "تعديل";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "حذف";
            colDelete.Name = "colDelete";
            colDelete.Text = "حذف";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // duesDataGridViewTextBoxColumn
            // 
            duesDataGridViewTextBoxColumn.DataPropertyName = "Dues";
            duesDataGridViewTextBoxColumn.HeaderText = "المستحقات";
            duesDataGridViewTextBoxColumn.Name = "duesDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "الايميل";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            companyNameDataGridViewTextBoxColumn.HeaderText = "اسم الشركة";
            companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "رقم الهاتف";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.HeaderText = "رقم المورد";
            supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Models.Supplier);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddSupplier);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(902, 43);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(902, 450);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn duesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}