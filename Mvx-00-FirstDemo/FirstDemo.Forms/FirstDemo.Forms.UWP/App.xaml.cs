using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using Windows.UI.Xaml;

namespace FirstDemo.Forms.UWP
{
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }

    }
    public abstract class ProxyMvxApplication : MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, FirstDemo.Forms.App>, Core.App, FirstDemo.Forms.App, MainPage>
    {
    }
}
