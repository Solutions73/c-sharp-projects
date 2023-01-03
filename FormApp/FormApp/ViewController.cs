using System;

using AppKit;
using Foundation;

namespace FormApp
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        partial void SubmitBtnAction(NSButton sender)
        {
            var name = NameOutlet.StringValue;
            var email = EmailOutlet.StringValue;
            var checkbox = CheckOutlet.State;
            string data = "Value of Name field: " + name + "Value of Email field: " + email + "Value of Checkbox field: " + checkbox;
        }
    }
}
