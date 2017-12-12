using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ICT13580088B2.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            var dbPart = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            dbPart = System.IO.Path.Combine(dbPart, "myshop.db3");


            LoadApplication(new App(dbPart));

            return base.FinishedLaunching(app, options);
        }
    }
}
