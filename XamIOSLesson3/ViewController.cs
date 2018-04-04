using System;
using System.Collections.Generic;
using UIKit;

namespace XamIOSLesson3
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            List<string> names = new List<string>{
                "Bass (1)",
                "Beckenridge (1)",
                "Budweiser (3)",
                "Casa de la Cerveza (2)",
                "Corona (3)",
                "Del Puerto (7)",
                "Delirium (4)",
                "Duvel (2)",
                "Elysian (1)",
                "Floris (3)",
                "Four Peaks (1)",
                "Franziskaner (4)",
                "Golden Road (3)",
                "Goose Island (4)",
                "Hoegaarden (2)",
                "Kona (2)",
                "La Chouffe (1)",
                "Leffe (7)",
                "Lemu (3)",
                "Liefmans (1)",
                "Lowenbrau (2)",
                "Maredsous (1)",
                "Mestra (4)",
                "Orval (1)",
                "Quilmes (1)",
                "Quimera (5)",
                "Salzburg (4)",
                "Schofferhofer (1)",
                "Spaten (3)",
                "Stella Artois (2)",
                "Ten Barrel (1)",
                "Tübinger (2)",
                "Vedett (2)"
            };

            TableViewNames.Source = new TablesViewNames(names);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
