using Android.App;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;
using TipCalc.Core;

namespace TipCalc.Droid
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<MvxAppCompatSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}

