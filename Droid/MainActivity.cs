using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

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
			//Button button = FindViewById<Button>(Resource.Id.myButton);

			//button.Click += delegate { myClass.newClick(); };

			WebView localWebView = FindViewById<WebView>(Resource.Id.LocalWebView);

			localWebView.SetWebViewClient(new WebViewClient());
			localWebView.Settings.JavaScriptEnabled = true;

			//localWebView.LoadUrl("http://developer.xamarin.com");
			//localWebView.SetWebChromeClient(new WebChromeClient());

			//localWebView.LoadUrl("file:///android_asset/GameTest/2048-master/index.html");
			localWebView.LoadUrl("file:///android_asset/GameTest/examples/index.html");
			//localWebView.LoadUrl("file:///android_asset/GameTest/tetris/web/index.html");

		}
	}
}

 