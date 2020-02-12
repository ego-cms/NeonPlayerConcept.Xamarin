using System.Diagnostics;
using Foundation;
using UIKit;

namespace NeonPlayerConcept.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }
        
        public static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
            
        }
    }
}

