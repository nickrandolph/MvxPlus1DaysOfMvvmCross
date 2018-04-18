using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace TipCalc.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen) { }
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Set our view from the "main" layout resource
        //    SetContentView(Resource.Layout.SplashScreen);
        //}
    }
}

