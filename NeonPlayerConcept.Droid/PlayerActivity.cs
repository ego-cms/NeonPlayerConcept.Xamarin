using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Support.V7.App;

namespace NeonPlayerConcept.Droid
{
    [Activity(MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/AppTheme")]
    public class PlayerActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PlayerViewLayout);

            var coverImage = FindViewById<ImageView>(Resource.Id.cover_image);
            coverImage.Click += CoverImageClick;
        }

        private void CoverImageClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SongsQueueActivity));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
        }
    }
}


