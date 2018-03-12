using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;

namespace WindowsFormsApp3
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void register_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            string email = email_textbox.Text;
            string name = name_textbox.Text;
            var wb = new WebClient();
            var data = new NameValueCollection();
            data["username"] = username;
            data["password"] = password;
            data["password"] = data["password"].Replace("'", "\'");
            data["email"] = email;
            data["name"] = name;
            var response = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/windowsapp/register.php", "POST", data));
            if (response == "1")
                MessageBox.Show("Заето потребителско име.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (response == "2")
                MessageBox.Show("Съществува регистрация с този e-mail.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (response == "3")
            {
                DialogResult result;
                result = MessageBox.Show("Регистрацията успешна! На e-mailът Ви е изпратен линк за потвърждаване на регистрацията.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK||result == DialogResult.Cancel)
                {
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
            else
                MessageBox.Show(response, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            wb.Dispose();
        }
        
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

    }
}
