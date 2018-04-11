using Android.App;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FirstDemo.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity
    {
        public SplashScreen()
             : base(Resource.Layout.SplashScreen)
        {
        }
    }
}

