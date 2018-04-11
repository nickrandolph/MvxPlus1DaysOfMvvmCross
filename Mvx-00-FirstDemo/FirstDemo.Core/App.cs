using FirstDemo.Core.ViewModels;
using MvvmCross.ViewModels;

namespace FirstDemo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();
        }
    }
}
