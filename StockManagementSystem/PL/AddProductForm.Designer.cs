namespace Stock_Management_Dev
{
    partial class AddProductForm
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
            ProductNameTxt = new System.Windows.Forms.TextBox();
            ProductDescriptionTxt = new System.Windows.Forms.TextBox();
            ProductQuantityTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ProductPriceTxt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            SupplierNumberTxt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            AddProductBtn = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductNameTxt
            // 
            ProductNameTxt.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            ProductNameTxt.Location = new System.Drawing.Point(427, 81);
            ProductNameTxt.Name = "ProductNameTxt";
            ProductNameTxt.Size = new System.Drawing.Size(205, 37);
            ProductNameTxt.TabIndex = 0;
            // 
            // ProductDescriptionTxt
            // 
            ProductDescriptionTxt.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            ProductDescriptionTxt.Location = new System.Drawing.Point(427, 142);
            ProductDescriptionTxt.Name = "ProductDescriptionTxt";
            ProductDescriptionTxt.Size = new System.Drawing.Size(205, 37);
            ProductDescriptionTxt.TabIndex = 1;
            // 
            // ProductQuantityTxt
            // 
            ProductQuantityTxt.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            ProductQuantityTxt.Location = new System.Drawing.Point(427, 208);
            ProductQuantityTxt.Name = "ProductQuantityTxt";
            ProductQuantityTxt.Size = new System.Drawing.Size(205, 37);
            ProductQuantityTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(644, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 30);
            label1.TabIndex = 3;
            label1.Text = "اسم المنتج";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(672, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 30);
            label2.TabIndex = 4;
            label2.Text = "الوصف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(672, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 30);
            label3.TabIndex = 5;
            label3.Text = "الكمية";
            // 
            // ProductPriceTxt
            // 
            ProductPriceTxt.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            ProductPriceTxt.Location = new System.Drawing.Point(54, 84);
            ProductPriceTxt.Name = "ProductPriceTxt";
            ProductPriceTxt.Size = new System.Drawing.Size(169, 37);
            ProductPriceTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(241, 84);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(129, 30);
            label4.TabIndex = 7;
            label4.Text = "سعر الوحدة";
            // 
            // SupplierNumberTxt
            // 
            SupplierNumberTxt.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            SupplierNumberTxt.Location = new System.Drawing.Point(54, 163);
            SupplierNumberTxt.Name = "SupplierNumberTxt";
            SupplierNumberTxt.Size = new System.Drawing.Size(169, 37);
            SupplierNumberTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(241, 167);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 30);
            label5.TabIndex = 9;
            label5.Text = "رقم المورد";
            // 
            // AddProductBtn
            // 
            AddProductBtn.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            AddProductBtn.Location = new System.Drawing.Point(241, 308);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new System.Drawing.Size(209, 58);
            AddProductBtn.TabIndex = 10;
            AddProductBtn.Text = "اضافة المنتج";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProduct_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddProductBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ProductPriceTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SupplierNumberTxt);
            groupBox1.Controls.Add(ProductQuantityTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ProductDescriptionTxt);
            groupBox1.Controls.Add(ProductNameTxt);
            groupBox1.Font = new System.Drawing.Font("LBC", 13.7999992F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox1.Size = new System.Drawing.Size(776, 426);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة منتج";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox ProductDescriptionTxt;
        private System.Windows.Forms.TextBox ProductQuantityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierNumberTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}