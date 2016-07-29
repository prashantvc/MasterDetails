using System;
using System.Collections.Generic;

namespace MasterDetail.Shared
{
	public class NewsViewModel : ViewModelBase
	{
		public NewsViewModel ()
		{
			Title = "News";
			PopulateData ();
		}

		public List<Item> NewsItems { get; } = new List<Item> ();

		void PopulateData ()
		{
			NewsItems.Add (new Item { Name = "One", Description = "This is item one", ImageUrl = @"Images/Sport1.jpeg" });
			NewsItems.Add (new Item { Name = "Two", Description = "This is item two", ImageUrl = @"Images/Sport2.jpeg" });
			NewsItems.Add (new Item { Name = "Three", Description = "This is item three", ImageUrl = @"Images/Sport3.jpeg" });
		}

	}
}

