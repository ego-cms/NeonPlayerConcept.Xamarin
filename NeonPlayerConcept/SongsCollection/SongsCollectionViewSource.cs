using System;
using NeonPlayerConcept.iOS.Cells.CollectionCell;
using NeonPlayerConcept.iOS.Data;
using UIKit;

namespace NeonPlayerConcept.iOS.SongsCollection
{
    public class SongsCollectionViewSource : UICollectionViewSource
    {
        public Action<FavouriteSongCollectionViewCell> AddSongAction;
        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return DataSource.FavouriteSongs.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, Foundation.NSIndexPath indexPath)
        {
            var song = DataSource.FavouriteSongs[indexPath.Row];
            var item = collectionView.DequeueReusableCell(FavouriteSongCollectionViewCell.Key,indexPath) as FavouriteSongCollectionViewCell;

            item.AddSongAction -= AddSongAction;
            item.AddSongAction += AddSongAction;
            item.CurrentSong = song;
            item.RowIndex = indexPath.Row;
            item.CurrentSong = song;
            return item;
        }
    }
}

