using FirstDemo.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;

namespace FirstDemo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    { 
    }
}


