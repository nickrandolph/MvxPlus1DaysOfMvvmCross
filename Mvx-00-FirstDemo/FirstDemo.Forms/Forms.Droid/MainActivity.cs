
using Android.App;
using Android.Content.PM;
using FirstDemo.Core.ViewModels;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

namespace FirstDemo.Forms.Droid
{
    [Activity(Label = "FirstDemo.Forms", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<Core.App, App>, Core.App, App, MainViewModel>
    {
    }
}

