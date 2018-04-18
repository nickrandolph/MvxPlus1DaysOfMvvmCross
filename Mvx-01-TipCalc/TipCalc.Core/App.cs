using MvvmCross.IoC;
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
            RegisterAppStart<FirstViewModel>();
        }
    }
}
