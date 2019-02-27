using Agility.Web.Extensions;

namespace Website.Extensions
{
    public static class StringExtensions
    {
        public static UrlField ParseUrl(this string str)
        {
            UrlField link;

            if(string.IsNullOrEmpty(str)) {
                return null;
            }

            if (str.StartsWith("~/") || str.StartsWith("/") || str.StartsWith("http"))
            {
                link = new UrlField {Href = str};
            }
            else
            {
                try
                {
                    link = new UrlField {Text = str.StripHtml()};

                    var parts = str.ToStrings('>');
                    var qs = parts[0].Replace("<a ", "").Replace(" ", "&").Replace("\"", "");
                    var properties = System.Web.HttpUtility.ParseQueryString(qs);

                    link.Target = properties["target"];
                    link.Href = properties["href"];
                }
                catch (System.Exception ex)
                {
                    link = null;
                }
            }
            return link;
        }

    }
}