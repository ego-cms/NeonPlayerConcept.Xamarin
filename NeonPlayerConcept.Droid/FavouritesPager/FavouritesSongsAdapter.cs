using System;
using Android.App;
using Android.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using NeonPlayerConcept.Droid.Data;

namespace NeonPlayerConcept.Droid.FavouritesPager
{
    public class FavouritesSongsAdapter : PagerAdapter
    {
        private readonly Context _context;
        private EventHandler Addhandler { get; set; }

        public FavouritesSongsAdapter(Context context)
        {
            _context = context;
        }

        public FavouritesSongsAdapter(Context context, EventHandler addhandler)
        {
            _context = context;
            Addhandler = addhandler;
        }

        public override int Count => DataSource.FavouriteSongs.Count;

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            var inflater = LayoutInflater.From(_context);
            var item = (ViewGroup)inflater.Inflate(Resource.Layout.Page_item_favorites, container, false);
            container.AddView(item);

            var favCoverImage = item.FindViewById<ImageView>(Resource.Id.album_logo);
            var addButton = item.FindViewById<ImageView>(Resource.Id.button_plus);
            var songTitle = item.FindViewById<TextView>(Resource.Id.song_title);
            var songArtist = item.FindViewById<TextView>(Resource.Id.song_artist);

            var imageId = _context.Resources.GetIdentifier(DataSource.FavouriteSongs[position].CoverImageName, "drawable", Application.Context.PackageName);
            favCoverImage.SetImageResource(imageId);
            addButton.SetImageResource(Resource.Drawable.ic_add_circle_outline_white_24dp);
            songTitle.Text = DataSource.FavouriteSongs[position].Title;
            songArtist.Text = DataSource.FavouriteSongs[position].Artist;
            addButton.Click += Addhandler;

            return item;
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object objectValue)
        {
            return view == objectValue;
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object objectValue)
        {
            container.RemoveView((View)objectValue);
        }
    }
}

