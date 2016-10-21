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

namespace NeonPlayerConcept.iOS.Cells
{
    [Register ("SongQueueTableViewCell")]
    partial class SongQueueTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Cover { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PlaylistISongArtist { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PlaylistISongTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Cover != null) {
                Cover.Dispose ();
                Cover = null;
            }

            if (PlaylistISongArtist != null) {
                PlaylistISongArtist.Dispose ();
                PlaylistISongArtist = null;
            }

            if (PlaylistISongTitle != null) {
                PlaylistISongTitle.Dispose ();
                PlaylistISongTitle = null;
            }
        }
    }
}