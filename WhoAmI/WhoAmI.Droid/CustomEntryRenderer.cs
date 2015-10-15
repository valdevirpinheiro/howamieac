using System;
using Xamarin.Forms;

[assembly: ExportRenderer (typeof (CustomEntry), typeof (CustomEntryRenderer))]
namespace WhoAmI
{
	public class CustomEntryRenderer : EntryRenderer
	{
		
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				// do whatever you want to the textField here!
				Control.SetBackgroundColor(global::Android.Graphics.Color.DarkGray);
			}
		}
	}
}

