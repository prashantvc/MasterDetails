using Foundation;
using System;
using UIKit;
using MasterDetail.Shared;

namespace MasterDetails
{
	public partial class DetailsViewController : UIViewController
	{
		Item item = null;

		public DetailsViewController (IntPtr handle) : base (handle)
		{
		}

		public void SetDetails (Item item)
		{
			this.item = item;

			Title = item.Name;


		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			if (!IsViewLoaded)
				return;

			HeaderImage.Image = UIImage.FromBundle (item.ImageUrl);
			DetailsLabel.Text = item.Description;

		}
	}
}