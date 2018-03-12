using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WindowsFormsApp3
{
    public partial class Login : Form 
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            var wb = new WebClient();
            var data = new NameValueCollection();
            data["username"] = username;
            data["password"] = password;
            var response = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/windowsapp/login.php", "POST", data));
            char first = response[0];
            if (first == '1')
                MessageBox.Show("Невалидно потребителско име.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (first == '2')
                MessageBox.Show("Не сте потвърдили регистрацията си.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (first == '3')
                MessageBox.Show("Невалидна парола", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (first == '4')
            {
                response = response.Replace("4 ", string.Empty);
                string[] resp = response.Split('\n');
                UserData userdata = new UserData(username, password, resp[0], resp[1]);
                this.Hide();
                Main main = new Main();
                main.GetUserData(userdata);
                main.Text = "Hello, "+userdata.name;
                main.Show();
            }
            else
                MessageBox.Show(response, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            wb.Dispose();
        }
    }
}
