using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agility.Web;
using Agility.Web.Objects;

namespace Website.AgilityModels
{
	public partial class BlogPost
	{
		public dynamic GetListingViewModel()
		{
			DynamicPageItem dp = Data.GetDynamicPageItem("~/posts/post-details", this.ContentReferenceName, this.Row);
			string url = $"/posts/{dp.Name}";

			var image = this.ListingImageOverride != null ? this.ListingImageOverride : this.PostImage;
			BlogAuthor author = null;
			if (this.AuthorID > 0)
			{
				author = this.Author.GetByID(this.AuthorID);
			}

			var post = new
			{
				key = ContentID,
				title = dp.Title,
				excerpt = this.Excerpt,
				date = this.Date,
				author = author == null ? "Agility" : author.Title,
				url = url,
				image = image

			};

			return post;

		}
	}

}