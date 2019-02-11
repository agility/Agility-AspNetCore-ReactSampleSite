using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agility.Web;
using Agility.Web.Objects;
using Website.Extensions;
using Agility.Web.Extensions;
namespace Website.AgilityModels
{
	public partial class BlogPost
	{
		public dynamic GetListingViewModel()
		{
			DynamicPageItem dp = Data.GetDynamicPageItem("~/posts/post-details", this.ContentReferenceName, this.Row);
			string url = $"/posts/{dp.Name}";

			var image = this.PostImage;
			BlogAuthor author = null;
			if (this.AuthorID > 0)
			{
				author = this.Author.GetByID(this.AuthorID);
			}

			if (author == null)
			{
				author = new BlogAuthor()
				{
					Title = "Agility"
				};
			}



			if (author.Image == null)
			{
				author.Image = new Attachment()
				{
					URL = "https://static.agilitycms.com/authors/blank-head-profile-pic.jpg"
				};
			}

			string excerpt = System.Web.HttpUtility.HtmlDecode(this.Excerpt.Truncate(240, "...", true, true));

			var post = new
			{
				key = ContentID,
				title = dp.Title,
				excerpt = excerpt,
				date = this.Date,
				author = author.ToFrontendProps(),
				url = url,
				image = image.ToFrontendProps()

			};

			return post;

		}
	}

}