using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using AI.XamarinSDK.Abstractions;

namespace AppInsightsTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			SetupApplicationInsights();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

		const string InstrumentationKey = "obfuscated";

		void SetupApplicationInsights()
		{
			AI.XamarinSDK.iOS.ApplicationInsights.Init();
			ApplicationInsights.Setup(InstrumentationKey);
			ApplicationInsights.SetDebugLogEnabled(true);
			ApplicationInsights.Start();
		}
	}
}

