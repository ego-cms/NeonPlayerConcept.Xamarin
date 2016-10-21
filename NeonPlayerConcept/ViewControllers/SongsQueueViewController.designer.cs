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

namespace NeonPlayerConcept.iOS.ViewControllers
{
    [Register ("SongsQueueViewController")]
    partial class SongsQueueViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView BackgroundView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIButton CloseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView ContentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UICollectionView FavouriteSongsCollectionView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel FavouritesTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView FooterView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView MaskView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel NextLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIImageView PlayerBlurScreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIImageView PlayingSongCoverImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIProgressView ProgressView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel SongArtist { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel SongsQueueTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView SongsQueueView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel SongTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView SubContentViewClipped { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView SunContentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UITableView TableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BackgroundView != null) {
                BackgroundView.Dispose ();
                BackgroundView = null;
            }

            if (CloseButton != null) {
                CloseButton.Dispose ();
                CloseButton = null;
            }

            if (ContentView != null) {
                ContentView.Dispose ();
                ContentView = null;
            }

            if (FavouriteSongsCollectionView != null) {
                FavouriteSongsCollectionView.Dispose ();
                FavouriteSongsCollectionView = null;
            }

            if (FavouritesTitle != null) {
                FavouritesTitle.Dispose ();
                FavouritesTitle = null;
            }

            if (FooterView != null) {
                FooterView.Dispose ();
                FooterView = null;
            }

            if (MaskView != null) {
                MaskView.Dispose ();
                MaskView = null;
            }

            if (NextLabel != null) {
                NextLabel.Dispose ();
                NextLabel = null;
            }

            if (PlayerBlurScreen != null) {
                PlayerBlurScreen.Dispose ();
                PlayerBlurScreen = null;
            }

            if (PlayingSongCoverImageView != null) {
                PlayingSongCoverImageView.Dispose ();
                PlayingSongCoverImageView = null;
            }

            if (ProgressView != null) {
                ProgressView.Dispose ();
                ProgressView = null;
            }

            if (SongArtist != null) {
                SongArtist.Dispose ();
                SongArtist = null;
            }

            if (SongsQueueTitle != null) {
                SongsQueueTitle.Dispose ();
                SongsQueueTitle = null;
            }

            if (SongsQueueView != null) {
                SongsQueueView.Dispose ();
                SongsQueueView = null;
            }

            if (SongTitle != null) {
                SongTitle.Dispose ();
                SongTitle = null;
            }

            if (SubContentViewClipped != null) {
                SubContentViewClipped.Dispose ();
                SubContentViewClipped = null;
            }

            if (SunContentView != null) {
                SunContentView.Dispose ();
                SunContentView = null;
            }

            if (TableView != null) {
                TableView.Dispose ();
                TableView = null;
            }
        }
    }
}