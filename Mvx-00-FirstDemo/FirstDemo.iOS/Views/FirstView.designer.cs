// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FirstDemo.iOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelFull { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textEditFirst { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textEditSecond { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelFull != null) {
                labelFull.Dispose ();
                labelFull = null;
            }

            if (textEditFirst != null) {
                textEditFirst.Dispose ();
                textEditFirst = null;
            }

            if (textEditSecond != null) {
                textEditSecond.Dispose ();
                textEditSecond = null;
            }
        }
    }
}