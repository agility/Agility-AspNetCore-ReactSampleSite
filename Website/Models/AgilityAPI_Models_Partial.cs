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

	public partial class Resource
	{
		public dynamic GetListingViewModel()
		{
			ResourceType resourceType = null;
			if (this.ResourceTypeID > 0)
			{
				resourceType = this.ResourceType.GetByID(this.ResourceTypeID);
			}

			DynamicPageItem dp = Data.GetDynamicPageItem("~/resources/resource-details", this.ContentReferenceName, this.Row);
			string url = $"/resources/{dp.Name}";

			var viewModel = new
			{
				key = this.ContentID,
				image = this.Image?.ToFrontendProps(),
				label = resourceType?.Title,
				resourceTypeID = ResourceTypeID,
				title = this.Title,
				text = this.Excerpt.Truncate(75, "...", true, true),
				url = url
			};

			return viewModel;

		}

	}

	public partial class Logo
	{
		public bool MatchesWith(string[] thoseIDs)
		{
			if (thoseIDs == null || thoseIDs.Length == 0) return true;
			if (string.IsNullOrWhiteSpace(this.LogoTagIDs)) return false;

			string[] thisIDs = this.LogoTagIDs.Split(',');

			var ret = thisIDs.Any(i => thoseIDs.Contains(i));
			return ret;

		}
		public dynamic GetPartnerListingViewModel(string labelIDs, string dynPath)
		{
			IList<LogoTags> tags = null;
			LogoTags logoTag = null;
			if (!string.IsNullOrWhiteSpace(this.LogoTagIDs))
			{
				tags = this.LogoTags.GetByIDs(this.LogoTagIDs);
				var tagIDsForLabel = labelIDs.Split(',');
				logoTag = tags.FirstOrDefault(tag => tagIDsForLabel.Contains(tag.ContentID.ToString()));
			}

			string dynPathForFormula = dynPath.Substring(0, dynPath.LastIndexOf("/"));

			DynamicPageItem dp = Data.GetDynamicPageItem(dynPath, this.ContentReferenceName, this.Row);
			string url = $"{dynPathForFormula}/{dp.Name}";

			var viewModel = new
			{
				key = this.ContentID,
				image = this._Logo?.ToFrontendProps(),
				label = logoTag?.Title,
				resourceTypeID = logoTag?.ContentID,
				title = this.Title,
				text = this.Description.Truncate(75, "...", true, true),
				url = url
			};

			return viewModel;

		}

	}

	public partial class BlogAuthor
	{
		public const string BlankImage = "https://static.agilitycms.com/authors/blank-head-profile-pic.jpg";
	}

	public partial class BlogPost
	{

		public bool MatchesWith(string[] thoseIDs)
		{
			if (thoseIDs == null || thoseIDs.Length == 0) return true;
			if (string.IsNullOrWhiteSpace(this.CategoriesIDs)) return false;

			string[] thisIDs = this.CategoriesIDs.Split(',');

			var ret = thisIDs.Any(i => thoseIDs.Contains(i));
			return ret;

		}

		public dynamic GetDetailsViewModel()
		{

			BlogCategory category = null;
			BlogAuthor author = null;

			if (!string.IsNullOrWhiteSpace(CategoriesIDs))
			{
				var cats = Categories.GetByIDs(CategoriesIDs);
				if (cats.Count > 0) category = cats[0];
			}

			if (AuthorID > 0)
			{
				author = Author.GetByID(AuthorID);
			}

			if (author == null)
			{
				author = new BlogAuthor()
				{
					Title = AuthorTitle,
					Image = new Attachment()
					{
						URL = BlogAuthor.BlankImage
					}
				};
			}



			var viewModel = new
			{
				post = this.ToFrontendProps(),
				category = category?.ToFrontendProps(),
				author = author.ToFrontendProps()
			};

			return viewModel;

		}


		public dynamic GetListingViewModel(int excerptLength = 240)
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
					URL = BlogAuthor.BlankImage
				};
			}

			string excerpt = System.Web.HttpUtility.HtmlDecode(this.Excerpt.Truncate(excerptLength, "...", true, true));

			var post = new
			{
				key = ContentID,
				title = dp.Title,
				excerpt = excerpt,
				date = this.Date,
				author = author,
				url = url,
				image = image

			};

			return post;

		}
	}
}