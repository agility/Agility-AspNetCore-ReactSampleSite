using System;
using Agility.Web.Objects;
namespace Website.Models
{
	public class Image
	{
        public Image() {}
        public Image(Attachment attachment) {
            if(attachment != null) {
                Url = attachment.URL;
                Label = attachment.Label;
            }
        }
		public string Url { get; set; }
        public string Label {get;set;}
	}
}