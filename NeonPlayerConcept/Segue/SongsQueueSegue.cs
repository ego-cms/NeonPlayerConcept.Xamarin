using Foundation;
using System;
using UIKit;
using CoreAnimation;
using NeonPlayerConcept.iOS.ViewControllers;

namespace NeonPlayerConcept.iOS.Segue
{
    public partial class SongsQueueSegue : UIStoryboardSegue
    {
        public SongsQueueSegue(IntPtr handle) : base(handle)
        {
        }

        public override void Perform()
        {
            var songsQueueVC = DestinationViewController as SongsQueueViewController;

            DestinationViewController.View.Alpha = 1;

            var gradientLayer = new CAGradientLayer();
            gradientLayer.Frame = songsQueueVC.SongsQueueView.Bounds;
            gradientLayer.Colors = new CoreGraphics.CGColor[] { UIColor.White.ColorWithAlpha(0).CGColor, UIColor.White.CGColor, UIColor.White.CGColor };
            gradientLayer.Locations = new NSNumber[] { 0, 0.25, 1 };
            songsQueueVC.MaskView.Layer.InsertSublayer(gradientLayer, 0);

            songsQueueVC.BackgroundView.Transform = CoreGraphics.CGAffineTransform.MakeScale((nfloat)0.5, (nfloat)0.5);

            songsQueueVC.PlayingSongCoverImageView.Alpha = (nfloat)0.4;
            songsQueueVC.PlayingSongCoverImageView.Transform = CoreGraphics.CGAffineTransform.MakeScale((nfloat)0.8, (nfloat)0.8);
            songsQueueVC.PlayingSongCoverImageView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 6);

            songsQueueVC.SongTitle.Alpha = (nfloat)0.4;
            songsQueueVC.SongArtist.Alpha = (nfloat)0.4;
            songsQueueVC.SongTitle.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 6);
            songsQueueVC.SongArtist.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 6);

            songsQueueVC.SongsQueueView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, songsQueueVC.SongsQueueView.Bounds.Height / 3);
            songsQueueVC.MaskView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, songsQueueVC.SongsQueueView.Bounds.Height / 3);

            songsQueueVC.ProgressView.Alpha = 0;
            songsQueueVC.FooterView.Alpha = 0;

            SourceViewController.View.AddSubview(DestinationViewController.View);


            UIView.Animate(0.56, 0, UIViewAnimationOptions.CurveEaseOut, () =>
            {
                songsQueueVC.BackgroundView.Transform = CoreGraphics.CGAffineTransform.MakeScale(1, 1);
            }, null);

            UIView.Animate(0.14, 0, UIViewAnimationOptions.CurveLinear, () =>
            {
                songsQueueVC.PlayingSongCoverImageView.Alpha = 1;
                songsQueueVC.PlayingSongCoverImageView.Transform = CoreGraphics.CGAffineTransform.MakeScale(1, 1);
                songsQueueVC.PlayingSongCoverImageView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 0);

                songsQueueVC.SongTitle.Alpha = 1;
                songsQueueVC.SongArtist.Alpha = 1;
                songsQueueVC.SongTitle.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 0);
                songsQueueVC.SongArtist.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 0);
            }, null);

            UIView.Animate(0.14, 0.07, UIViewAnimationOptions.CurveEaseInOut, () =>
            {
                songsQueueVC.SongTitle.Alpha = 1;
                songsQueueVC.SongArtist.Alpha = 1;
                songsQueueVC.SongTitle.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 0);
                songsQueueVC.SongArtist.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 0);
            }, null);

            UIView.Animate(0.8, 0, UIViewAnimationOptions.CurveEaseInOut, () =>
            {
                songsQueueVC.ProgressView.Alpha = 1;
            }, null);

            UIView.Animate(0.14, 0, UIViewAnimationOptions.CurveEaseOut, () =>
            {
                songsQueueVC.SongsQueueView.Transform = CoreGraphics.CGAffineTransform.MakeScale(1, 1);
                songsQueueVC.SongsQueueView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 0);
                songsQueueVC.MaskView.Transform = CoreGraphics.CGAffineTransform.MakeScale(1, 1);
                songsQueueVC.MaskView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, 20);
            }, null);

            UIView.Animate(0.4, 0.14, UIViewAnimationOptions.CurveEaseInOut, () =>
            {
                songsQueueVC.MaskView.Transform = CoreGraphics.CGAffineTransform.MakeTranslation(0, songsQueueVC.MaskView.Frame.Size.Height);
                songsQueueVC.FooterView.Alpha = 1;
            }, () => 
            {
                DestinationViewController.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;
                SourceViewController.PresentViewController(DestinationViewController, false, null); 
            });
        }
    }
}