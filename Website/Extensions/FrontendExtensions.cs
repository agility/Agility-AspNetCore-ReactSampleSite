using Agility.Web;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Web;
using Website.Models;
using Agility.Web.Objects;

namespace Website.Extensions
{
    public static class FrontendExtensions
    {
        /// <summary>
        /// List of properties to ignore in the object
        /// </summary>
        public static List<string> PropsToIgnore = new List<string>()
        {
            "CreatedDate",
            "ModifiedDate",
            "ReleaseDate",
            "PullDate",
            "State",
            "LanguageCode",
            "VersionID",
            "ContentID",
            "EnablePersonalization",
            "Tags",
            "Row",
            "ContentReferenceName",
            "Item",
            "Username",
            "ItemOrder",
            "ItemCreatedDate",
            "ManagerID",
            "Guid",
            "Blob",
            "FileName",
            "FileSize"
        };


        /// <summary>
        /// Converts object into a dynamic ExpandoObject so additional properties can be added easily. Optionally set a "Key" field for use in the frontend.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static dynamic ToFrontendProps(this object o, string keyField = "ContentID")
        {
            //convert to expando object
            var result = new ExpandoObject() as IDictionary<string, Object>;
            foreach (var col in o.GetType().GetProperties())
            {
                if(col.GetIndexParameters().Length > 0) {
                    continue;
                }

                var objValue = col.GetValue(o);

                if(objValue is Attachment) {
                    objValue = (objValue as Attachment).ToImage();
                }

                result.Add(col.Name, objValue);
            }
            
            if(result == null || result.Count == 0) {
                return o;
            }

            //set a key if we can
            SetKey(result, keyField);
            
            //remove unwanted props
            IgnoreProps(result);

            return result;
        }

        /// <summary>
        /// Converts AgilityContentItem into a dynamic ExpandoObject so additional properties can be added easily. Sets a "Key" field use in the frontend. Defaults to "ContentID".
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static dynamic ToFrontendProps(this AgilityContentItem ci, string keyField = "ContentID")
        {
            //convert to expando object
            var o = ci.ToDynamic(removeHrefTilde: true) as IDictionary<string, Object>;

            //set a key if we can
            SetKey(o, keyField);

            //remove unwanted props
            IgnoreProps(o);

            return o;
        }

        public static Image ToImage(this Attachment attachment) {
            return new Image(attachment);
        }

        /// <summary>
        /// Adds a "Key" field an Expando Object by the key field name.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="keyField"></param>
        private static void SetKey(IDictionary<string, Object> o, string keyField)
        {
            if (!string.IsNullOrEmpty(keyField) && o.ContainsKey(keyField))
            {
                o.Add("Key", o[keyField]);
            }
        }

        /// <summary>
        /// Remove properties from the dynamic object
        /// </summary>
        /// <param name="o"></param>
        private static void IgnoreProps(IDictionary<string, Object> o)
        {
            foreach(var propName in PropsToIgnore)
            {
                if(o.ContainsKey(propName))
                {
                    o.Remove(propName);
                }
            }
        }

    }
}