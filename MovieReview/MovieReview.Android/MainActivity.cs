
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MovieReview.Droid
{
    [Activity(Label = "MovieReview", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());

            global::Xamarin.Forms.Forms.Init(this, bundle);

            FormsPlugin.Iconize.Droid.IconControls.Init(Resource.Id.toolbar);
            
            LoadApplication(new App());
		}
	}
}

