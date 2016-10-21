using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace NeonPlayerConcept.Droid.SongsRecyclerView
{
    public class SongViewHolder : RecyclerView.ViewHolder
    {
        public ImageView CoverImage { get; private set; }
        public TextView Title { get; private set; }
        public TextView Artist { get; private set; }

        public SongViewHolder(ViewGroup itemView) : base(itemView)
        {
            CoverImage = itemView.FindViewById<ImageView>(Resource.Id.row_album_logo);
            Title = itemView.FindViewById<TextView>(Resource.Id.row_song_title);
            Artist = itemView.FindViewById<TextView>(Resource.Id.row_song_artist);
        }
    }
}

