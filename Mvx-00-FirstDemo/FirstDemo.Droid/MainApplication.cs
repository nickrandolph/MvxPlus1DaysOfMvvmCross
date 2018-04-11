using Android.App;
using Android.Runtime;
using FirstDemo.Core;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;

namespace FirstDemo.Droid
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<MvxAppCompatSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}

