using Android.App;
using Android.Widget;
using Android.OS;

namespace letsGO
{
	[Activity (Label = "Lets GO", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Android.Support.V4.App.FragmentActivity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate { button.Text = string.Format ("{0} clicks!", count++); };
		}
	}
}


