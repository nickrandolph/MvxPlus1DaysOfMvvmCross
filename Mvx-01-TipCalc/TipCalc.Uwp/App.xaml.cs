using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace TipCalc.Uwp
{
    sealed partial class App 
    {
        public App()
        {
            this.InitializeComponent();
        }
    }
    public abstract class ProxyMvxApplication : MvxApplication<MvxWindowsSetup<Core.App>, Core.App> { }
}
