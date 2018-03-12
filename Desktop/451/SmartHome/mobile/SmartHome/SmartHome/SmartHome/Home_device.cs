using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartHome
{
    public class Home_device
    {
        public Label HomeDevice;
        public List<Label> Device_buttons;
        public Home_device()
        {
            HomeDevice = new Label();
            Device_buttons = new List<Label>();
        }
    }
}
