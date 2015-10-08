using System;

using Xamarin.Forms;

namespace AppInsightsTest
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var button = new Button {
				Text = "Generate NRE crash"
			};
			button.Clicked += (object sender, EventArgs e) => {
				string s = null;
				int length = s.Length;
			};
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						button
					}
				}
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

