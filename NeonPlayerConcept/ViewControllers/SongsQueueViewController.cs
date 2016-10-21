using System;
using System.Linq;
using UIKit;
using NeonPlayerConcept.iOS.SongsTable;
using NeonPlayerConcept.iOS.SongsCollection;
using NeonPlayerConcept.iOS.Data;
using Foundation;
using NeonPlayerConcept.iOS.Cells.CollectionCell;
using System.Collections.Generic;

namespace NeonPlayerConcept.iOS.ViewControllers
{
    public partial class SongsQueueViewController : UIViewController
    {
        public SongsQueueViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TableView.SetEditing(true, true);
            TableView.ScrollEnabled = true;
            CloseButton.TouchUpInside += (sender, e) =>
            {
                this.DismissViewController(true, null);
            };

            var songsTableViewSource = new SongsTableViewSource();
            TableView.Source = songsTableViewSource;

            var viewFlowLayout = new CenterCellCollectionViewFlowLayout
            {
                ScrollDirection = UICollectionViewScrollDirection.Horizontal
            };
            FavouriteSongsCollectionView.SetCollectionViewLayout(viewFlowLayout, false);

            var songsCollectionViewSource = new SongsCollectionViewSource();
            FavouriteSongsCollectionView.RegisterNibForCell(FavouriteSongCollectionViewCell.Nib, FavouriteSongCollectionViewCell.Key);
            songsCollectionViewSource.AddSongAction = AddSongToQueue;
            FavouriteSongsCollectionView.Source = songsCollectionViewSource;
            FavouriteSongsCollectionView.ReloadData();
        }

        private void AddSongToQueue(FavouriteSongCollectionViewCell cell)
        {
            var cellToMoveFromFavouritesToQueue = DataSource.FavouriteSongs[cell.RowIndex];
            DataSource.SongsQueue.Insert(0, cellToMoveFromFavouritesToQueue);

            var collectionCellToRemove = FavouriteSongsCollectionView.IndexPathForCell(cell);
            DataSource.FavouriteSongs.RemoveAt(cell.RowIndex);
            FavouriteSongsCollectionView.DeleteItems(new Foundation.NSIndexPath[] { collectionCellToRemove });

            if (IsFirstRowVisible)
            {
                TableView.ReloadData();
                PerformAnimation();
            }
            else
            {
                TableView.BeginUpdates();
                TableView.InsertRows(new NSIndexPath[] { NSIndexPath.FromRowSection(0, 0) }, UITableViewRowAnimation.Bottom);
                TableView.EndUpdates();
            }
        }

        void PerformAnimation()
        {
            var cellsToMove = new List<UITableViewCell>();
            var otherCells = TableView.VisibleCells.ToList();

            for (int i = 0; i < 3; i++)
            {
                if (TableView.CellAt(NSIndexPath.FromRowSection(i, 0)) == null)
                    break;
                cellsToMove.Add(TableView.CellAt(NSIndexPath.FromRowSection(i, 0)));
                otherCells.RemoveAt(0); 
            }

            if (cellsToMove.Count == 0)
                return;
            
            foreach (var visible_cell in TableView.VisibleCells)
            {
                var cell_center = visible_cell.Center;
                cell_center.Y -= visible_cell.Frame.Height;
                visible_cell.Center = cell_center;
            }

            UIView.AnimateNotify(0.56, 0, (nfloat)0.5, 15, UIViewAnimationOptions.TransitionNone, () =>
            {
                foreach (var cell in cellsToMove)
                {
                    var cellCenter = cell.Center;
                    cellCenter.Y += cell.Frame.Height;
                    cell.Center = cellCenter; 
                }
            }, null);

            UIView.Animate(0.24, () =>
            {
                foreach (var visible_cell in otherCells)
                {
                    var cell_center = visible_cell.Center;
                    cell_center.Y += visible_cell.Frame.Height;
                    visible_cell.Center = cell_center;
                }
            }, null);
        }

        public bool IsFirstRowVisible => TableView.CellAt(NSIndexPath.FromRowSection(0, 0)) != null;

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            BackgroundView.Layer.CornerRadius = 4;

            PlayingSongCoverImageView.Layer.MasksToBounds = false;
            PlayingSongCoverImageView.Layer.ShadowOffset = new CoreGraphics.CGSize(1.0, 0.0);
            PlayingSongCoverImageView.Layer.ShadowRadius = 5;
            PlayingSongCoverImageView.Layer.ShadowOpacity = 0.5F;
        }

        public override void ViewDidLayoutSubviews()
        {
            SongsQueueTitle.Font = UIFont.FromName("VarelaRound", 14);
            SongTitle.Font = UIFont.FromName("VarelaRound", 14);
            NextLabel.Font = UIFont.FromName("VarelaRound", 9);
            FavouritesTitle.Font = UIFont.FromName("VarelaRound", 9);

            var collectionWidth = View.Frame.Size.Width - 50;
            var collectionViewFrame = FavouriteSongsCollectionView.Frame;
            FavouriteSongsCollectionView.Frame = collectionViewFrame;
            var collectionViewItemSize = (FavouriteSongsCollectionView.CollectionViewLayout as UICollectionViewFlowLayout).ItemSize;
            collectionViewItemSize.Width = collectionWidth;
            collectionViewItemSize.Height = 44;
            (FavouriteSongsCollectionView.CollectionViewLayout as UICollectionViewFlowLayout).ItemSize = collectionViewItemSize;
            FavouriteSongsCollectionView.DecelerationRate = UIScrollView.DecelerationRateFast;
        }
    }
}