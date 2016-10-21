using System;
using Foundation;
using NeonPlayerConcept.iOS.Cells;
using NeonPlayerConcept.iOS.Data;
using UIKit;

namespace NeonPlayerConcept.iOS.SongsTable
{
    public class SongsTableViewSource : UITableViewSource
    {
        public static int RowHeight = 56;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var song = DataSource.SongsQueue[indexPath.Row];
            var cell = tableView.DequeueReusableCell("cell") as SongQueueTableViewCell;

            cell.CurrentSong = song;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return DataSource.SongsQueue.Count;
        }

        public override bool CanMoveRow(UITableView tableView, NSIndexPath indexPath)
        {
            return true;
        }

        public override void MoveRow(UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
        {
            var songToMove = DataSource.SongsQueue[sourceIndexPath.Row];
            var deleteAt = sourceIndexPath.Row;
            var insertAt = destinationIndexPath.Row;

            if (destinationIndexPath.Row < sourceIndexPath.Row)
            {
                // add one to where we delete, because we're increasing the index by inserting
                deleteAt += 1;
            }
            else {
                // add one to where we insert, because we haven't deleted the original yet
                insertAt += 1;
            }

            DataSource.SongsQueue.Insert(insertAt, songToMove);
            DataSource.SongsQueue.RemoveAt(deleteAt);

        }

        public override UITableViewCellEditingStyle EditingStyleForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return UITableViewCellEditingStyle.None;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return RowHeight;
        }

        public override bool ShouldIndentWhileEditing(UITableView tableView, NSIndexPath indexPath)
        {
            return false;
        }
    }
}

