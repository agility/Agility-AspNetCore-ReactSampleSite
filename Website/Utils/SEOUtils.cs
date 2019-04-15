using System.Text;
using Agility.Web.Objects;

namespace Website.Utils
{

	public static class SEOUtils
	{

		public static string GetRawMetaTags(string existingRawTags, string title, string canonicalUrl, string category, string description, Attachment image)
		{


			StringBuilder sb = new StringBuilder();

			if (!existingRawTags.Contains("og:title"))
			{
				sb.AppendFormat("<meta property=\"og:title\" content=\"{0}\" />", title);
			}

			if (!existingRawTags.Contains("og:type"))
			{
				sb.AppendFormat("<meta property=\"og:type\" content=\"{0}\" />", "article");
			}

			if (!existingRawTags.Contains("og:category"))
			{
				sb.AppendFormat("<meta property=\"og:category\" content=\"{0}\" />", category);
			}


			if (!existingRawTags.Contains("og:description"))
			{
				sb.AppendFormat("<meta property=\"og:description\" content=\"{0}\" />", description);
			}

			if (!existingRawTags.Contains("og:site_name"))
			{
				sb.AppendFormat("<meta property=\"og:site_name\" content=\"{0}\" />", "Agility");
			}

			if (image != null && !existingRawTags.Contains("og:image"))
			{
				sb.AppendFormat("<meta property=\"og:image\" content=\"{0}\" />", image.URL);

				if (image.Width > 0)
				{
					sb.AppendFormat("<meta property=\"og:image:width\" content=\"{0}\" />", image.Width);
				}

				if (image.Height > 0)
				{
					sb.AppendFormat("<meta property=\"og:image:width\" content=\"{0}\" />", image.Height);
				}
			}

			
			sb.AppendLine(existingRawTags);

			return sb.ToString();

		}

	}

}