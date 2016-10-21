using Foundation;
using System;
using UIKit;
using NeonPlayerConcept.iOS.Data;

namespace NeonPlayerConcept.iOS.Cells
{
    public partial class SongQueueTableViewCell : UITableViewCell
    {
        public SongQueueTableViewCell(IntPtr handle) : base (handle)
        {
        }

        public Song CurrentSong { get; set; }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            PlaylistISongTitle.Font = UIFont.FromName("VarelaRound", 13);
            PlaylistISongArtist.Font = UIFont.FromName("OpenSans", 11);

            this.Cover.Image = UIImage.FromBundle(CurrentSong.CoverImageName);
            this.PlaylistISongTitle.Text = CurrentSong.Title;
            this.PlaylistISongArtist.Text = CurrentSong.Artist;
        }
    }
}