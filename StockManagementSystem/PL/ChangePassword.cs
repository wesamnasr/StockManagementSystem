using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem;
using StockManagementSystem.Models;

namespace StockManagementSystem
{

    public partial class ChangePassword : UserControl
    {
        Toast toast = new Toast();

        AppDBContext context = new AppDBContext();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            var Pass = context.Passwords.OrderByDescending(p => p.PasswordID).FirstOrDefault();
            var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$";
            if (password_txt.Text !="" && newpass_txt.Text != "" && confirmpass_txt.Text != "")
            {
                if (password_txt.Text != Pass.NewPassword)
                {
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "كلمة السر القديمة غير صحيحة";
                    toast.alert_color.BackColor = Color.Red;
                    toast.Show();
                    password_txt.Focus();
                    return;
                }
                if (!Regex.IsMatch(newpass_txt.Text,pattern))
                {
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "يجب أن تحتوي كلمة المرور على 6 أحرف على الأقل وتتضمن حرفًا كبيرًا، حرفًا صغيرًا، ورقمًا واحدًا على الأقل";
                    toast.txt_caption.Font = new Font(toast.txt_caption.Font.FontFamily, 16); 
                    toast.alert_color.BackColor = Color.Red;
                    toast.Show();
                    newpass_txt.Focus();
                    return;
                }
                if (confirmpass_txt.Text != newpass_txt.Text)
                {
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "خطأ في تأكيد كلمة السر";
                    toast.alert_color.BackColor = Color.Red;
                    toast.Show();
                    confirmpass_txt.Focus();
                    return;
                }
                Toast toast2 = new Toast();
                toast2.txt_caption.Text = "تم تغيير كلمة السر بنجاح";
                toast2.alert_color.BackColor = Color.Green;
                toast2.Show();
                context.Passwords.Add(new Password
                {
                    OldPassword = Pass.NewPassword,
                    NewPassword = newpass_txt.Text,
                    CreatedAt = DateTime.Now
                });
                context.SaveChanges();
            }
            else
            {
                Toast toast = new Toast();
                toast.txt_caption.Text = "يجب ملئ جميع العناصر";
                toast.alert_color.BackColor = Color.Red;
                toast.Show();
                return;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
