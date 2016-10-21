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

namespace NeonPlayerConcept.iOS.Cells.CollectionCell
{
    [Register ("FavouriteSongCollectionViewCell")]
    partial class FavouriteSongCollectionViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddToQueueButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Cover { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FavouritesArtist { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FavouritesTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddToQueueButton != null) {
                AddToQueueButton.Dispose ();
                AddToQueueButton = null;
            }

            if (Cover != null) {
                Cover.Dispose ();
                Cover = null;
            }

            if (FavouritesArtist != null) {
                FavouritesArtist.Dispose ();
                FavouritesArtist = null;
            }

            if (FavouritesTitle != null) {
                FavouritesTitle.Dispose ();
                FavouritesTitle = null;
            }
        }
    }
}