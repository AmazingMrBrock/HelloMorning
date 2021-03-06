﻿using System;

using UIKit;

namespace HelloMorning.iOS
{
	public partial class ViewController : UIViewController
	{
		public MyClass myClass = new MyClass();

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				//var title = string.Format("{0} clicks!", myClass.newClick());
				myClass.newClick();
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
