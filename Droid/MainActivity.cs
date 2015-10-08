using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AI.XamarinSDK.Abstractions;

namespace AppInsightsTest.Droid
{
	[Activity(Label = "AppInsightsTest.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}

		protected override void OnStart()
		{
			base.OnStart();

			SetupApplicationInsights();
		}

		const string InstrumentationKey = "obfuscated";

		void SetupApplicationInsights()
		{
			ApplicationInsights.Setup(InstrumentationKey);
			ApplicationInsights.SetDebugLogEnabled(true);
			ApplicationInsights.Start();
		}
	}
}

