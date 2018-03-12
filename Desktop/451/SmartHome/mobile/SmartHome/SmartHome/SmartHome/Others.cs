using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;

namespace SmartHome
{
    public class SensorsData
    {
        public int temp_cel;
        public int temp_far;
        public int heat_index_cel;
        public int heat_index_far;
        public int hum;
        public int lux;
        public int gas_ppm;
        public SensorsData()
        {
            temp_cel = 0;
            temp_far = 0;
            heat_index_cel = 0;
            heat_index_far = 0;
            hum = 0;
            lux = 0;
            gas_ppm = 0;
        }
    }
    public class Device
    {
        public string name;
        public List<HomeDevice> homeDevice;
        public SensorsData sensorsData;
        public Device()
        {
            name = "";
            homeDevice = new List<HomeDevice>();
            sensorsData = new SensorsData();
        }
    }
    public class HomeDevice
    {
        public string name;
        public List<string> button;
        public HomeDevice()
        {
            name = "";
            button = new List<string>();
        }
    }
    public static class Get
    {
        public static List<Device> getData()
        {
            WebClient wb = new WebClient();
            var data = new NameValueCollection
            {
                ["username"] = Login.Username,
                ["password"] = Login.Password
            };
            Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/login.php", "POST", data));
            List<Device> device = new List<Device>();
            string[] result = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_devices.php", "POST", data)).Split(',');
            foreach (var item in result)
            {
                Device dev = new Device
                {
                    name = item
                };
                var data1 = new NameValueCollection
                {
                    ["username"] = Login.Username,
                    ["password"] = Login.Password,
                    ["device_name"] = dev.name
                };
                string[] result1 = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_home_devices.php", "POST", data1)).Split(',');
                foreach (var item1 in result)
                {
                    HomeDevice hd = new HomeDevice
                    {
                        name = item1
                    };
                    var data2 = new NameValueCollection
                    {
                        ["username"] = Login.Username,
                        ["password"] = Login.Password,
                        ["device_name"] = dev.name,
                        ["home_device_name"] = hd.name
                    };
                    string[] result2 = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_buttons.php", "POST", data2)).Split(',');
                    foreach (var item2 in result2)
                        hd.button.Add(item2);
                    dev.homeDevice.Add(hd);
                    string[] res3 = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_sensors.php", "POST", data1)).Split('#');
                    SensorsData sensors = new SensorsData();
                    int.TryParse(res3[0], out sensors.temp_cel);
                    int.TryParse(res3[1], out sensors.temp_far);
                    int.TryParse(res3[2], out sensors.heat_index_cel);
                    int.TryParse(res3[3], out sensors.heat_index_far);
                    int.TryParse(res3[4], out sensors.hum);
                    int.TryParse(res3[5], out sensors.lux);
                    int.TryParse(res3[6], out sensors.gas_ppm);
                    dev.sensorsData = sensors;
                    device.Add(dev);
                }
            }
            return device;
        }
        public static Device getData(string device_name)
        {
            Device device = new Device
            {
                name = device_name
            };
            WebClient wb = new WebClient();
            var data1 = new NameValueCollection
            {
                ["username"] = Login.Username,
                ["password"] = Login.Password,
                ["device_name"] = device.name
            };
            string[] result = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_home_devices.php", "POST", data1)).Split(',');
            foreach (var item in result)
            {
                HomeDevice hd = new HomeDevice
                {
                    name = item
                };
                var data2 = new NameValueCollection
                {
                    ["username"] = Login.Username,
                    ["password"] = Login.Password,
                    ["device_name"] = device.name,
                    ["home_device_name"] = hd.name
                };
                string[] result2 = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_buttons.php", "POST", data2)).Split(',');
                foreach (var item2 in result2)
                    hd.button.Add(item2);
                device.homeDevice.Add(hd);
                string[] res3 = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/get_sensors.php", "POST", data1)).Split('#');
                SensorsData sensors = new SensorsData();
                sensors.temp_cel = int.Parse(res3[0]);
                sensors.temp_far = int.Parse(res3[1]);
                sensors.heat_index_cel = int.Parse(res3[2]);
                sensors.heat_index_far = int.Parse(res3[3]);
                sensors.hum = int.Parse(res3[4]);
                sensors.lux = int.Parse(res3[5]);
                sensors.gas_ppm = int.Parse(res3[6]);
                device.sensorsData = sensors;
            }
            return device;
        }
    }
}
