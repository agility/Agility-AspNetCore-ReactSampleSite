using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agility.Web;
using Agility.Web.Objects;

namespace Website.AgilityModels
{
	public partial class AgilityCodeTemplate : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __referencename = null;
		private bool __referencename_set = false;
		public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true;  } }
		private bool __visible;
		private bool __visible_set = false;
		public virtual bool Visible { get { if (!__visible_set) __visible = GetFieldValue<bool>("Visible"); __visible_set = true; return __visible; } set { __visible = value; __visible_set = true;  } }

	}
	public partial class AgilityCSS : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __referencename = null;
		private bool __referencename_set = false;
		public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true;  } }
		private bool __minify;
		private bool __minify_set = false;
		public virtual bool Minify { get { if (!__minify_set) __minify = GetFieldValue<bool>("Minify"); __minify_set = true; return __minify; } set { __minify = value; __minify_set = true;  } }

	}
	public partial class AgilityJavascript : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __referencename = null;
		private bool __referencename_set = false;
		public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true;  } }
		private bool __minify;
		private bool __minify_set = false;
		public virtual bool Minify { get { if (!__minify_set) __minify = GetFieldValue<bool>("Minify"); __minify_set = true; return __minify; } set { __minify = value; __minify_set = true;  } }

	}
	public partial class BlogAuthor : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __jobtitle = null;
		private bool __jobtitle_set = false;
		public virtual string JobTitle { get { if (!__jobtitle_set) __jobtitle = GetFieldValue<string>("JobTitle"); __jobtitle_set = true; return __jobtitle; } set { __jobtitle = value; __jobtitle_set = true;  } }
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }

	}
	public partial class BlogCategory : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }

	}
	public partial class BlogPost : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true;  } }
		private int __authorid;
		private bool __authorid_set = false;
		public virtual int AuthorID { get { if (!__authorid_set) __authorid = GetFieldValue<int>("AuthorID"); __authorid_set = true; return __authorid; } set { __authorid = value; __authorid_set = true;  } }
		private string __authortitle = null;
		private bool __authortitle_set = false;
		public virtual string AuthorTitle { get { if (!__authortitle_set) __authortitle = GetFieldValue<string>("AuthorTitle"); __authortitle_set = true; return __authortitle; } set { __authortitle = value; __authortitle_set = true;  } }
		private IAgilityContentRepository<BlogAuthor> __author = null;
		public virtual IAgilityContentRepository<BlogAuthor> Author { get { if (__author == null) __author = GetLinkedContent<BlogAuthor>("Author"); return __author; } set { __author = value; }}
		private bool __enablecomments;
		private bool __enablecomments_set = false;
		public virtual bool EnableComments { get { if (!__enablecomments_set) __enablecomments = GetFieldValue<bool>("EnableComments"); __enablecomments_set = true; return __enablecomments; } set { __enablecomments = value; __enablecomments_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true;  } }
		private Attachment __postimage = null;
		public virtual Attachment PostImage { get {  if (__postimage == null) __postimage = GetAttachment("PostImage"); return __postimage; } set { __postimage = value; } }
		private bool __displayimageinpost;
		private bool __displayimageinpost_set = false;
		public virtual bool DisplayImageinPost { get { if (!__displayimageinpost_set) __displayimageinpost = GetFieldValue<bool>("DisplayImageinPost"); __displayimageinpost_set = true; return __displayimageinpost; } set { __displayimageinpost = value; __displayimageinpost_set = true;  } }
		private Attachment __listingimageoverride = null;
		public virtual Attachment ListingImageOverride { get {  if (__listingimageoverride == null) __listingimageoverride = GetAttachment("ListingImageOverride"); return __listingimageoverride; } set { __listingimageoverride = value; } }
		private string __categoriesids = null;
		private bool __categoriesids_set = false;
		public virtual string CategoriesIDs { get { if (!__categoriesids_set) __categoriesids = GetFieldValue<string>("CategoriesIDs"); __categoriesids_set = true; return __categoriesids; } set { __categoriesids = value; __categoriesids_set = true;  } }
		private string __categoriestitle = null;
		private bool __categoriestitle_set = false;
		public virtual string CategoriesTitle { get { if (!__categoriestitle_set) __categoriestitle = GetFieldValue<string>("CategoriesTitle"); __categoriestitle_set = true; return __categoriestitle; } set { __categoriestitle = value; __categoriestitle_set = true;  } }
		private IAgilityContentRepository<BlogCategory> __categories = null;
		public virtual IAgilityContentRepository<BlogCategory> Categories { get { if (__categories == null) __categories = GetLinkedContent<BlogCategory>("Categories"); return __categories; } set { __categories = value; }}
		private string __blogtagsids = null;
		private bool __blogtagsids_set = false;
		public virtual string BlogTagsIDs { get { if (!__blogtagsids_set) __blogtagsids = GetFieldValue<string>("BlogTagsIDs"); __blogtagsids_set = true; return __blogtagsids; } set { __blogtagsids = value; __blogtagsids_set = true;  } }
		private string __blogtagstitle = null;
		private bool __blogtagstitle_set = false;
		public virtual string BlogTagsTitle { get { if (!__blogtagstitle_set) __blogtagstitle = GetFieldValue<string>("BlogTagsTitle"); __blogtagstitle_set = true; return __blogtagstitle; } set { __blogtagstitle = value; __blogtagstitle_set = true;  } }
		private IAgilityContentRepository<BlogTag> __blogtags = null;
		public virtual IAgilityContentRepository<BlogTag> BlogTags { get { if (__blogtags == null) __blogtags = GetLinkedContent<BlogTag>("BlogTags"); return __blogtags; } set { __blogtags = value; }}
		private string __relatepostsby = null;
		private bool __relatepostsby_set = false;
		public virtual string RelatePostsBy { get { if (!__relatepostsby_set) __relatepostsby = GetFieldValue<string>("RelatePostsBy"); __relatepostsby_set = true; return __relatepostsby; } set { __relatepostsby = value; __relatepostsby_set = true;  } }
		private IAgilityContentRepository<BlogPost> __relatedposts = null;
		public virtual IAgilityContentRepository<BlogPost> RelatedPosts { get { if (__relatedposts == null) __relatedposts = GetLinkedContent<BlogPost>("RelatedPosts", "", "itemOrder ", ""); return __relatedposts; } set { __relatedposts = value; }}
		private string __relatedpostsids = null;
		private bool __relatedpostsids_set = false;
		public virtual string RelatedPostsIDs { get { if (!__relatedpostsids_set) __relatedpostsids = GetFieldValue<string>("RelatedPostsIDs"); __relatedpostsids_set = true; return __relatedpostsids; } set { __relatedpostsids = value; __relatedpostsids_set = true;  } }
		private string __relatedposttitles = null;
		private bool __relatedposttitles_set = false;
		public virtual string RelatedPostTitles { get { if (!__relatedposttitles_set) __relatedposttitles = GetFieldValue<string>("RelatedPostTitles"); __relatedposttitles_set = true; return __relatedposttitles; } set { __relatedposttitles = value; __relatedposttitles_set = true;  } }

	}
	public partial class BlogTag : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }

	}
	public partial class CalloutItem : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __caption = null;
		private bool __caption_set = false;
		public virtual string Caption { get { if (!__caption_set) __caption = GetFieldValue<string>("Caption"); __caption_set = true; return __caption; } set { __caption = value; __caption_set = true;  } }
		private string __link = null;
		private bool __link_set = false;
		public virtual string Link { get { if (!__link_set) __link = GetFieldValue<string>("Link"); __link_set = true; return __link; } set { __link = value; __link_set = true;  } }

	}
	public partial class CaseStudy : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private Attachment __customerlogo = null;
		public virtual Attachment CustomerLogo { get {  if (__customerlogo == null) __customerlogo = GetAttachment("CustomerLogo"); return __customerlogo; } set { __customerlogo = value; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true;  } }
		private string __rightcontentcopy = null;
		private bool __rightcontentcopy_set = false;
		public virtual string RightContentCopy { get { if (!__rightcontentcopy_set) __rightcontentcopy = GetFieldValue<string>("RightContentCopy"); __rightcontentcopy_set = true; return __rightcontentcopy; } set { __rightcontentcopy = value; __rightcontentcopy_set = true;  } }
		private string __quote = null;
		private bool __quote_set = false;
		public virtual string Quote { get { if (!__quote_set) __quote = GetFieldValue<string>("Quote"); __quote_set = true; return __quote; } set { __quote = value; __quote_set = true;  } }
		private IAgilityContentRepository<KeyValuePair> __metrics = null;
		public virtual IAgilityContentRepository<KeyValuePair> Metrics { get { if (__metrics == null) __metrics = GetLinkedContent<KeyValuePair>("Metrics"); return __metrics; } set { __metrics = value; }}
		private string __contentpanelcopy = null;
		private bool __contentpanelcopy_set = false;
		public virtual string ContentPanelCopy { get { if (!__contentpanelcopy_set) __contentpanelcopy = GetFieldValue<string>("ContentPanelCopy"); __contentpanelcopy_set = true; return __contentpanelcopy; } set { __contentpanelcopy = value; __contentpanelcopy_set = true;  } }
		private string __brandfgcolor = null;
		private bool __brandfgcolor_set = false;
		public virtual string BrandFGColor { get { if (!__brandfgcolor_set) __brandfgcolor = GetFieldValue<string>("BrandFGColor"); __brandfgcolor_set = true; return __brandfgcolor; } set { __brandfgcolor = value; __brandfgcolor_set = true;  } }
		private string __brandbgcolor = null;
		private bool __brandbgcolor_set = false;
		public virtual string BrandBGColor { get { if (!__brandbgcolor_set) __brandbgcolor = GetFieldValue<string>("BrandBGColor"); __brandbgcolor_set = true; return __brandbgcolor; } set { __brandbgcolor = value; __brandbgcolor_set = true;  } }
		private string __imageposition = null;
		private bool __imageposition_set = false;
		public virtual string ImagePosition { get { if (!__imageposition_set) __imageposition = GetFieldValue<string>("ImagePosition"); __imageposition_set = true; return __imageposition; } set { __imageposition = value; __imageposition_set = true;  } }
		private string __productsheading = null;
		private bool __productsheading_set = false;
		public virtual string ProductsHeading { get { if (!__productsheading_set) __productsheading = GetFieldValue<string>("ProductsHeading"); __productsheading_set = true; return __productsheading; } set { __productsheading = value; __productsheading_set = true;  } }
		private string __productssubheading = null;
		private bool __productssubheading_set = false;
		public virtual string ProductsSubHeading { get { if (!__productssubheading_set) __productssubheading = GetFieldValue<string>("ProductsSubHeading"); __productssubheading_set = true; return __productssubheading; } set { __productssubheading = value; __productssubheading_set = true;  } }
		private IAgilityContentRepository<CaseStudyProduct> __products = null;
		public virtual IAgilityContentRepository<CaseStudyProduct> Products { get { if (__products == null) __products = GetLinkedContent<CaseStudyProduct>("Products"); return __products; } set { __products = value; }}
		private string __productids = null;
		private bool __productids_set = false;
		public virtual string ProductIDs { get { if (!__productids_set) __productids = GetFieldValue<string>("ProductIDs"); __productids_set = true; return __productids; } set { __productids = value; __productids_set = true;  } }
		private string __productnames = null;
		private bool __productnames_set = false;
		public virtual string ProductNames { get { if (!__productnames_set) __productnames = GetFieldValue<string>("ProductNames"); __productnames_set = true; return __productnames; } set { __productnames = value; __productnames_set = true;  } }
		private string __productsrendertype = null;
		private bool __productsrendertype_set = false;
		public virtual string ProductsRenderType { get { if (!__productsrendertype_set) __productsrendertype = GetFieldValue<string>("ProductsRenderType"); __productsrendertype_set = true; return __productsrendertype; } set { __productsrendertype = value; __productsrendertype_set = true;  } }

	}
	public partial class CaseStudyProduct : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private Attachment __logo = null;
		public virtual Attachment Logo { get {  if (__logo == null) __logo = GetAttachment("Logo"); return __logo; } set { __logo = value; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }

	}
	public partial class ContentPanel : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __labelinternal = null;
		private bool __labelinternal_set = false;
		public virtual string LabelInternal { get { if (!__labelinternal_set) __labelinternal = GetFieldValue<string>("LabelInternal"); __labelinternal_set = true; return __labelinternal; } set { __labelinternal = value; __labelinternal_set = true;  } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true;  } }
		private string __secondarybutton = null;
		private bool __secondarybutton_set = false;
		public virtual string SecondaryButton { get { if (!__secondarybutton_set) __secondarybutton = GetFieldValue<string>("SecondaryButton"); __secondarybutton_set = true; return __secondarybutton; } set { __secondarybutton = value; __secondarybutton_set = true;  } }
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __imageposition = null;
		private bool __imageposition_set = false;
		public virtual string ImagePosition { get { if (!__imageposition_set) __imageposition = GetFieldValue<string>("ImagePosition"); __imageposition_set = true; return __imageposition; } set { __imageposition = value; __imageposition_set = true;  } }
		private bool __enablebackgroundimage;
		private bool __enablebackgroundimage_set = false;
		public virtual bool EnableBackgroundImage { get { if (!__enablebackgroundimage_set) __enablebackgroundimage = GetFieldValue<bool>("EnableBackgroundImage"); __enablebackgroundimage_set = true; return __enablebackgroundimage; } set { __enablebackgroundimage = value; __enablebackgroundimage_set = true;  } }

	}
	public partial class CTABlock : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string Subtitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("Subtitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __link = null;
		private bool __link_set = false;
		public virtual string Link { get { if (!__link_set) __link = GetFieldValue<string>("Link"); __link_set = true; return __link; } set { __link = value; __link_set = true;  } }

	}
	public partial class CustomTag : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }

	}
	public partial class DynamicPageMapping : Agility.Web.AgilityContentItem
	{
		private string __dynamicpagereferencename = null;
		private bool __dynamicpagereferencename_set = false;
		public virtual string DynamicPageReferenceName { get { if (!__dynamicpagereferencename_set) __dynamicpagereferencename = GetFieldValue<string>("DynamicPageReferenceName"); __dynamicpagereferencename_set = true; return __dynamicpagereferencename; } set { __dynamicpagereferencename = value; __dynamicpagereferencename_set = true;  } }
		private string __dynamicpagepath = null;
		private bool __dynamicpagepath_set = false;
		public virtual string DynamicPagePath { get { if (!__dynamicpagepath_set) __dynamicpagepath = GetFieldValue<string>("DynamicPagePath"); __dynamicpagepath_set = true; return __dynamicpagepath; } set { __dynamicpagepath = value; __dynamicpagepath_set = true;  } }

	}
	public partial class Event : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private IAgilityContentRepository<EventType> __eventtype = null;
		public virtual IAgilityContentRepository<EventType> EventType { get { if (__eventtype == null) __eventtype = GetLinkedContent<EventType>("EventType"); return __eventtype; } set { __eventtype = value; }}
		private int __eventtypeid;
		private bool __eventtypeid_set = false;
		public virtual int EventTypeID { get { if (!__eventtypeid_set) __eventtypeid = GetFieldValue<int>("EventTypeID"); __eventtypeid_set = true; return __eventtypeid; } set { __eventtypeid = value; __eventtypeid_set = true;  } }
		private string __eventtypename = null;
		private bool __eventtypename_set = false;
		public virtual string EventTypeName { get { if (!__eventtypename_set) __eventtypename = GetFieldValue<string>("EventTypeName"); __eventtypename_set = true; return __eventtypename; } set { __eventtypename = value; __eventtypename_set = true;  } }
		private int __organizerid;
		private bool __organizerid_set = false;
		public virtual int OrganizerID { get { if (!__organizerid_set) __organizerid = GetFieldValue<int>("OrganizerID"); __organizerid_set = true; return __organizerid; } set { __organizerid = value; __organizerid_set = true;  } }
		private string __organizername = null;
		private bool __organizername_set = false;
		public virtual string OrganizerName { get { if (!__organizername_set) __organizername = GetFieldValue<string>("OrganizerName"); __organizername_set = true; return __organizername; } set { __organizername = value; __organizername_set = true;  } }
		private IAgilityContentRepository<BlogAuthor> __organizer = null;
		public virtual IAgilityContentRepository<BlogAuthor> Organizer { get { if (__organizer == null) __organizer = GetLinkedContent<BlogAuthor>("Organizer"); return __organizer; } set { __organizer = value; }}
		private string __address = null;
		private bool __address_set = false;
		public virtual string Address { get { if (!__address_set) __address = GetFieldValue<string>("Address"); __address_set = true; return __address; } set { __address = value; __address_set = true;  } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true;  } }
		private string __externallink = null;
		private bool __externallink_set = false;
		public virtual string ExternalLink { get { if (!__externallink_set) __externallink = GetFieldValue<string>("ExternalLink"); __externallink_set = true; return __externallink; } set { __externallink = value; __externallink_set = true;  } }
		private Attachment __thumbnail = null;
		public virtual Attachment Thumbnail { get {  if (__thumbnail == null) __thumbnail = GetAttachment("Thumbnail"); return __thumbnail; } set { __thumbnail = value; } }
		private string __description = null;
		private bool __description_set = false;
		public virtual string Description { get { if (!__description_set) __description = GetFieldValue<string>("Description"); __description_set = true; return __description; } set { __description = value; __description_set = true;  } }

	}
	public partial class EventType : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }

	}
	public partial class FaqItem : Agility.Web.AgilityContentItem
	{
		private string __question = null;
		private bool __question_set = false;
		public virtual string Question { get { if (!__question_set) __question = GetFieldValue<string>("Question"); __question_set = true; return __question; } set { __question = value; __question_set = true;  } }
		private string __answer = null;
		private bool __answer_set = false;
		public virtual string Answer { get { if (!__answer_set) __answer = GetFieldValue<string>("Answer"); __answer_set = true; return __answer; } set { __answer = value; __answer_set = true;  } }

	}
	public partial class FeatureBlock : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private Attachment __icon = null;
		public virtual Attachment Icon { get {  if (__icon == null) __icon = GetAttachment("Icon"); return __icon; } set { __icon = value; } }
		private string __bottomlink = null;
		private bool __bottomlink_set = false;
		public virtual string BottomLink { get { if (!__bottomlink_set) __bottomlink = GetFieldValue<string>("BottomLink"); __bottomlink_set = true; return __bottomlink; } set { __bottomlink = value; __bottomlink_set = true;  } }
		private string __customtagsids = null;
		private bool __customtagsids_set = false;
		public virtual string CustomTagsIDs { get { if (!__customtagsids_set) __customtagsids = GetFieldValue<string>("CustomTagsIDs"); __customtagsids_set = true; return __customtagsids; } set { __customtagsids = value; __customtagsids_set = true;  } }
		private IAgilityContentRepository<CustomTag> __customtags = null;
		public virtual IAgilityContentRepository<CustomTag> CustomTags { get { if (__customtags == null) __customtags = GetLinkedContent<CustomTag>("CustomTags"); return __customtags; } set { __customtags = value; }}

	}
	public partial class GlobalFooter : Agility.Web.AgilityContentItem
	{
		private string __column1title = null;
		private bool __column1title_set = false;
		public virtual string Column1Title { get { if (!__column1title_set) __column1title = GetFieldValue<string>("Column1Title"); __column1title_set = true; return __column1title; } set { __column1title = value; __column1title_set = true;  } }
		private IAgilityContentRepository<Link> __column1links = null;
		public virtual IAgilityContentRepository<Link> Column1Links { get { if (__column1links == null) __column1links = GetLinkedContent<Link>("Column1Links", "", "ItemOrder ", ""); return __column1links; } set { __column1links = value; }}
		private string __column1sortids = null;
		private bool __column1sortids_set = false;
		public virtual string Column1SortIDs { get { if (!__column1sortids_set) __column1sortids = GetFieldValue<string>("Column1SortIDs"); __column1sortids_set = true; return __column1sortids; } set { __column1sortids = value; __column1sortids_set = true;  } }
		private string __column2title = null;
		private bool __column2title_set = false;
		public virtual string Column2Title { get { if (!__column2title_set) __column2title = GetFieldValue<string>("Column2Title"); __column2title_set = true; return __column2title; } set { __column2title = value; __column2title_set = true;  } }
		private string __column2sortids = null;
		private bool __column2sortids_set = false;
		public virtual string Column2SortIDs { get { if (!__column2sortids_set) __column2sortids = GetFieldValue<string>("Column2SortIDs"); __column2sortids_set = true; return __column2sortids; } set { __column2sortids = value; __column2sortids_set = true;  } }
		private IAgilityContentRepository<Link> __column2links = null;
		public virtual IAgilityContentRepository<Link> Column2Links { get { if (__column2links == null) __column2links = GetLinkedContent<Link>("Column2Links", "", "ItemOrder ", ""); return __column2links; } set { __column2links = value; }}
		private string __column3title = null;
		private bool __column3title_set = false;
		public virtual string Column3Title { get { if (!__column3title_set) __column3title = GetFieldValue<string>("Column3Title"); __column3title_set = true; return __column3title; } set { __column3title = value; __column3title_set = true;  } }
		private string __column3sortids = null;
		private bool __column3sortids_set = false;
		public virtual string Column3SortIDs { get { if (!__column3sortids_set) __column3sortids = GetFieldValue<string>("Column3SortIDs"); __column3sortids_set = true; return __column3sortids; } set { __column3sortids = value; __column3sortids_set = true;  } }
		private IAgilityContentRepository<Link> __column3links = null;
		public virtual IAgilityContentRepository<Link> Column3Links { get { if (__column3links == null) __column3links = GetLinkedContent<Link>("Column3Links", "", "ItemOrder ", ""); return __column3links; } set { __column3links = value; }}
		private string __followtitle = null;
		private bool __followtitle_set = false;
		public virtual string FollowTitle { get { if (!__followtitle_set) __followtitle = GetFieldValue<string>("FollowTitle"); __followtitle_set = true; return __followtitle; } set { __followtitle = value; __followtitle_set = true;  } }
		private IAgilityContentRepository<SocialFollowLink> __followlinks = null;
		public virtual IAgilityContentRepository<SocialFollowLink> FollowLinks { get { if (__followlinks == null) __followlinks = GetLinkedContent<SocialFollowLink>("FollowLinks", "", "ItemOrder ", ""); return __followlinks; } set { __followlinks = value; }}
		private string __subscribetitle = null;
		private bool __subscribetitle_set = false;
		public virtual string SubscribeTitle { get { if (!__subscribetitle_set) __subscribetitle = GetFieldValue<string>("SubscribeTitle"); __subscribetitle_set = true; return __subscribetitle; } set { __subscribetitle = value; __subscribetitle_set = true;  } }
		private string __subscribedescription = null;
		private bool __subscribedescription_set = false;
		public virtual string SubscribeDescription { get { if (!__subscribedescription_set) __subscribedescription = GetFieldValue<string>("SubscribeDescription"); __subscribedescription_set = true; return __subscribedescription; } set { __subscribedescription = value; __subscribedescription_set = true;  } }
		private string __subscribeemailplaceholder = null;
		private bool __subscribeemailplaceholder_set = false;
		public virtual string SubscribeEmailPlaceholder { get { if (!__subscribeemailplaceholder_set) __subscribeemailplaceholder = GetFieldValue<string>("SubscribeEmailPlaceholder"); __subscribeemailplaceholder_set = true; return __subscribeemailplaceholder; } set { __subscribeemailplaceholder = value; __subscribeemailplaceholder_set = true;  } }
		private string __subscribebuttonlabel = null;
		private bool __subscribebuttonlabel_set = false;
		public virtual string SubscribeButtonLabel { get { if (!__subscribebuttonlabel_set) __subscribebuttonlabel = GetFieldValue<string>("SubscribeButtonLabel"); __subscribebuttonlabel_set = true; return __subscribebuttonlabel; } set { __subscribebuttonlabel = value; __subscribebuttonlabel_set = true;  } }
		private string __subscriberedirect = null;
		private bool __subscriberedirect_set = false;
		public virtual string SubscribeRedirect { get { if (!__subscriberedirect_set) __subscriberedirect = GetFieldValue<string>("SubscribeRedirect"); __subscriberedirect_set = true; return __subscriberedirect; } set { __subscriberedirect = value; __subscriberedirect_set = true;  } }
		private string __subscribeposturl = null;
		private bool __subscribeposturl_set = false;
		public virtual string SubscribePOSTUrl { get { if (!__subscribeposturl_set) __subscribeposturl = GetFieldValue<string>("SubscribePOSTUrl"); __subscribeposturl_set = true; return __subscribeposturl; } set { __subscribeposturl = value; __subscribeposturl_set = true;  } }
		private string __copyright = null;
		private bool __copyright_set = false;
		public virtual string Copyright { get { if (!__copyright_set) __copyright = GetFieldValue<string>("Copyright"); __copyright_set = true; return __copyright; } set { __copyright = value; __copyright_set = true;  } }
		private string __bottomlinkssortids = null;
		private bool __bottomlinkssortids_set = false;
		public virtual string BottomLinksSortIDs { get { if (!__bottomlinkssortids_set) __bottomlinkssortids = GetFieldValue<string>("BottomLinksSortIDs"); __bottomlinkssortids_set = true; return __bottomlinkssortids; } set { __bottomlinkssortids = value; __bottomlinkssortids_set = true;  } }
		private IAgilityContentRepository<Link> __bottomlinks = null;
		public virtual IAgilityContentRepository<Link> BottomLinks { get { if (__bottomlinks == null) __bottomlinks = GetLinkedContent<Link>("BottomLinks", "", "ItemOrder ", ""); return __bottomlinks; } set { __bottomlinks = value; }}

	}
	public partial class GlobalHeader : Agility.Web.AgilityContentItem
	{
		private string __preheaderprimarybutton = null;
		private bool __preheaderprimarybutton_set = false;
		public virtual string PreHeaderPrimaryButton { get { if (!__preheaderprimarybutton_set) __preheaderprimarybutton = GetFieldValue<string>("PreHeaderPrimaryButton"); __preheaderprimarybutton_set = true; return __preheaderprimarybutton; } set { __preheaderprimarybutton = value; __preheaderprimarybutton_set = true;  } }
		private IAgilityContentRepository<Link> __preheaderlinks = null;
		public virtual IAgilityContentRepository<Link> PreHeaderLinks { get { if (__preheaderlinks == null) __preheaderlinks = GetLinkedContent<Link>("PreHeaderLinks", "", "ItemOrder ", ""); return __preheaderlinks; } set { __preheaderlinks = value; }}
		private string __preheaderlinksortids = null;
		private bool __preheaderlinksortids_set = false;
		public virtual string PreHeaderLinkSortIDs { get { if (!__preheaderlinksortids_set) __preheaderlinksortids = GetFieldValue<string>("PreHeaderLinkSortIDs"); __preheaderlinksortids_set = true; return __preheaderlinksortids; } set { __preheaderlinksortids = value; __preheaderlinksortids_set = true;  } }
		private Attachment __logo = null;
		public virtual Attachment Logo { get {  if (__logo == null) __logo = GetAttachment("Logo"); return __logo; } set { __logo = value; } }
		private Attachment __mobilelogo = null;
		public virtual Attachment MobileLogo { get {  if (__mobilelogo == null) __mobilelogo = GetAttachment("MobileLogo"); return __mobilelogo; } set { __mobilelogo = value; } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true;  } }

	}
	public partial class Job : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private Attachment __icon = null;
		public virtual Attachment Icon { get {  if (__icon == null) __icon = GetAttachment("Icon"); return __icon; } set { __icon = value; } }
		private string __bottomlink = null;
		private bool __bottomlink_set = false;
		public virtual string BottomLink { get { if (!__bottomlink_set) __bottomlink = GetFieldValue<string>("BottomLink"); __bottomlink_set = true; return __bottomlink; } set { __bottomlink = value; __bottomlink_set = true;  } }

	}
	public partial class KeyValuePair : Agility.Web.AgilityContentItem
	{
		private string __key = null;
		private bool __key_set = false;
		public virtual string Key { get { if (!__key_set) __key = GetFieldValue<string>("Key"); __key_set = true; return __key; } set { __key = value; __key_set = true;  } }
		private string __value = null;
		private bool __value_set = false;
		public virtual string Value { get { if (!__value_set) __value = GetFieldValue<string>("Value"); __value_set = true; return __value; } set { __value = value; __value_set = true;  } }

	}
	public partial class Link : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }

	}
	public partial class Logo : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private Attachment ___logo = null;
		public virtual Attachment _Logo { get {  if (___logo == null) ___logo = GetAttachment("Logo"); return ___logo; } set { ___logo = value; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }

	}
	public partial class LogoTags : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }

	}
	public partial class Partner : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }
		private Attachment __partnerlogo = null;
		public virtual Attachment PartnerLogo { get {  if (__partnerlogo == null) __partnerlogo = GetAttachment("PartnerLogo"); return __partnerlogo; } set { __partnerlogo = value; } }
		private IAgilityContentRepository<CustomTag> __customtags = null;
		public virtual IAgilityContentRepository<CustomTag> CustomTags { get { if (__customtags == null) __customtags = GetLinkedContent<CustomTag>("CustomTags"); return __customtags; } set { __customtags = value; }}
		private string __customtagsids = null;
		private bool __customtagsids_set = false;
		public virtual string CustomTagsIDs { get { if (!__customtagsids_set) __customtagsids = GetFieldValue<string>("CustomTagsIDs"); __customtagsids_set = true; return __customtagsids; } set { __customtagsids = value; __customtagsids_set = true;  } }
		private string __customtagsnames = null;
		private bool __customtagsnames_set = false;
		public virtual string CustomTagsNames { get { if (!__customtagsnames_set) __customtagsnames = GetFieldValue<string>("CustomTagsNames"); __customtagsnames_set = true; return __customtagsnames; } set { __customtagsnames = value; __customtagsnames_set = true;  } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true;  } }
		private string __rightcontentcopy = null;
		private bool __rightcontentcopy_set = false;
		public virtual string RightContentCopy { get { if (!__rightcontentcopy_set) __rightcontentcopy = GetFieldValue<string>("RightContentCopy"); __rightcontentcopy_set = true; return __rightcontentcopy; } set { __rightcontentcopy = value; __rightcontentcopy_set = true;  } }
		private string __quote = null;
		private bool __quote_set = false;
		public virtual string Quote { get { if (!__quote_set) __quote = GetFieldValue<string>("Quote"); __quote_set = true; return __quote; } set { __quote = value; __quote_set = true;  } }
		private IAgilityContentRepository<KeyValuePair> __metrics = null;
		public virtual IAgilityContentRepository<KeyValuePair> Metrics { get { if (__metrics == null) __metrics = GetLinkedContent<KeyValuePair>("Metrics"); return __metrics; } set { __metrics = value; }}
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __contentpanelcopy = null;
		private bool __contentpanelcopy_set = false;
		public virtual string ContentPanelCopy { get { if (!__contentpanelcopy_set) __contentpanelcopy = GetFieldValue<string>("ContentPanelCopy"); __contentpanelcopy_set = true; return __contentpanelcopy; } set { __contentpanelcopy = value; __contentpanelcopy_set = true;  } }
		private string __brandfgcolor = null;
		private bool __brandfgcolor_set = false;
		public virtual string BrandFGColor { get { if (!__brandfgcolor_set) __brandfgcolor = GetFieldValue<string>("BrandFGColor"); __brandfgcolor_set = true; return __brandfgcolor; } set { __brandfgcolor = value; __brandfgcolor_set = true;  } }
		private string __brandbgcolor = null;
		private bool __brandbgcolor_set = false;
		public virtual string BrandBGColor { get { if (!__brandbgcolor_set) __brandbgcolor = GetFieldValue<string>("BrandBGColor"); __brandbgcolor_set = true; return __brandbgcolor; } set { __brandbgcolor = value; __brandbgcolor_set = true;  } }
		private string __imageposition = null;
		private bool __imageposition_set = false;
		public virtual string ImagePosition { get { if (!__imageposition_set) __imageposition = GetFieldValue<string>("ImagePosition"); __imageposition_set = true; return __imageposition; } set { __imageposition = value; __imageposition_set = true;  } }
		private string __productsheading = null;
		private bool __productsheading_set = false;
		public virtual string ProductsHeading { get { if (!__productsheading_set) __productsheading = GetFieldValue<string>("ProductsHeading"); __productsheading_set = true; return __productsheading; } set { __productsheading = value; __productsheading_set = true;  } }
		private string __productssubheading = null;
		private bool __productssubheading_set = false;
		public virtual string ProductsSubHeading { get { if (!__productssubheading_set) __productssubheading = GetFieldValue<string>("ProductsSubHeading"); __productssubheading_set = true; return __productssubheading; } set { __productssubheading = value; __productssubheading_set = true;  } }
		private IAgilityContentRepository<CaseStudyProduct> __products = null;
		public virtual IAgilityContentRepository<CaseStudyProduct> Products { get { if (__products == null) __products = GetLinkedContent<CaseStudyProduct>("Products"); return __products; } set { __products = value; }}
		private string __productids = null;
		private bool __productids_set = false;
		public virtual string ProductIDs { get { if (!__productids_set) __productids = GetFieldValue<string>("ProductIDs"); __productids_set = true; return __productids; } set { __productids = value; __productids_set = true;  } }
		private string __productnames = null;
		private bool __productnames_set = false;
		public virtual string ProductNames { get { if (!__productnames_set) __productnames = GetFieldValue<string>("ProductNames"); __productnames_set = true; return __productnames; } set { __productnames = value; __productnames_set = true;  } }
		private string __productsrendertype = null;
		private bool __productsrendertype_set = false;
		public virtual string ProductsRenderType { get { if (!__productsrendertype_set) __productsrendertype = GetFieldValue<string>("ProductsRenderType"); __productsrendertype_set = true; return __productsrendertype; } set { __productsrendertype = value; __productsrendertype_set = true;  } }

	}
	public partial class Person : Agility.Web.AgilityContentItem
	{
		private string __fullname = null;
		private bool __fullname_set = false;
		public virtual string FullName { get { if (!__fullname_set) __fullname = GetFieldValue<string>("FullName"); __fullname_set = true; return __fullname; } set { __fullname = value; __fullname_set = true;  } }
		private string __jobtitle = null;
		private bool __jobtitle_set = false;
		public virtual string JobTitle { get { if (!__jobtitle_set) __jobtitle = GetFieldValue<string>("JobTitle"); __jobtitle_set = true; return __jobtitle; } set { __jobtitle = value; __jobtitle_set = true;  } }
		private string __summary = null;
		private bool __summary_set = false;
		public virtual string Summary { get { if (!__summary_set) __summary = GetFieldValue<string>("Summary"); __summary_set = true; return __summary; } set { __summary = value; __summary_set = true;  } }
		private Attachment __headshot = null;
		public virtual Attachment Headshot { get {  if (__headshot == null) __headshot = GetAttachment("Headshot"); return __headshot; } set { __headshot = value; } }

	}
	public partial class Podcast : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private int __episodenumber;
		private bool __episodenumber_set = false;
		public virtual int EpisodeNumber { get { if (!__episodenumber_set) __episodenumber = GetFieldValue<int>("EpisodeNumber"); __episodenumber_set = true; return __episodenumber; } set { __episodenumber = value; __episodenumber_set = true;  } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true;  } }
		private string __guest = null;
		private bool __guest_set = false;
		public virtual string Guest { get { if (!__guest_set) __guest = GetFieldValue<string>("Guest"); __guest_set = true; return __guest; } set { __guest = value; __guest_set = true;  } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true;  } }
		private string __embed = null;
		private bool __embed_set = false;
		public virtual string Embed { get { if (!__embed_set) __embed = GetFieldValue<string>("Embed"); __embed_set = true; return __embed; } set { __embed = value; __embed_set = true;  } }
		private Attachment __mainimage = null;
		public virtual Attachment MainImage { get {  if (__mainimage == null) __mainimage = GetAttachment("MainImage"); return __mainimage; } set { __mainimage = value; } }
		private Attachment __listingimage = null;
		public virtual Attachment ListingImage { get {  if (__listingimage == null) __listingimage = GetAttachment("ListingImage"); return __listingimage; } set { __listingimage = value; } }

	}
	public partial class PricingPlan : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private bool __isrecommended;
		private bool __isrecommended_set = false;
		public virtual bool IsRecommended { get { if (!__isrecommended_set) __isrecommended = GetFieldValue<bool>("IsRecommended"); __isrecommended_set = true; return __isrecommended; } set { __isrecommended = value; __isrecommended_set = true;  } }
		private Attachment __icon = null;
		public virtual Attachment Icon { get {  if (__icon == null) __icon = GetAttachment("Icon"); return __icon; } set { __icon = value; } }
		private string __description = null;
		private bool __description_set = false;
		public virtual string Description { get { if (!__description_set) __description = GetFieldValue<string>("Description"); __description_set = true; return __description; } set { __description = value; __description_set = true;  } }
		private int __price;
		private bool __price_set = false;
		public virtual int Price { get { if (!__price_set) __price = GetFieldValue<int>("Price"); __price_set = true; return __price; } set { __price = value; __price_set = true;  } }
		private string __priceperunitlabel = null;
		private bool __priceperunitlabel_set = false;
		public virtual string PricePerUnitLabel { get { if (!__priceperunitlabel_set) __priceperunitlabel = GetFieldValue<string>("PricePerUnitLabel"); __priceperunitlabel_set = true; return __priceperunitlabel; } set { __priceperunitlabel = value; __priceperunitlabel_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string Subtitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("Subtitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private IAgilityContentRepository<PricingPlanFeature> __features = null;
		public virtual IAgilityContentRepository<PricingPlanFeature> Features { get { if (__features == null) __features = GetLinkedContent<PricingPlanFeature>("Features", "", "ItemOrder ", ""); return __features; } set { __features = value; }}
		private string __calltoaction = null;
		private bool __calltoaction_set = false;
		public virtual string CalltoAction { get { if (!__calltoaction_set) __calltoaction = GetFieldValue<string>("CalltoAction"); __calltoaction_set = true; return __calltoaction; } set { __calltoaction = value; __calltoaction_set = true;  } }
		private string __featuressortids = null;
		private bool __featuressortids_set = false;
		public virtual string FeaturesSortIDs { get { if (!__featuressortids_set) __featuressortids = GetFieldValue<string>("FeaturesSortIDs"); __featuressortids_set = true; return __featuressortids; } set { __featuressortids = value; __featuressortids_set = true;  } }

	}
	public partial class PricingPlanFeature : Agility.Web.AgilityContentItem
	{
		private string __label = null;
		private bool __label_set = false;
		public virtual string Label { get { if (!__label_set) __label = GetFieldValue<string>("Label"); __label_set = true; return __label; } set { __label = value; __label_set = true;  } }
		private string __value = null;
		private bool __value_set = false;
		public virtual string Value { get { if (!__value_set) __value = GetFieldValue<string>("Value"); __value_set = true; return __value; } set { __value = value; __value_set = true;  } }

	}
	public partial class Resource : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private int __authorid;
		private bool __authorid_set = false;
		public virtual int AuthorID { get { if (!__authorid_set) __authorid = GetFieldValue<int>("AuthorID"); __authorid_set = true; return __authorid; } set { __authorid = value; __authorid_set = true;  } }
		private string __authorname = null;
		private bool __authorname_set = false;
		public virtual string AuthorName { get { if (!__authorname_set) __authorname = GetFieldValue<string>("AuthorName"); __authorname_set = true; return __authorname; } set { __authorname = value; __authorname_set = true;  } }
		private IAgilityContentRepository<BlogAuthor> __author = null;
		public virtual IAgilityContentRepository<BlogAuthor> Author { get { if (__author == null) __author = GetLinkedContent<BlogAuthor>("Author"); return __author; } set { __author = value; }}
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true;  } }
		private int __resourcetypeid;
		private bool __resourcetypeid_set = false;
		public virtual int ResourceTypeID { get { if (!__resourcetypeid_set) __resourcetypeid = GetFieldValue<int>("ResourceTypeID"); __resourcetypeid_set = true; return __resourcetypeid; } set { __resourcetypeid = value; __resourcetypeid_set = true;  } }
		private string __resourcetypename = null;
		private bool __resourcetypename_set = false;
		public virtual string ResourceTypeName { get { if (!__resourcetypename_set) __resourcetypename = GetFieldValue<string>("ResourceTypeName"); __resourcetypename_set = true; return __resourcetypename; } set { __resourcetypename = value; __resourcetypename_set = true;  } }
		private IAgilityContentRepository<ResourceType> __resourcetype = null;
		public virtual IAgilityContentRepository<ResourceType> ResourceType { get { if (__resourcetype == null) __resourcetype = GetLinkedContent<ResourceType>("ResourceType"); return __resourcetype; } set { __resourcetype = value; }}
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true;  } }
		private Attachment __filedownload = null;
		public virtual Attachment FileDownload { get {  if (__filedownload == null) __filedownload = GetAttachment("FileDownload"); return __filedownload; } set { __filedownload = value; } }

	}
	public partial class ResourceType : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }

	}
	public partial class SiteSearchSettings : Agility.Web.AgilityContentItem
	{
		private string __searchproductpage = null;
		private bool __searchproductpage_set = false;
		public virtual string SearchProductPage { get { if (!__searchproductpage_set) __searchproductpage = GetFieldValue<string>("SearchProductPage"); __searchproductpage_set = true; return __searchproductpage; } set { __searchproductpage = value; __searchproductpage_set = true;  } }

	}
	public partial class SocialFollowLink : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private Attachment __logo = null;
		public virtual Attachment Logo { get {  if (__logo == null) __logo = GetAttachment("Logo"); return __logo; } set { __logo = value; } }
		private string __followurl = null;
		private bool __followurl_set = false;
		public virtual string FollowURL { get { if (!__followurl_set) __followurl = GetFieldValue<string>("FollowURL"); __followurl_set = true; return __followurl; } set { __followurl = value; __followurl_set = true;  } }

	}
	public partial class TabPanel : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __description = null;
		private bool __description_set = false;
		public virtual string Description { get { if (!__description_set) __description = GetFieldValue<string>("Description"); __description_set = true; return __description; } set { __description = value; __description_set = true;  } }
		private Attachment __image = null;
		public virtual Attachment Image { get {  if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true;  } }

	}
	public partial class Testimonial : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __jobtitle = null;
		private bool __jobtitle_set = false;
		public virtual string JobTitle { get { if (!__jobtitle_set) __jobtitle = GetFieldValue<string>("JobTitle"); __jobtitle_set = true; return __jobtitle; } set { __jobtitle = value; __jobtitle_set = true;  } }
		private string __companyname = null;
		private bool __companyname_set = false;
		public virtual string CompanyName { get { if (!__companyname_set) __companyname = GetFieldValue<string>("CompanyName"); __companyname_set = true; return __companyname; } set { __companyname = value; __companyname_set = true;  } }
		private Attachment __headshot = null;
		public virtual Attachment Headshot { get {  if (__headshot == null) __headshot = GetAttachment("Headshot"); return __headshot; } set { __headshot = value; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true;  } }

	}
	public partial class Module_Callout : Agility.Web.AgilityContentItem
	{
		private int __calloutid;
		private bool __calloutid_set = false;
		public virtual int CalloutID { get { if (!__calloutid_set) __calloutid = GetFieldValue<int>("CalloutID"); __calloutid_set = true; return __calloutid; } set { __calloutid = value; __calloutid_set = true;  } }
		private IAgilityContentRepository<CalloutItem> __callout = null;
		public virtual IAgilityContentRepository<CalloutItem> Callout { get { if (__callout == null) __callout = GetLinkedContent<CalloutItem>("Callout"); return __callout; } set { __callout = value; }}
		private string __theme = null;
		private bool __theme_set = false;
		public virtual string Theme { get { if (!__theme_set) __theme = GetFieldValue<string>("Theme"); __theme_set = true; return __theme; } set { __theme = value; __theme_set = true;  } }

	}
	public partial class Module_CaseStudyContentPanel : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<CaseStudy> __casestudies = null;
		public virtual IAgilityContentRepository<CaseStudy> CaseStudies { get { if (__casestudies == null) __casestudies = GetLinkedContent<CaseStudy>("CaseStudies"); return __casestudies; } set { __casestudies = value; }}

	}
	public partial class Module_CaseStudyDetails : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_CaseStudyListing : Agility.Web.AgilityContentItem
	{
		private int __casecount;
		private bool __casecount_set = false;
		public virtual int CaseCount { get { if (!__casecount_set) __casecount = GetFieldValue<int>("CaseCount"); __casecount_set = true; return __casecount; } set { __casecount = value; __casecount_set = true;  } }
		private IAgilityContentRepository<CaseStudy> __casestudies = null;
		public virtual IAgilityContentRepository<CaseStudy> CaseStudies { get { if (__casestudies == null) __casestudies = GetLinkedContent<CaseStudy>("CaseStudies"); return __casestudies; } set { __casestudies = value; }}

	}
	public partial class Module_CaseStudyTechStack : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_ContentPanel : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<ContentPanel> __panel = null;
		public virtual IAgilityContentRepository<ContentPanel> Panel { get { if (__panel == null) __panel = GetLinkedContent<ContentPanel>("Panel"); return __panel; } set { __panel = value; }}
		private int __panelid;
		private bool __panelid_set = false;
		public virtual int PanelID { get { if (!__panelid_set) __panelid = GetFieldValue<int>("PanelID"); __panelid_set = true; return __panelid; } set { __panelid = value; __panelid_set = true;  } }

	}
	public partial class Module_CTABlocks : Agility.Web.AgilityContentItem
	{
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true;  } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true;  } }
		private IAgilityContentRepository<CTABlock> __ctablocks = null;
		public virtual IAgilityContentRepository<CTABlock> CTABlocks { get { if (__ctablocks == null) __ctablocks = GetLinkedContent<CTABlock>("CTABlocks", "", "ItemOrder ", ""); return __ctablocks; } set { __ctablocks = value; }}

	}
	public partial class Module_EventListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private IAgilityContentRepository<EventType> __filterbytype = null;
		public virtual IAgilityContentRepository<EventType> FilterByType { get { if (__filterbytype == null) __filterbytype = GetLinkedContent<EventType>("FilterByType"); return __filterbytype; } set { __filterbytype = value; }}
		private int __filterbytypeid;
		private bool __filterbytypeid_set = false;
		public virtual int FilterByTypeID { get { if (!__filterbytypeid_set) __filterbytypeid = GetFieldValue<int>("FilterByTypeID"); __filterbytypeid_set = true; return __filterbytypeid; } set { __filterbytypeid = value; __filterbytypeid_set = true;  } }
		private bool __showpasteventsonly;
		private bool __showpasteventsonly_set = false;
		public virtual bool ShowPastEventsOnly { get { if (!__showpasteventsonly_set) __showpasteventsonly = GetFieldValue<bool>("ShowPastEventsOnly"); __showpasteventsonly_set = true; return __showpasteventsonly; } set { __showpasteventsonly = value; __showpasteventsonly_set = true;  } }
		private IAgilityContentRepository<Event> __events = null;
		public virtual IAgilityContentRepository<Event> Events { get { if (__events == null) __events = GetLinkedContent<Event>("Events", "", "Date ", ""); return __events; } set { __events = value; }}
		private string __viewdetailslabel = null;
		private bool __viewdetailslabel_set = false;
		public virtual string ViewDetailsLabel { get { if (!__viewdetailslabel_set) __viewdetailslabel = GetFieldValue<string>("ViewDetailsLabel"); __viewdetailslabel_set = true; return __viewdetailslabel; } set { __viewdetailslabel = value; __viewdetailslabel_set = true;  } }
		private string __backlabel = null;
		private bool __backlabel_set = false;
		public virtual string BackLabel { get { if (!__backlabel_set) __backlabel = GetFieldValue<string>("BackLabel"); __backlabel_set = true; return __backlabel; } set { __backlabel = value; __backlabel_set = true;  } }
		private string __registerlabel = null;
		private bool __registerlabel_set = false;
		public virtual string RegisterLabel { get { if (!__registerlabel_set) __registerlabel = GetFieldValue<string>("RegisterLabel"); __registerlabel_set = true; return __registerlabel; } set { __registerlabel = value; __registerlabel_set = true;  } }

	}
	public partial class Module_Faqs : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private IAgilityContentRepository<FaqItem> __faqs = null;
		public virtual IAgilityContentRepository<FaqItem> Faqs { get { if (__faqs == null) __faqs = GetLinkedContent<FaqItem>("Faqs", "", "Question ", ""); return __faqs; } set { __faqs = value; }}

	}
	public partial class Module_FeatureBlocks : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __featureblockids = null;
		private bool __featureblockids_set = false;
		public virtual string FeatureBlockIDs { get { if (!__featureblockids_set) __featureblockids = GetFieldValue<string>("FeatureBlockIDs"); __featureblockids_set = true; return __featureblockids; } set { __featureblockids = value; __featureblockids_set = true;  } }
		private string __featureblocknames = null;
		private bool __featureblocknames_set = false;
		public virtual string FeatureBlockNames { get { if (!__featureblocknames_set) __featureblocknames = GetFieldValue<string>("FeatureBlockNames"); __featureblocknames_set = true; return __featureblocknames; } set { __featureblocknames = value; __featureblocknames_set = true;  } }
		private IAgilityContentRepository<FeatureBlock> __featureblocks = null;
		public virtual IAgilityContentRepository<FeatureBlock> FeatureBlocks { get { if (__featureblocks == null) __featureblocks = GetLinkedContent<FeatureBlock>("FeatureBlocks", "", "Title ", ""); return __featureblocks; } set { __featureblocks = value; }}

	}
	public partial class Module_FeatureBlocksWithText : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __sidetitle = null;
		private bool __sidetitle_set = false;
		public virtual string SideTitle { get { if (!__sidetitle_set) __sidetitle = GetFieldValue<string>("SideTitle"); __sidetitle_set = true; return __sidetitle; } set { __sidetitle = value; __sidetitle_set = true;  } }
		private string __sidebody = null;
		private bool __sidebody_set = false;
		public virtual string SideBody { get { if (!__sidebody_set) __sidebody = GetFieldValue<string>("SideBody"); __sidebody_set = true; return __sidebody; } set { __sidebody = value; __sidebody_set = true;  } }
		private string __sidelink = null;
		private bool __sidelink_set = false;
		public virtual string SideLink { get { if (!__sidelink_set) __sidelink = GetFieldValue<string>("SideLink"); __sidelink_set = true; return __sidelink; } set { __sidelink = value; __sidelink_set = true;  } }
		private string __featureblockids = null;
		private bool __featureblockids_set = false;
		public virtual string FeatureBlockIDs { get { if (!__featureblockids_set) __featureblockids = GetFieldValue<string>("FeatureBlockIDs"); __featureblockids_set = true; return __featureblockids; } set { __featureblockids = value; __featureblockids_set = true;  } }
		private string __featureblocknames = null;
		private bool __featureblocknames_set = false;
		public virtual string FeatureBlockNames { get { if (!__featureblocknames_set) __featureblocknames = GetFieldValue<string>("FeatureBlockNames"); __featureblocknames_set = true; return __featureblocknames; } set { __featureblocknames = value; __featureblocknames_set = true;  } }
		private IAgilityContentRepository<FeatureBlock> __featureblocks = null;
		public virtual IAgilityContentRepository<FeatureBlock> FeatureBlocks { get { if (__featureblocks == null) __featureblocks = GetLinkedContent<FeatureBlock>("FeatureBlocks", "", "Title ", ""); return __featureblocks; } set { __featureblocks = value; }}

	}
	public partial class Module_FeatureListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string Subtitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("Subtitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private string __lefttypetitle = null;
		private bool __lefttypetitle_set = false;
		public virtual string LeftTypeTitle { get { if (!__lefttypetitle_set) __lefttypetitle = GetFieldValue<string>("LeftTypeTitle"); __lefttypetitle_set = true; return __lefttypetitle; } set { __lefttypetitle = value; __lefttypetitle_set = true;  } }
		private string __leftbutton = null;
		private bool __leftbutton_set = false;
		public virtual string LeftButton { get { if (!__leftbutton_set) __leftbutton = GetFieldValue<string>("LeftButton"); __leftbutton_set = true; return __leftbutton; } set { __leftbutton = value; __leftbutton_set = true;  } }
		private IAgilityContentRepository<FeatureBlock> __featureblocks = null;
		public virtual IAgilityContentRepository<FeatureBlock> FeatureBlocks { get { if (__featureblocks == null) __featureblocks = GetLinkedContent<FeatureBlock>("FeatureBlocks"); return __featureblocks; } set { __featureblocks = value; }}
		private string __customtagstohighlightids = null;
		private bool __customtagstohighlightids_set = false;
		public virtual string CustomTagsToHighlightIDs { get { if (!__customtagstohighlightids_set) __customtagstohighlightids = GetFieldValue<string>("CustomTagsToHighlightIDs"); __customtagstohighlightids_set = true; return __customtagstohighlightids; } set { __customtagstohighlightids = value; __customtagstohighlightids_set = true;  } }
		private IAgilityContentRepository<CustomTag> __customtagstohighlight = null;
		public virtual IAgilityContentRepository<CustomTag> CustomTagstoHighlight { get { if (__customtagstohighlight == null) __customtagstohighlight = GetLinkedContent<CustomTag>("CustomTagstoHighlight"); return __customtagstohighlight; } set { __customtagstohighlight = value; }}

	}
	public partial class Module_FeaturedCaseStudies : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true;  } }
		private string __ids = null;
		private bool __ids_set = false;
		public virtual string IDs { get { if (!__ids_set) __ids = GetFieldValue<string>("IDs"); __ids_set = true; return __ids; } set { __ids = value; __ids_set = true;  } }
		private string __names = null;
		private bool __names_set = false;
		public virtual string Names { get { if (!__names_set) __names = GetFieldValue<string>("Names"); __names_set = true; return __names; } set { __names = value; __names_set = true;  } }
		private IAgilityContentRepository<CaseStudy> __casestudies = null;
		public virtual IAgilityContentRepository<CaseStudy> CaseStudies { get { if (__casestudies == null) __casestudies = GetLinkedContent<CaseStudy>("CaseStudies", "", "Title ", ""); return __casestudies; } set { __casestudies = value; }}

	}
	public partial class Module_FeaturedResources : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private string __ids = null;
		private bool __ids_set = false;
		public virtual string IDs { get { if (!__ids_set) __ids = GetFieldValue<string>("IDs"); __ids_set = true; return __ids; } set { __ids = value; __ids_set = true;  } }
		private string __names = null;
		private bool __names_set = false;
		public virtual string Names { get { if (!__names_set) __names = GetFieldValue<string>("Names"); __names_set = true; return __names; } set { __names = value; __names_set = true;  } }
		private IAgilityContentRepository<Resource> __resources = null;
		public virtual IAgilityContentRepository<Resource> Resources { get { if (__resources == null) __resources = GetLinkedContent<Resource>("Resources"); return __resources; } set { __resources = value; }}
		private string __readmorelabel = null;
		private bool __readmorelabel_set = false;
		public virtual string ReadMoreLabel { get { if (!__readmorelabel_set) __readmorelabel = GetFieldValue<string>("ReadMoreLabel"); __readmorelabel_set = true; return __readmorelabel; } set { __readmorelabel = value; __readmorelabel_set = true;  } }

	}
	public partial class Module_FormBuilder : Agility.Web.AgilityContentItem
	{
		private string __recordtypename = null;
		private bool __recordtypename_set = false;
		public virtual string RecordTypeName { get { if (!__recordtypename_set) __recordtypename = GetFieldValue<string>("RecordTypeName"); __recordtypename_set = true; return __recordtypename; } set { __recordtypename = value; __recordtypename_set = true;  } }
		private string __responsetype = null;
		private bool __responsetype_set = false;
		public virtual string ResponseType { get { if (!__responsetype_set) __responsetype = GetFieldValue<string>("ResponseType"); __responsetype_set = true; return __responsetype; } set { __responsetype = value; __responsetype_set = true;  } }
		private string __thankyoutemplate = null;
		private bool __thankyoutemplate_set = false;
		public virtual string ThankYouTemplate { get { if (!__thankyoutemplate_set) __thankyoutemplate = GetFieldValue<string>("ThankYouTemplate"); __thankyoutemplate_set = true; return __thankyoutemplate; } set { __thankyoutemplate = value; __thankyoutemplate_set = true;  } }
		private string __redirecturl = null;
		private bool __redirecturl_set = false;
		public virtual string RedirectURL { get { if (!__redirecturl_set) __redirecturl = GetFieldValue<string>("RedirectURL"); __redirecturl_set = true; return __redirecturl; } set { __redirecturl = value; __redirecturl_set = true;  } }
		private bool __includecaptcha;
		private bool __includecaptcha_set = false;
		public virtual bool IncludeCaptcha { get { if (!__includecaptcha_set) __includecaptcha = GetFieldValue<bool>("IncludeCaptcha"); __includecaptcha_set = true; return __includecaptcha; } set { __includecaptcha = value; __includecaptcha_set = true;  } }
		private string __errortemplate = null;
		private bool __errortemplate_set = false;
		public virtual string ErrorTemplate { get { if (!__errortemplate_set) __errortemplate = GetFieldValue<string>("ErrorTemplate"); __errortemplate_set = true; return __errortemplate; } set { __errortemplate = value; __errortemplate_set = true;  } }
		private bool __submitasemail;
		private bool __submitasemail_set = false;
		public virtual bool SubmitasEmail { get { if (!__submitasemail_set) __submitasemail = GetFieldValue<bool>("SubmitasEmail"); __submitasemail_set = true; return __submitasemail; } set { __submitasemail = value; __submitasemail_set = true;  } }
		private string __emailsendto = null;
		private bool __emailsendto_set = false;
		public virtual string EmailSendTo { get { if (!__emailsendto_set) __emailsendto = GetFieldValue<string>("EmailSendTo"); __emailsendto_set = true; return __emailsendto; } set { __emailsendto = value; __emailsendto_set = true;  } }
		private string __emailfrom = null;
		private bool __emailfrom_set = false;
		public virtual string EmailFrom { get { if (!__emailfrom_set) __emailfrom = GetFieldValue<string>("EmailFrom"); __emailfrom_set = true; return __emailfrom; } set { __emailfrom = value; __emailfrom_set = true;  } }
		private string __emailsubjecttemplate = null;
		private bool __emailsubjecttemplate_set = false;
		public virtual string EmailSubjectTemplate { get { if (!__emailsubjecttemplate_set) __emailsubjecttemplate = GetFieldValue<string>("EmailSubjectTemplate"); __emailsubjecttemplate_set = true; return __emailsubjecttemplate; } set { __emailsubjecttemplate = value; __emailsubjecttemplate_set = true;  } }
		private string __emailbodytemplate = null;
		private bool __emailbodytemplate_set = false;
		public virtual string EmailBodyTemplate { get { if (!__emailbodytemplate_set) __emailbodytemplate = GetFieldValue<string>("EmailBodyTemplate"); __emailbodytemplate_set = true; return __emailbodytemplate; } set { __emailbodytemplate = value; __emailbodytemplate_set = true;  } }
		private bool __customizeform;
		private bool __customizeform_set = false;
		public virtual bool CustomizeForm { get { if (!__customizeform_set) __customizeform = GetFieldValue<bool>("CustomizeForm"); __customizeform_set = true; return __customizeform; } set { __customizeform = value; __customizeform_set = true;  } }
		private string __submissionform = null;
		private bool __submissionform_set = false;
		public virtual string SubmissionForm { get { if (!__submissionform_set) __submissionform = GetFieldValue<string>("SubmissionForm"); __submissionform_set = true; return __submissionform; } set { __submissionform = value; __submissionform_set = true;  } }
		private bool __submitintougc;
		private bool __submitintougc_set = false;
		public virtual bool SubmitIntoUGC { get { if (!__submitintougc_set) __submitintougc = GetFieldValue<bool>("SubmitIntoUGC"); __submitintougc_set = true; return __submitintougc; } set { __submitintougc = value; __submitintougc_set = true;  } }

	}
	public partial class Module_InfoBox : Agility.Web.AgilityContentItem
	{
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true;  } }

	}
	public partial class Module_JobListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __sidetitle = null;
		private bool __sidetitle_set = false;
		public virtual string SideTitle { get { if (!__sidetitle_set) __sidetitle = GetFieldValue<string>("SideTitle"); __sidetitle_set = true; return __sidetitle; } set { __sidetitle = value; __sidetitle_set = true;  } }
		private string __sidebody = null;
		private bool __sidebody_set = false;
		public virtual string SideBody { get { if (!__sidebody_set) __sidebody = GetFieldValue<string>("SideBody"); __sidebody_set = true; return __sidebody; } set { __sidebody = value; __sidebody_set = true;  } }
		private string __sidelink = null;
		private bool __sidelink_set = false;
		public virtual string SideLink { get { if (!__sidelink_set) __sidelink = GetFieldValue<string>("SideLink"); __sidelink_set = true; return __sidelink; } set { __sidelink = value; __sidelink_set = true;  } }
		private IAgilityContentRepository<Job> __jobs = null;
		public virtual IAgilityContentRepository<Job> Jobs { get { if (__jobs == null) __jobs = GetLinkedContent<Job>("Jobs", "", "Title ", ""); return __jobs; } set { __jobs = value; }}

	}
	public partial class Module_LatestPosts : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private int __postcount;
		private bool __postcount_set = false;
		public virtual int PostCount { get { if (!__postcount_set) __postcount = GetFieldValue<int>("PostCount"); __postcount_set = true; return __postcount; } set { __postcount = value; __postcount_set = true;  } }
		private IAgilityContentRepository<BlogPost> __posts = null;
		public virtual IAgilityContentRepository<BlogPost> Posts { get { if (__posts == null) __posts = GetLinkedContent<BlogPost>("Posts"); return __posts; } set { __posts = value; }}
		private string __categoryids = null;
		private bool __categoryids_set = false;
		public virtual string CategoryIDs { get { if (!__categoryids_set) __categoryids = GetFieldValue<string>("CategoryIDs"); __categoryids_set = true; return __categoryids; } set { __categoryids = value; __categoryids_set = true;  } }
		private string __categorynames = null;
		private bool __categorynames_set = false;
		public virtual string CategoryNames { get { if (!__categorynames_set) __categorynames = GetFieldValue<string>("CategoryNames"); __categorynames_set = true; return __categorynames; } set { __categorynames = value; __categorynames_set = true;  } }
		private IAgilityContentRepository<BlogCategory> __categories = null;
		public virtual IAgilityContentRepository<BlogCategory> Categories { get { if (__categories == null) __categories = GetLinkedContent<BlogCategory>("Categories"); return __categories; } set { __categories = value; }}
		private string __readmorelabel = null;
		private bool __readmorelabel_set = false;
		public virtual string ReadMoreLabel { get { if (!__readmorelabel_set) __readmorelabel = GetFieldValue<string>("ReadMoreLabel"); __readmorelabel_set = true; return __readmorelabel; } set { __readmorelabel = value; __readmorelabel_set = true;  } }

	}
	public partial class Module_LatestResources : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private string __lefttypetitle = null;
		private bool __lefttypetitle_set = false;
		public virtual string LeftTypeTitle { get { if (!__lefttypetitle_set) __lefttypetitle = GetFieldValue<string>("LeftTypeTitle"); __lefttypetitle_set = true; return __lefttypetitle; } set { __lefttypetitle = value; __lefttypetitle_set = true;  } }
		private string __leftbutton = null;
		private bool __leftbutton_set = false;
		public virtual string LeftButton { get { if (!__leftbutton_set) __leftbutton = GetFieldValue<string>("LeftButton"); __leftbutton_set = true; return __leftbutton; } set { __leftbutton = value; __leftbutton_set = true;  } }
		private IAgilityContentRepository<Resource> __resources = null;
		public virtual IAgilityContentRepository<Resource> Resources { get { if (__resources == null) __resources = GetLinkedContent<Resource>("Resources"); return __resources; } set { __resources = value; }}

	}
	public partial class Module_LogoListing : Agility.Web.AgilityContentItem
	{
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true;  } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true;  } }
		private IAgilityContentRepository<Logo> __logos = null;
		public virtual IAgilityContentRepository<Logo> Logos { get { if (__logos == null) __logos = GetLinkedContent<Logo>("Logos", "", "ItemOrder ", ""); return __logos; } set { __logos = value; }}
		private string __logoids = null;
		private bool __logoids_set = false;
		public virtual string LogoIDs { get { if (!__logoids_set) __logoids = GetFieldValue<string>("LogoIDs"); __logoids_set = true; return __logoids; } set { __logoids = value; __logoids_set = true;  } }
		private string __rendertype = null;
		private bool __rendertype_set = false;
		public virtual string RenderType { get { if (!__rendertype_set) __rendertype = GetFieldValue<string>("RenderType"); __rendertype_set = true; return __rendertype; } set { __rendertype = value; __rendertype_set = true;  } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true;  } }
		private string __secondarybutton = null;
		private bool __secondarybutton_set = false;
		public virtual string SecondaryButton { get { if (!__secondarybutton_set) __secondarybutton = GetFieldValue<string>("SecondaryButton"); __secondarybutton_set = true; return __secondarybutton; } set { __secondarybutton = value; __secondarybutton_set = true;  } }

	}
	public partial class Module_PartnerContentPanel : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_PartnerDetails : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_PartnerListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private string __lefttypetitle = null;
		private bool __lefttypetitle_set = false;
		public virtual string LeftTypeTitle { get { if (!__lefttypetitle_set) __lefttypetitle = GetFieldValue<string>("LeftTypeTitle"); __lefttypetitle_set = true; return __lefttypetitle; } set { __lefttypetitle = value; __lefttypetitle_set = true;  } }
		private string __leftbutton = null;
		private bool __leftbutton_set = false;
		public virtual string LeftButton { get { if (!__leftbutton_set) __leftbutton = GetFieldValue<string>("LeftButton"); __leftbutton_set = true; return __leftbutton; } set { __leftbutton = value; __leftbutton_set = true;  } }
		private IAgilityContentRepository<Partner> __partners = null;
		public virtual IAgilityContentRepository<Partner> Partners { get { if (__partners == null) __partners = GetLinkedContent<Partner>("Partners"); return __partners; } set { __partners = value; }}
		private string __customtagstohighlightids = null;
		private bool __customtagstohighlightids_set = false;
		public virtual string CustomTagsToHighlightIDs { get { if (!__customtagstohighlightids_set) __customtagstohighlightids = GetFieldValue<string>("CustomTagsToHighlightIDs"); __customtagstohighlightids_set = true; return __customtagstohighlightids; } set { __customtagstohighlightids = value; __customtagstohighlightids_set = true;  } }
		private IAgilityContentRepository<CustomTag> __customtagstohighlight = null;
		public virtual IAgilityContentRepository<CustomTag> CustomTagsToHighlight { get { if (__customtagstohighlight == null) __customtagstohighlight = GetLinkedContent<CustomTag>("CustomTagsToHighlight"); return __customtagstohighlight; } set { __customtagstohighlight = value; }}

	}
	public partial class Module_PartnerLogoListing : Agility.Web.AgilityContentItem
	{
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true;  } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true;  } }
		private IAgilityContentRepository<Partner> __partners = null;
		public virtual IAgilityContentRepository<Partner> Partners { get { if (__partners == null) __partners = GetLinkedContent<Partner>("Partners", "", "ItemOrder ", ""); return __partners; } set { __partners = value; }}
		private string __partnersids = null;
		private bool __partnersids_set = false;
		public virtual string PartnersIDs { get { if (!__partnersids_set) __partnersids = GetFieldValue<string>("PartnersIDs"); __partnersids_set = true; return __partnersids; } set { __partnersids = value; __partnersids_set = true;  } }
		private string __rendertype = null;
		private bool __rendertype_set = false;
		public virtual string RenderType { get { if (!__rendertype_set) __rendertype = GetFieldValue<string>("RenderType"); __rendertype_set = true; return __rendertype; } set { __rendertype = value; __rendertype_set = true;  } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true;  } }
		private string __secondarybutton = null;
		private bool __secondarybutton_set = false;
		public virtual string SecondaryButton { get { if (!__secondarybutton_set) __secondarybutton = GetFieldValue<string>("SecondaryButton"); __secondarybutton_set = true; return __secondarybutton; } set { __secondarybutton = value; __secondarybutton_set = true;  } }

	}
	public partial class Module_PeopleListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string Subtitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("Subtitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private IAgilityContentRepository<Person> __people = null;
		public virtual IAgilityContentRepository<Person> People { get { if (__people == null) __people = GetLinkedContent<Person>("People"); return __people; } set { __people = value; }}

	}
	public partial class Module_PodcastDetail : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_PodcastListing : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<Podcast> __items = null;
		public virtual IAgilityContentRepository<Podcast> Items { get { if (__items == null) __items = GetLinkedContent<Podcast>("Items"); return __items; } set { __items = value; }}
		private string __sortorder = null;
		private bool __sortorder_set = false;
		public virtual string SortOrder { get { if (!__sortorder_set) __sortorder = GetFieldValue<string>("SortOrder"); __sortorder_set = true; return __sortorder; } set { __sortorder = value; __sortorder_set = true;  } }
		private int __itemsperpage;
		private bool __itemsperpage_set = false;
		public virtual int ItemsPerPage { get { if (!__itemsperpage_set) __itemsperpage = GetFieldValue<int>("ItemsPerPage"); __itemsperpage_set = true; return __itemsperpage; } set { __itemsperpage = value; __itemsperpage_set = true;  } }

	}
	public partial class Module_PodcastSubscribe : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private IAgilityContentRepository<SocialFollowLink> __podcastplatforms = null;
		public virtual IAgilityContentRepository<SocialFollowLink> PodcastPlatforms { get { if (__podcastplatforms == null) __podcastplatforms = GetLinkedContent<SocialFollowLink>("PodcastPlatforms", "", "ItemOrder ", ""); return __podcastplatforms; } set { __podcastplatforms = value; }}

	}
	public partial class Module_PostDetails : Agility.Web.AgilityContentItem
	{
		private string __categorylabel = null;
		private bool __categorylabel_set = false;
		public virtual string CategoryLabel { get { if (!__categorylabel_set) __categorylabel = GetFieldValue<string>("CategoryLabel"); __categorylabel_set = true; return __categorylabel; } set { __categorylabel = value; __categorylabel_set = true;  } }
		private string __relatedpostslabel = null;
		private bool __relatedpostslabel_set = false;
		public virtual string RelatedPostsLabel { get { if (!__relatedpostslabel_set) __relatedpostslabel = GetFieldValue<string>("RelatedPostsLabel"); __relatedpostslabel_set = true; return __relatedpostslabel; } set { __relatedpostslabel = value; __relatedpostslabel_set = true;  } }
		private int __relatedpostscount;
		private bool __relatedpostscount_set = false;
		public virtual int RelatedPostsCount { get { if (!__relatedpostscount_set) __relatedpostscount = GetFieldValue<int>("RelatedPostsCount"); __relatedpostscount_set = true; return __relatedpostscount; } set { __relatedpostscount = value; __relatedpostscount_set = true;  } }

	}
	public partial class Module_PostListing : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<BlogPost> __posts = null;
		public virtual IAgilityContentRepository<BlogPost> Posts { get { if (__posts == null) __posts = GetLinkedContent<BlogPost>("Posts"); return __posts; } set { __posts = value; }}
		private int __postcount;
		private bool __postcount_set = false;
		public virtual int PostCount { get { if (!__postcount_set) __postcount = GetFieldValue<int>("PostCount"); __postcount_set = true; return __postcount; } set { __postcount = value; __postcount_set = true;  } }

	}
	public partial class Module_PricingPlans : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private IAgilityContentRepository<PricingPlan> __plans = null;
		public virtual IAgilityContentRepository<PricingPlan> Plans { get { if (__plans == null) __plans = GetLinkedContent<PricingPlan>("Plans"); return __plans; } set { __plans = value; }}

	}
	public partial class Module_ResourceDetails : Agility.Web.AgilityContentItem
	{
		private string __backbutton = null;
		private bool __backbutton_set = false;
		public virtual string BackButton { get { if (!__backbutton_set) __backbutton = GetFieldValue<string>("BackButton"); __backbutton_set = true; return __backbutton; } set { __backbutton = value; __backbutton_set = true;  } }

	}
	public partial class Module_RichTextArea : Agility.Web.AgilityContentItem
	{
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }

	}
	public partial class Module_SectionHeading : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }

	}
	public partial class Module_Share : Agility.Web.AgilityContentItem
	{
		private string __sharelabel = null;
		private bool __sharelabel_set = false;
		public virtual string ShareLabel { get { if (!__sharelabel_set) __sharelabel = GetFieldValue<string>("ShareLabel"); __sharelabel_set = true; return __sharelabel; } set { __sharelabel = value; __sharelabel_set = true;  } }
		private bool __facebook;
		private bool __facebook_set = false;
		public virtual bool Facebook { get { if (!__facebook_set) __facebook = GetFieldValue<bool>("Facebook"); __facebook_set = true; return __facebook; } set { __facebook = value; __facebook_set = true;  } }
		private bool __twitter;
		private bool __twitter_set = false;
		public virtual bool Twitter { get { if (!__twitter_set) __twitter = GetFieldValue<bool>("Twitter"); __twitter_set = true; return __twitter; } set { __twitter = value; __twitter_set = true;  } }
		private bool __linkedin;
		private bool __linkedin_set = false;
		public virtual bool LinkedIn { get { if (!__linkedin_set) __linkedin = GetFieldValue<bool>("LinkedIn"); __linkedin_set = true; return __linkedin; } set { __linkedin = value; __linkedin_set = true;  } }

	}
	public partial class Module_StayInTouch : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private IAgilityContentRepository<SocialFollowLink> __socialfollowlinks = null;
		public virtual IAgilityContentRepository<SocialFollowLink> SocialFollowLinks { get { if (__socialfollowlinks == null) __socialfollowlinks = GetLinkedContent<SocialFollowLink>("SocialFollowLinks"); return __socialfollowlinks; } set { __socialfollowlinks = value; }}

	}
	public partial class Module_SubmissionForm : Agility.Web.AgilityContentItem
	{
		private string __componentname = null;
		private bool __componentname_set = false;
		public virtual string ComponentName { get { if (!__componentname_set) __componentname = GetFieldValue<string>("ComponentName"); __componentname_set = true; return __componentname; } set { __componentname = value; __componentname_set = true;  } }
		private string __backgroundcolour = null;
		private bool __backgroundcolour_set = false;
		public virtual string BackgroundColour { get { if (!__backgroundcolour_set) __backgroundcolour = GetFieldValue<string>("BackgroundColour"); __backgroundcolour_set = true; return __backgroundcolour; } set { __backgroundcolour = value; __backgroundcolour_set = true;  } }
		private string __submissionposturl = null;
		private bool __submissionposturl_set = false;
		public virtual string SubmissionPOSTURL { get { if (!__submissionposturl_set) __submissionposturl = GetFieldValue<string>("SubmissionPOSTURL"); __submissionposturl_set = true; return __submissionposturl; } set { __submissionposturl = value; __submissionposturl_set = true;  } }
		private string __leftcolumntitle = null;
		private bool __leftcolumntitle_set = false;
		public virtual string LeftColumnTitle { get { if (!__leftcolumntitle_set) __leftcolumntitle = GetFieldValue<string>("LeftColumnTitle"); __leftcolumntitle_set = true; return __leftcolumntitle; } set { __leftcolumntitle = value; __leftcolumntitle_set = true;  } }
		private string __leftcolumnbody = null;
		private bool __leftcolumnbody_set = false;
		public virtual string LeftColumnBody { get { if (!__leftcolumnbody_set) __leftcolumnbody = GetFieldValue<string>("LeftColumnBody"); __leftcolumnbody_set = true; return __leftcolumnbody; } set { __leftcolumnbody = value; __leftcolumnbody_set = true;  } }
		private string __rightcolumntitle = null;
		private bool __rightcolumntitle_set = false;
		public virtual string RightColumnTitle { get { if (!__rightcolumntitle_set) __rightcolumntitle = GetFieldValue<string>("RightColumnTitle"); __rightcolumntitle_set = true; return __rightcolumntitle; } set { __rightcolumntitle = value; __rightcolumntitle_set = true;  } }
		private string __submissioncopy = null;
		private bool __submissioncopy_set = false;
		public virtual string SubmissionCopy { get { if (!__submissioncopy_set) __submissioncopy = GetFieldValue<string>("SubmissionCopy"); __submissioncopy_set = true; return __submissioncopy; } set { __submissioncopy = value; __submissioncopy_set = true;  } }
		private string __redirecturl = null;
		private bool __redirecturl_set = false;
		public virtual string RedirectURL { get { if (!__redirecturl_set) __redirecturl = GetFieldValue<string>("RedirectURL"); __redirecturl_set = true; return __redirecturl; } set { __redirecturl = value; __redirecturl_set = true;  } }
		private string __thanksmessage = null;
		private bool __thanksmessage_set = false;
		public virtual string ThanksMessage { get { if (!__thanksmessage_set) __thanksmessage = GetFieldValue<string>("ThanksMessage"); __thanksmessage_set = true; return __thanksmessage; } set { __thanksmessage = value; __thanksmessage_set = true;  } }
		private string __conversionscript = null;
		private bool __conversionscript_set = false;
		public virtual string ConversionScript { get { if (!__conversionscript_set) __conversionscript = GetFieldValue<string>("ConversionScript"); __conversionscript_set = true; return __conversionscript; } set { __conversionscript = value; __conversionscript_set = true;  } }

	}
	public partial class Module_SubscribedThankYou : Agility.Web.AgilityContentItem
	{
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true;  } }

	}
	public partial class Module_TabPanels : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true;  } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true;  } }
		private string __tabpanelids = null;
		private bool __tabpanelids_set = false;
		public virtual string TabPanelIDs { get { if (!__tabpanelids_set) __tabpanelids = GetFieldValue<string>("TabPanelIDs"); __tabpanelids_set = true; return __tabpanelids; } set { __tabpanelids = value; __tabpanelids_set = true;  } }
		private string __tabpanelnames = null;
		private bool __tabpanelnames_set = false;
		public virtual string TabPanelNames { get { if (!__tabpanelnames_set) __tabpanelnames = GetFieldValue<string>("TabPanelNames"); __tabpanelnames_set = true; return __tabpanelnames; } set { __tabpanelnames = value; __tabpanelnames_set = true;  } }
		private IAgilityContentRepository<TabPanel> __tabpanels = null;
		public virtual IAgilityContentRepository<TabPanel> TabPanels { get { if (__tabpanels == null) __tabpanels = GetLinkedContent<TabPanel>("TabPanels", "", "ItemOrder ", ""); return __tabpanels; } set { __tabpanels = value; }}

	}
	public partial class Module_Testimonials : Agility.Web.AgilityContentItem
	{
		private string __header = null;
		private bool __header_set = false;
		public virtual string Header { get { if (!__header_set) __header = GetFieldValue<string>("Header"); __header_set = true; return __header; } set { __header = value; __header_set = true;  } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true;  } }
		private string __testimonialids = null;
		private bool __testimonialids_set = false;
		public virtual string TestimonialIDs { get { if (!__testimonialids_set) __testimonialids = GetFieldValue<string>("TestimonialIDs"); __testimonialids_set = true; return __testimonialids; } set { __testimonialids = value; __testimonialids_set = true;  } }
		private IAgilityContentRepository<Testimonial> __testimonials = null;
		public virtual IAgilityContentRepository<Testimonial> Testimonials { get { if (__testimonials == null) __testimonials = GetLinkedContent<Testimonial>("Testimonials"); return __testimonials; } set { __testimonials = value; }}
		private string __bottomlink = null;
		private bool __bottomlink_set = false;
		public virtual string BottomLink { get { if (!__bottomlink_set) __bottomlink = GetFieldValue<string>("BottomLink"); __bottomlink_set = true; return __bottomlink; } set { __bottomlink = value; __bottomlink_set = true;  } }

	}

}
