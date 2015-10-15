using System;
using Xamarin.Forms;
using WhoAmI;
using WhoAmI.Droid;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;


[assembly: ExportRenderer (typeof (CustomEntry), typeof (MyEntryRenderer))]
namespace WhoAmI.Droid
{
	public class MyEntryRenderer : EntryRenderer
	{
		// Override the OnElementChanged method so we can tweak this renderer post-initial setup
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				// do whatever you want to the textField here!
				Control.SetTextColor(global::Android.Graphics.Color.White);
			}
		}
	}
}

