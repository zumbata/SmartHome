using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SmartHome
{

	public partial class App : Application
    {
        public App ()
		{
			InitializeComponent();
			MainPage = new Login();
		}

        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }

        protected override void OnStart ()
		{

		}

		protected override void OnSleep ()
		{

		}

		protected override void OnResume ()
		{

        }
	}
}
