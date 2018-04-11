using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace FirstDemo.Uwp
{
    sealed partial class App : ProxyMvxApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

    }

    public abstract class ProxyMvxApplication : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}
