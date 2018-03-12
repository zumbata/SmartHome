using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Register()).Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
