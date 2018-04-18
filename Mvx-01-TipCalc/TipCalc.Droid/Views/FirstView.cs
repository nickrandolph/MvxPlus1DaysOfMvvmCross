
using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using TipCalc.Core.ViewModels;

namespace TipCalc.Droid.Views
{
    [Activity(Label = "FirstView")]
    public class FirstView : MvxAppCompatActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FirstView);
        }
    }
}