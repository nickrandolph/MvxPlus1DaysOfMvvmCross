using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Core;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Core;
using FirstDemo.Core.ViewModels;

namespace FirstDemo.Forms.Droid
{
    [Activity(Label = "FirstDemo.Forms", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {
        public MainActivity() : base()
        {
            this.RegisterSetupType<CustomSetup>();
        }
    }

    public class CustomSetup : MvxFormsAndroidSetup<Core.App, FirstDemo.Forms.App>
    {
    }

    //public class Monitor : IMvxSetupMonitor
    //{
    //    public void InitializationComplete()
    //    {
    //    }
    //}
}

