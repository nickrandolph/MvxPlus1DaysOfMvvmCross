using AppKit;
using FirstDemo.Core;
using Foundation;
using MvvmCross.Platforms.Mac.Core;

namespace FirstDemo.Mac
{
    [Register("AppDelegate")]
	public class AppDelegate: MvxApplicationDelegate<MvxMacSetup<App>, App>
    {
		public override void DidFinishLaunching(NSNotification notification)
		{
			MvxMacSetupSingleton.EnsureSingletonAvailable(this, MainWindow).EnsureInitialized();
			RunAppStart();
			//base.DidFinishLaunching(notification);
		}
	}
}
