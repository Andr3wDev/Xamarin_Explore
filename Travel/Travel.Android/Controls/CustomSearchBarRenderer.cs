using Android.Content;
using Android.Widget;
using Travel.Controls;
using Travel.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace Travel.Droid.Controls
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(
            ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                int searchPlateId = Control.Context.Resources
                    .GetIdentifier("android:id/search_plate", null, null);
                Android.Views.View searchPlateView = Control
                    .FindViewById(searchPlateId);
                searchPlateView
                    .SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}
