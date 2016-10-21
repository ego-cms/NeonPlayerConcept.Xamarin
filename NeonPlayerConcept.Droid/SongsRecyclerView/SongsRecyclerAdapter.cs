using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using NeonPlayerConcept.Droid.Data;

namespace NeonPlayerConcept.Droid.SongsRecyclerView
{
    public class SongsRecyclerAdapter : RecyclerView.Adapter
    {
        public override int ItemCount => DataSource.SongsQueue.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var vh = holder as SongViewHolder;

            var imageId = Application.Context.Resources.GetIdentifier(DataSource.SongsQueue[position].CoverImageName, "drawable", Application.Context.PackageName);
            vh.CoverImage.SetImageResource(imageId);
            vh.Title.Text = DataSource.SongsQueue[position].Title;
            vh.Artist.Text = DataSource.SongsQueue[position].Artist;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = (ViewGroup)LayoutInflater.From(parent.Context).Inflate(Resource.Layout.List_item_recycler_view, parent, false);
            var viewHolder = new SongViewHolder(itemView);

            return viewHolder;
        }

        public void AddItem(int position)
        {
            DataSource.SongsQueue.Insert(0, DataSource.FavouriteSongs[position]);
            NotifyItemInserted(0);
        }
    }
}

