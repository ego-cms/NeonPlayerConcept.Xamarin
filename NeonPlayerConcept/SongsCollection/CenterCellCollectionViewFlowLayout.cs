using System;
using UIKit;

namespace NeonPlayerConcept.iOS.SongsCollection
{
    public class CenterCellCollectionViewFlowLayout : UICollectionViewFlowLayout
    {
        //public override CoreGraphics.CGSize ItemSize
        //{
        //    get
        //    {
        //        return base.ItemSize;
        //    }
        //    set
        //    {
        //        base.ItemSize = value;
        //    }
        //}

        public override CoreGraphics.CGPoint TargetContentOffset(CoreGraphics.CGPoint proposedContentOffset, CoreGraphics.CGPoint scrollingVelocity)
        {
            if (this.CollectionView != null)
            {
                var cv = this.CollectionView;
                var cvBounds = cv.Bounds;
                var halfWidth = cvBounds.Size.Width * 0.5;
                var proposedContentOffsetCenterX = proposedContentOffset.X + halfWidth;

                if (this.LayoutAttributesForElementsInRect(cvBounds) != null)
                {
                    var attributesForVisibleCells = this.LayoutAttributesForElementsInRect(cvBounds);
                    UICollectionViewLayoutAttributes candidateAttributes = null;

                    foreach (var attribute in attributesForVisibleCells)
                    {
                        if (attribute.RepresentedElementCategory != UICollectionElementCategory.Cell) continue;

                        if (candidateAttributes != null)
                        {
                            var candAttrs = candidateAttributes;
                            var a = attribute.Center.X - proposedContentOffsetCenterX;
                            var b = candAttrs.Center.X - proposedContentOffsetCenterX;

                            if (Math.Abs(a) < Math.Abs(b))
                            {
                                candidateAttributes = attribute;
                            }
                        }
                        else
                        {
                            candidateAttributes = attribute;
                            continue;
                        }
                    }

                    return new CoreGraphics.CGPoint(Math.Round(candidateAttributes.Center.X - halfWidth), y: proposedContentOffset.Y);
                }
            }

            return base.TargetContentOffsetForProposedContentOffset(proposedContentOffset);
        }
    }
}

