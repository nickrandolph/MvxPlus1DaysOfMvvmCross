using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using Windows.UI.Xaml;

namespace TipCalc.Forms.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : ProxyMvxApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }
    }

    public abstract class ProxyMvxApplication : MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, TipCalc.Forms.App>, Core.App, TipCalc.Forms.App, MainPage>
    {

    }
}
