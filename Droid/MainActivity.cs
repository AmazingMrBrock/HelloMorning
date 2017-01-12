using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloMorning.Droid
{
	[Activity(Label = "HelloMorning", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		public MyClass myClass = new MyClass();

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate { button.Text = $"{myClass.newClick()} clicks!"; };
		}
	}
}

