using Agility.Web;
using Agility.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Website.Extensions
{
    public static class AgilityContentItemExtensions
    {
        private static bool IsAnchorTag(string value)
        {
            //test for anchor tag
            return value.StartsWith("<a href") && value.EndsWith("</a>");
        }

        private static UrlField RemoveTilde(this UrlField urlField)
        {
            if (!string.IsNullOrEmpty(urlField.Href))
            {
                urlField.Href = urlField.Href.Replace("~", "");
            }
            return urlField;
        }

        public static dynamic ToDynamic(this AgilityContentItem ci, bool removeHrefTilde = false)
        {
            var dynamicObj = new ExpandoObject() as IDictionary<string, Object>;


            //write each column into our dynamic obj
            foreach (var col in ci.GetType().GetProperties())
            {
                if(col.GetIndexParameters().Length > 0) {
                    continue;
                }
                string colName = col.Name;
                var objValue = ci.GetType().GetProperty(colName).GetValue(ci, null);
                
                //specific cases with a string
                if (objValue is string)
                {

                    //test whether this is a UrlField
                    if (IsAnchorTag(objValue as string))
                    {
                        if (removeHrefTilde)
                        {
                            objValue = ci.ParseUrl(colName).RemoveTilde();
                        } else
                        {
                            objValue = ci.ParseUrl(colName);
                        }
                    }
                }

                dynamicObj.Add(colName, objValue);
            }

            return dynamicObj;
        }
    }
}