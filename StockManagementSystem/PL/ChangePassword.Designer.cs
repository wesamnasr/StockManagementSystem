namespace StockManagementSystem
{
    partial class ChangePassword
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
            pn_cont = new System.Windows.Forms.Panel();
            confirm_btn = new DevExpress.XtraEditors.SimpleButton();
            confirmpass_txt = new System.Windows.Forms.TextBox();
            newpass_txt = new System.Windows.Forms.TextBox();
            password_txt = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pn_cont.SuspendLayout();
            SuspendLayout();
            // 
            // pn_cont
            // 
            pn_cont.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pn_cont.Controls.Add(confirm_btn);
            pn_cont.Controls.Add(confirmpass_txt);
            pn_cont.Controls.Add(newpass_txt);
            pn_cont.Controls.Add(password_txt);
            pn_cont.Controls.Add(label3);
            pn_cont.Controls.Add(label2);
            pn_cont.Controls.Add(label1);
            pn_cont.Location = new System.Drawing.Point(0, 0);
            pn_cont.Name = "pn_cont";
            pn_cont.Size = new System.Drawing.Size(988, 636);
            pn_cont.TabIndex = 0;
            // 
            // confirm_btn
            // 
            confirm_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            confirm_btn.Appearance.Font = new System.Drawing.Font("LBC", 23.9999981F);
            confirm_btn.Appearance.Options.UseFont = true;
            confirm_btn.Location = new System.Drawing.Point(424, 521);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new System.Drawing.Size(121, 57);
            confirm_btn.TabIndex = 13;
            confirm_btn.Text = "تأكيد";
            confirm_btn.Click += confirm_btn_Click;
            // 
            // confirmpass_txt
            // 
            confirmpass_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            confirmpass_txt.Font = new System.Drawing.Font("LBC", 23.9999981F);
            confirmpass_txt.Location = new System.Drawing.Point(61, 378);
            confirmpass_txt.Name = "confirmpass_txt";
            confirmpass_txt.Size = new System.Drawing.Size(427, 59);
            confirmpass_txt.TabIndex = 12;
            // 
            // newpass_txt
            // 
            newpass_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            newpass_txt.Font = new System.Drawing.Font("LBC", 23.9999981F);
            newpass_txt.Location = new System.Drawing.Point(62, 233);
            newpass_txt.Name = "newpass_txt";
            newpass_txt.Size = new System.Drawing.Size(427, 59);
            newpass_txt.TabIndex = 11;
            // 
            // password_txt
            // 
            password_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            password_txt.Font = new System.Drawing.Font("LBC", 23.9999981F);
            password_txt.Location = new System.Drawing.Point(61, 85);
            password_txt.Name = "password_txt";
            password_txt.Size = new System.Drawing.Size(427, 59);
            password_txt.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("LBC", 23.9999981F);
            label3.Location = new System.Drawing.Point(613, 386);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(265, 51);
            label3.TabIndex = 9;
            label3.Text = "تأكيد كلمة السر";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("LBC", 23.9999981F);
            label2.Location = new System.Drawing.Point(572, 236);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(306, 51);
            label2.TabIndex = 8;
            label2.Text = "كلمة السر الجديدة";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("LBC", 23.9999981F);
            label1.Location = new System.Drawing.Point(569, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(309, 51);
            label1.TabIndex = 7;
            label1.Text = "كلمة السر القديمة";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(988, 636);
            Controls.Add(pn_cont);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ChangePassword";
            Text = "ChangePassword";
            pn_cont.ResumeLayout(false);
            pn_cont.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton confirm_btn;
        private System.Windows.Forms.TextBox confirmpass_txt;
        private System.Windows.Forms.TextBox newpass_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pn_cont;
    }
}