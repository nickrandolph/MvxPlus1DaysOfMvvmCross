
using Android.App;
using Android.OS;
using FirstDemo.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FirstDemo.Droid.Views
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