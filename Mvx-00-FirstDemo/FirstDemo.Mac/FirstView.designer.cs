// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FirstDemo.Mac
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        AppKit.NSTextField labelFull { get; set; }

        [Outlet]
        AppKit.NSTextField textEditFirst { get; set; }

        [Outlet]
        AppKit.NSTextField textEditSecond { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (textEditFirst != null) {
                textEditFirst.Dispose ();
                textEditFirst = null;
            }

            if (textEditSecond != null) {
                textEditSecond.Dispose ();
                textEditSecond = null;
            }

            if (labelFull != null) {
                labelFull.Dispose ();
                labelFull = null;
            }
        }
    }
}
