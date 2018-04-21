using Foundation;
using MvvmCross.Platforms.Ios.Core;
using TipCalc.Core;

namespace TipCalc.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}


