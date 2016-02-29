
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace ToolbarSample.Droid
{
	[Activity (Label = "ToolbarSample.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			var toolbar = this.SupportActionBar;
			toolbar.Show ();
			//var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar> (Resource.Id.my_awesome_toolbar);
			//toolbar.Title = "Title";
			System.Diagnostics.Debug.WriteLine (toolbar.Title);
		}
	}
}

