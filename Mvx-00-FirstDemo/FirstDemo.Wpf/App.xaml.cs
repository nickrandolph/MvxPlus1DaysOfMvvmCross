using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace FirstDemo.Wpf
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class ProxyMvxApplication : MvxApplication<MvxWpfSetup<Core.App>, Core.App> { }
}
