// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MasterDetails
{
    [Register ("DetailsViewController")]
    partial class DetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DetailsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HeaderImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DetailsLabel != null) {
                DetailsLabel.Dispose ();
                DetailsLabel = null;
            }

            if (HeaderImage != null) {
                HeaderImage.Dispose ();
                HeaderImage = null;
            }
        }
    }
}