using FirstDemo.Core.ViewModels;
using MvvmCross.ViewModels;

namespace FirstDemo.Wpf.Views
{
    [MvxViewFor(typeof(FirstViewModel))]
    public partial class FirstView 
    {
        public FirstView()
        {
            InitializeComponent();
        }
    }
}
