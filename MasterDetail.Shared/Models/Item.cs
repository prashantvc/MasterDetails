using System;
namespace MasterDetail.Shared
{
	public class Item : ModelBase
	{
		/// <summary>
		/// Private backing field to hold the Name
		/// </summary>
		string name = string.Empty;

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}

		/// <summary>
		/// Private backing field to hold the Description
		/// </summary>
		string description = string.Empty;

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description
		{
			get { return description; }
			set { SetProperty(ref description, value); }
		}

		/// <summary>
		/// Private backing field to hold the ImageUrl
		/// </summary>
		string imageUrl = string.Empty;

		/// <summary>
		/// Gets or sets the image URL.
		/// </summary>
		/// <value>The image URL.</value>
		public string ImageUrl
		{
			get { return imageUrl; }
			set { SetProperty(ref imageUrl, value); }
		}

	}
}

