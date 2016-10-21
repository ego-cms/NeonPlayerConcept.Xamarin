using System;

using Foundation;
using NeonPlayerConcept.iOS.Data;
using UIKit;

namespace NeonPlayerConcept.iOS.Cells.CollectionCell
{
    public partial class FavouriteSongCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("FavouriteSongCollectionViewCell");
        public static readonly UINib Nib;

        static FavouriteSongCollectionViewCell()
        {
            Nib = UINib.FromName("FavouriteSongCollectionViewCell", NSBundle.MainBundle);
        }

        protected FavouriteSongCollectionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public Song CurrentSong { get; set; }
        public event Action<FavouriteSongCollectionViewCell> AddSongAction;
        public int RowIndex { get; set; }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            FavouritesTitle.Font = UIFont.FromName("VarelaRound", 13);
            FavouritesArtist.Font = UIFont.FromName("OpenSans", 11);

            this.Cover.Image = UIImage.FromBundle(CurrentSong.CoverImageName);
            this.FavouritesTitle.Text = CurrentSong.Title;
            this.FavouritesArtist.Text = CurrentSong.Artist;
            this.AddToQueueButton.TouchUpInside -= AddButtonClick;
            this.AddToQueueButton.TouchUpInside += AddButtonClick;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (AddSongAction != null)
            {
                AddSongAction(this);
            }
        }
    }
}
