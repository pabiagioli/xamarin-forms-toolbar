using System;

using Xamarin.Forms;

namespace ToolbarSample
{
	public class App : Application
	{
		public App ()
		{
			Button page2Btn = new Button () {
				Text = "Page 2",
				Command = new Command (() => {
					((MasterDetailPage)MainPage).Detail.Navigation.PushAsync (
						new ContentPage () {
							Content = new Label () {
								Text = "This is Page 2"
							}
						});
					((MasterDetailPage)MainPage).IsPresented = false;
				})
			};
			// The root page of your application
			MainPage = new MasterDetailPage () {
				Master = new ContentPage () {
					Title = "Title Menu",
					Content = page2Btn
				},
				Detail = new NavigationPage (new ContentPage {
					Title = "Content Title",
					Content = new StackLayout {
						VerticalOptions = LayoutOptions.Center,
						Children = {
							new Label {
								HorizontalTextAlignment = TextAlignment.Center,
								Text = "Welcome to Xamarin Forms!"
							}
						}
					}
				})
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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

