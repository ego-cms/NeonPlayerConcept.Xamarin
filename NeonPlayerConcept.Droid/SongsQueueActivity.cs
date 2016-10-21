using System;
using Android.Animation;
using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views.Animations;
using Android.Widget;
using NeonPlayerConcept.Droid.FavouritesPager;
using NeonPlayerConcept.Droid.SongsRecyclerView;
using RecyclerViewAnimators.Adapters;
using RecyclerViewAnimators.Animators;

namespace NeonPlayerConcept.Droid
{
    [Activity(Theme = "@style/AppTheme")]
    public class SongsQueueActivity : AppCompatActivity
    {
        private ViewPager _viewPager;
        private RecyclerView _recyclerView;
        private SongsRecyclerAdapter _songsAdapter;
        private FavouritesSongsAdapter _favAdapter;
        private RelativeLayout innerContainer;
        private RelativeLayout content;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SongsQueueLayout);
            innerContainer = FindViewById<RelativeLayout>(Resource.Id.inner_container);
            content = FindViewById<RelativeLayout>(Resource.Id.content);
            var cancelButton = FindViewById<ImageView>(Resource.Id.cancel);
            cancelButton.Click += CloseActivity;

            _viewPager = FindViewById<ViewPager>(Resource.Id.fav_view_pager);
            _favAdapter = new FavouritesSongsAdapter(this, AddButtonClick);
            _viewPager.Adapter = _favAdapter;

            var mLayoutManager = new LinearLayoutManager(this);
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);
            _recyclerView.SetLayoutManager(mLayoutManager);
            _recyclerView.AddItemDecoration(new DividerItemDecoration());
            var animator = new SlideInUpAnimator(new OvershootInterpolator(3f));
            _recyclerView.SetItemAnimator(animator);

            _songsAdapter = new SongsRecyclerAdapter();
            var animationAdapter = new AlphaInAnimationAdapter(_songsAdapter);

            content.PostDelayed(() =>
            {
                var anim = InitInnerContainerAnimations();
                anim.AddListener(new AnimatorListener(_recyclerView, animationAdapter));
                anim.Start();
            }, 360);
        }

        class AnimatorListener : AnimatorListenerAdapter
        {
            private RecyclerView _recyclerView;
            private AlphaInAnimationAdapter _animationAdapter;
            public AnimatorListener(RecyclerView recyclerView, AlphaInAnimationAdapter animationAdapter)
            {
                _animationAdapter = animationAdapter;
                _recyclerView = recyclerView;
            }
            public override void OnAnimationEnd(Animator animation)
            {
                _recyclerView.SetAdapter(_animationAdapter);
            }
        }

        void CloseActivity(object sender, EventArgs e)
        {
            Finish();
            OverridePendingTransition(0, Resource.Animation.slide_to_bottom);
        }

        void AddButtonClick(object sender, EventArgs e)
        {
            _viewPager.SetCurrentItem(_viewPager.CurrentItem + 1, true);
            _songsAdapter.AddItem(_viewPager.CurrentItem);
            _recyclerView.ScrollToPosition(0);
        }

        private Animator InitInnerContainerAnimations()
        {
            var scaleUpAnimator = ObjectAnimator.OfPropertyValuesHolder(
                innerContainer,
                PropertyValuesHolder.OfFloat("scaleX", 0.60f, 1f),
                PropertyValuesHolder.OfFloat("scaleY", 0.60f, 1f),
                PropertyValuesHolder.OfFloat("alpha", 0f, 1f)
            );

            scaleUpAnimator.SetInterpolator(new OvershootInterpolator());
            scaleUpAnimator.SetDuration(500);
                return (Animator)scaleUpAnimator;
        }
    }
}

