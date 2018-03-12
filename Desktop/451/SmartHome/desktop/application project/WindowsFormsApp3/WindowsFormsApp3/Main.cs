using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Collections.Specialized;

namespace WindowsFormsApp3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FillComboBox();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public UserData user_data = new UserData();
        public void GetUserData(UserData ud)
        {
            user_data = ud;
        }
        public void FillComboBox()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                serialports_combo.Items.Add(ArrayComPortsNames[index]);
            }
            while (!((ArrayComPortsNames[index] == ComPortName)
              || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            serialports_combo.Text = ArrayComPortsNames[0];
        }
        bool password_flag = true;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(password_flag == false)
            {
                password_textbox.PasswordChar = '•';
                password_flag = true;
            }
            else
            {
                password_textbox.PasswordChar = (char)0;
                password_flag = false;
            }
        }

        private void register_device_button_Click(object sender, EventArgs e)
        {
            string com = serialports_combo.SelectedItem.ToString();
            string name = device_name_textbox.Text;
            string ssid = ssid_textbox.Text;
            string password = password_textbox.Text;
            var wb = new WebClient();
            var data = new NameValueCollection();
            data["name"] = name;
            data["username"] = user_data.username;
            string response = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/windowsapp/register_device.php", "POST", data));
            if (response != "1")
                MessageBox.Show("Възникна грешка при регистрацията на устройство.\n"+response, "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string port_resp = "";
                SerialPort port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                port.ReadTimeout = 30000;
                port.WriteTimeout = 30000;
                port.Write(ssid + "*" + password + "#" + user_data.username + "@" + name + "\r\n");
                try
                {
                    port_resp = port.ReadLine();
                }
                catch(TimeoutException)
                {
                }
                if (port_resp == "")
                    MessageBox.Show("Грешни данни. Моля опитайте отново", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult dr = MessageBox.Show(port_resp, "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (dr == DialogResult.OK)
                        this.Close();
                }
            }
        }
    }
}
