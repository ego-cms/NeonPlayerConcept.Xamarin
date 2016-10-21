using Android.App;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;

namespace NeonPlayerConcept.Droid.SongsRecyclerView
{
    public class DividerItemDecoration : RecyclerView.ItemDecoration
    {
        private Drawable mDivider;

        public DividerItemDecoration()
        {
            mDivider = Application.Context.Resources.GetDrawable(Resource.Drawable.line_divider);
        }

        public override void OnDrawOver(Android.Graphics.Canvas cValue, RecyclerView parent, RecyclerView.State state)
        {
            int left = parent.PaddingLeft;
            int right = parent.Width - parent.PaddingRight;

            int childCount = parent.ChildCount;
            for (int i = 0; i < childCount; i++)
            {
                var child = parent.GetChildAt(i);

                var parameters = (RecyclerView.LayoutParams)child.LayoutParameters;

                int top = child.Bottom + parameters.BottomMargin;
                int bottom = top + mDivider.IntrinsicHeight;

                mDivider.SetBounds(left, top, right, bottom);
                mDivider.Draw(cValue);
            }
        }
    }
}

