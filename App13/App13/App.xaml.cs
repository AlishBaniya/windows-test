using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace App13
{//new
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App13.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("uwp=c5d9ca42-0cf4-40fc-ab7a-f134900db837;" + "android={Your Android App secret here}" + "ios={Your iOS App secret here}", typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
