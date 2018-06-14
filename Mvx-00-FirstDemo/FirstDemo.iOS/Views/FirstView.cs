using FirstDemo.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using System;
using UIKit;

namespace FirstDemo.iOS.Views
{
    [MvxFromStoryboard("Main")]
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        #region Declaration

        FirstViewModel _firstVM;

        #endregion


        #region Constructor

        public FirstView (IntPtr handle) : base (handle)
        {
            _firstVM = new FirstViewModel();
        }

        #endregion

        #region ViewController Life Cycle Events

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.LightGray;

            try
            {
                var set = this.CreateBindingSet<FirstView, FirstViewModel>();
                set.Bind(textEditFirst).To(vm => vm.FirstName);
                set.Bind(textEditSecond).To(vm => vm.LastName);
                set.Bind(labelFull).To(vm => vm.FullName);
                //set.Apply();

                //set.Apply() throughs exception, that's why used manual binding on UITextFields EditDidChanged event 
                textEditFirst.AddTarget(TextChangeEventHandler, UIControlEvent.EditingChanged);
                textEditSecond.AddTarget(TextChangeEventHandler, UIControlEvent.EditingChanged);
            }
            catch (Exception ex)
            {
                var trace = ex.StackTrace.ToString();
            }
        }

        #endregion

        #region Action Listeners

        private void TextChangeEventHandler(object sender, EventArgs e)
        {
            if(sender==textEditFirst)
            {
                _firstVM.FirstName = textEditFirst.Text;
                labelFull.Text = _firstVM.FullName;
            }
            else if(sender==textEditSecond)
            {
                _firstVM.LastName = textEditSecond.Text;
                labelFull.Text = _firstVM.FullName;
            }

        }

        #endregion

    }
}
