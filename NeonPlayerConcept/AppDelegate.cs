using System.Diagnostics;
using Foundation;
using UIKit;

namespace NeonPlayerConcept.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override void FinishedLaunching(UIApplication application)
        {
             #if DEBUG
            foreach (var family in UIFont.FamilyNames)
            {
                Debug.WriteLine(family);
                foreach (var name in UIFont.FontNamesForFamilyName(family))
                {
                    Debug.WriteLine("==" + name);
                }
            }
            #endif
        }
        public static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}

