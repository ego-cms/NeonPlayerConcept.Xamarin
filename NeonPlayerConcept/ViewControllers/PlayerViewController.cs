using System;
using UIKit;

namespace NeonPlayerConcept.iOS.ViewControllers
{
    public partial class PlayerViewController : UIViewController
    {
        public PlayerViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            PlayerScreenImage.UserInteractionEnabled = true;
            PlayerScreenImage.AddGestureRecognizer(new UITapGestureRecognizer(CoverImageDidTap));
        }

        private void CoverImageDidTap()
        {
            PerformSegue("toSongsQueueSegue", this);
        }
    }
}