using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Reflection;
using Microsoft.CSharp;

namespace SmartHome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main_Page : ContentPage
    {
        public Main_Page()
        {
            InitializeComponent();
            ScrollView scroll = new ScrollView();
            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            var Main_Label = new Label
            {
                Text = "Устройства",
                FontAttributes = FontAttributes.Bold,
                FontSize = 45,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 100,
                TextColor = Color.Black
            };
            grid.Children.Add(Main_Label, 0, 2);
            Grid.SetColumnSpan(Main_Label, 2);
            Button b = new Button
            {
                Text = "Обнови",
                VerticalOptions = LayoutOptions.Center
            };
            b.Clicked += B_Clicked;
            grid.Children.Add(b, 1, 0);
            List<Device> device1 = new List<Device>(Get.getData());
            List<Label> list = new List<Label>();
            foreach (var item in device1)
            {
                Label label = new Label()
                {
                    Text = item.name,
                    TextColor = Color.Black,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    HeightRequest = 180,
                    FontSize = 24
                };
                list.Add(label);
            }
            List<Label> list2 = new List<Label>();
            foreach (var item in device1)
            {
                Label temp = new Label()
                {
                    Text = "\r\n" + "\r\n" + "  Температура: " + item.sensorsData.temp_cel + "°C" + "\r\n" + "  Усеща се: " + item.sensorsData.heat_index_cel + "°C" + "\r\n" + "  Температура: " + item.sensorsData.temp_far + "°F" + "\r\n" + "  Усеща се: " + item.sensorsData.heat_index_far + "°F" + "\r\n" + "  Влажност: " + item.sensorsData.hum + "%" + "\r\n" + "  Количество вредни\r\n  газове: " + item.sensorsData.gas_ppm + " PPM",
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalTextAlignment = TextAlignment.Start,
                    FontSize = 15,

                };
                list2.Add(temp);
            }
            int k = 3;
            int p = 0;


            foreach (Label item in list2)
            {
                grid.Children.Add(item, p, k);
                if (p == 1)
                {
                    p = 0;
                    k++;
                }
                else
                {
                    p++;
                }
            }
            k = 3;
            p = 0;
            foreach (Label item in list)
            {
                grid.Children.Add(item, p, k);
                if (p == 1)
                {
                    p = 0;
                    k++;
                }
                else
                {
                    p++;
                }

            }


            foreach (Label item in list)
                item.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(() => OnLabelClicked(item.Text, device1)),
                });
            scroll.Content = grid;
            Content = scroll;
        }
        void B_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new Main_Page());
        }
        public void OnLabelClicked(string device_name, List<Device> device1)
        {
            foreach (var item in device1)
                if (item.name == device_name)
                {
                    Information.device = item;
                    break;
                }
            Navigation.PushModalAsync(new Information());
        }
    }
}