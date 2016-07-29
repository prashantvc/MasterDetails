using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using MasterDetail.Shared;

namespace MasterDetails
{
	public partial class MasterViewController : UITableViewController
	{
		public MasterViewController (IntPtr handle) : base (handle)
		{

		}

		DataSource dataSource = null;

		NewsViewModel viewModel = new NewsViewModel ();

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Title = viewModel.Title;

			TableView.Source = dataSource = new DataSource (viewModel.NewsItems);
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "ShowDetailPage") {
				var controller = (DetailsViewController)segue.DestinationViewController;
				var indexPath = TableView.IndexPathForSelectedRow;
				var selectedItem = dataSource.Items [indexPath.Row];

				controller.SetDetails (selectedItem);
			}
		}

		class DataSource : UITableViewSource
		{
			static readonly NSString CellIdentifier = new NSString ("Cell");

			List<Item> items;

			public DataSource (List<Item> items)
			{
				this.items = items;
			}

			public List<Item> Items {
				get {
					return items;
				}
			}

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell (CellIdentifier, indexPath);
				var item = items [indexPath.Row];
				cell.TextLabel.Text = item.Name;
				cell.ImageView.Image = UIImage.FromBundle (item.ImageUrl);

				return cell;
			}

			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return items.Count;
			}

			public override nint NumberOfSections (UITableView tableView)
			{
				return 1;
			}
		}
	}
}