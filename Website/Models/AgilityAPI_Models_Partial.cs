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


			var viewModel = new
			{
				key = this.ContentID,
				image = this.Image?.ToImage(),
				label = resourceType?.Title,
				resourceTypeID = ResourceTypeID,
				title = this.Title,
				text = this.Excerpt.Truncate(75, "...", true, true),
				url = this.ResolveDynamicPageItemUrl()
			};

			return viewModel;

		}

	}

	public partial class CaseStudy
	{
		public dynamic GetFeaturedListingViewModel()
		{

			var viewModel = new
			{
				key = this.ContentID,
				image = this.Image?.ToImage(),
				label = "Case Study",
				resourceTypeID = -1,
				title = this.Title,
				text = this.Excerpt.Truncate(75, "...", true, true),
				url = this.ResolveDynamicPageItemUrl(),
				logo = this.CustomerLogo?.ToImage(),
				products = this.Products.GetByIDs(this.ProductIDs).Select(p => p.ToFrontendProps())
			};

			return viewModel;

		}

	}

	public partial class FeatureBlock
	{
		public bool MatchesWith(string[] thoseIDs)
		{
			if (thoseIDs == null || thoseIDs.Length == 0) return true;
			if (string.IsNullOrWhiteSpace(this.CustomTagsIDs)) return false;

			string[] thisIDs = this.CustomTagsIDs.Split(',');

			var ret = thisIDs.Any(i => thoseIDs.Contains(i));
			return ret;

		}

		public dynamic GetFeatureListingViewModel(string labelIDs)
		{
			IList<CustomTag> tags = null;
			CustomTag c_tag = null;
			if (!string.IsNullOrWhiteSpace(this.CustomTagsIDs))
			{
				tags = this.CustomTags.GetByIDs(this.CustomTagsIDs);
				List<string> tagIDsForLabel = new List<string>();
				if (!string.IsNullOrEmpty(labelIDs))
				{
					tagIDsForLabel = labelIDs.Split(',').ToList();
				}
				c_tag = tags.FirstOrDefault(tag => tagIDsForLabel.Contains(tag.ContentID.ToString()));
			}

			var viewModel = new
			{
				key = this.ContentID,
				image = this.Icon?.ToFrontendProps(),
				label = c_tag?.Title,
				resourceTypeID = c_tag?.ContentID,
				title = this.Title,
				text = this.TextBlob.Truncate(75, "...", true, true),
				url = this.BottomLink?.ParseUrl()?.Href
			};

			return viewModel;
		}
	}

	public partial class Partner
	{

		public bool MatchesWith(string[] thoseIDs)
		{
			if (thoseIDs == null || thoseIDs.Length == 0) return true;
			if (string.IsNullOrWhiteSpace(this.CustomTagsIDs)) return false;

			string[] thisIDs = this.CustomTagsIDs.Split(',');

			var ret = thisIDs.Any(i => thoseIDs.Contains(i));
			return ret;

		}
		public dynamic GetPartnerListingViewModel(string labelIDs)
		{
			IList<CustomTag> tags = null;
			CustomTag c_tag = null;
			if (!string.IsNullOrWhiteSpace(this.CustomTagsIDs))
			{
				tags = this.CustomTags.GetByIDs(this.CustomTagsIDs);
				List<string> tagIDsForLabel = new List<string>();
				if (!string.IsNullOrEmpty(labelIDs))
				{
					tagIDsForLabel = labelIDs.Split(',').ToList();
				}
				c_tag = tags.FirstOrDefault(tag => tagIDsForLabel.Contains(tag.ContentID.ToString()));
			}


			var viewModel = new
			{
				key = this.ContentID,
				image = this.PartnerLogo?.ToImage(),
				label = c_tag?.Title,
				resourceTypeID = c_tag?.ContentID,
				title = this.Title,
				text = this.Excerpt.Truncate(75, "...", true, true),
				url = this.ResolveDynamicPageItemUrl()
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
				title = this.Title,
				excerpt = excerpt,
				date = this.Date,
				author = author.ToFrontendProps(),
				url = this.ResolveDynamicPageItemUrl(),
				image = image.ToImage()

			};

			return post;

		}
	}

	public partial class Podcast
	{

		public dynamic GetListingViewModel(int excerptLength = 240)
		{


			string excerpt = System.Web.HttpUtility.HtmlDecode(this.Excerpt.Truncate(excerptLength, "...", true, true));

			var item = new
			{
				key = ContentID,
				title = Title,
				excerpt = excerpt,
				date = this.Date,
				url = this.ResolveDynamicPageItemUrl(),
				episodeNumber = this.EpisodeNumber,
				image = MainImage.ToImage()

			};

			return item;

		}

	}
}