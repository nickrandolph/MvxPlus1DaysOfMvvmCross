using MvvmCross;
using MvvmCross.Exceptions;
using MvvmCross.IoC;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                    .EndingWith("Service")
                    .AsInterfaces()
                    .RegisterAsLazySingleton();
            RegisterCustomAppStart<CustomMvxAppStart<FirstViewModel>>();
        }
    }

    public class CustomMvxAppStart<TViewModel> : MvxAppStart<TViewModel>
        where TViewModel : IMvxViewModel
    {
        public CustomMvxAppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override void NavigateToFirstViewModel(object hint)
        {
            try
            {
                NavigationService.Navigate<TViewModel>();
            }
            catch (System.Exception exception)
            {
                throw exception.MvxWrap("Problem navigating to ViewModel {0}", typeof(TViewModel).Name);
            }
        }
    }
}
