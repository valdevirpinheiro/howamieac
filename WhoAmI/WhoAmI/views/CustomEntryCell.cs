using System;
using Xamarin.Forms;
[assembly: ExportRenderer (typeof (CustomEntry), typeof (CustomEntryCell))]
namespace WhoAmI
{
	public class CustomEntryCell: EntryRenderer
	{


	public class MyEntryRenderer : EntryRenderer
	{
		// Override the OnElementChanged method so we can tweak this renderer post-initial setup
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				// do whatever you want to the textField here!
				Control.SetBackgroundColor(global::Android.Graphics.Color.DarkGray);
			}
		}
	}

