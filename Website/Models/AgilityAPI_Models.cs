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
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __referencename = null;
		private bool __referencename_set = false;
		public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true; } }
		private bool __visible;
		private bool __visible_set = false;
		public virtual bool Visible { get { if (!__visible_set) __visible = GetFieldValue<bool>("Visible"); __visible_set = true; return __visible; } set { __visible = value; __visible_set = true; } }

	}
	public partial class AgilityCSS : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __referencename = null;
		private bool __referencename_set = false;
		public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true; } }
		private bool __minify;
		private bool __minify_set = false;
		public virtual bool Minify { get { if (!__minify_set) __minify = GetFieldValue<bool>("Minify"); __minify_set = true; return __minify; } set { __minify = value; __minify_set = true; } }

	}
	public partial class AgilityJavascript : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __referencename = null;
		private bool __referencename_set = false;
		public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true; } }
		private bool __minify;
		private bool __minify_set = false;
		public virtual bool Minify { get { if (!__minify_set) __minify = GetFieldValue<bool>("Minify"); __minify_set = true; return __minify; } set { __minify = value; __minify_set = true; } }

	}
	public partial class BlogAuthor : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __jobtitle = null;
		private bool __jobtitle_set = false;
		public virtual string JobTitle { get { if (!__jobtitle_set) __jobtitle = GetFieldValue<string>("JobTitle"); __jobtitle_set = true; return __jobtitle; } set { __jobtitle = value; __jobtitle_set = true; } }
		private Attachment __image = null;
		public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }

	}
	public partial class BlogCategory : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }

	}
	public partial class BlogPost : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true; } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true; } }
		private int __authorid;
		private bool __authorid_set = false;
		public virtual int AuthorID { get { if (!__authorid_set) __authorid = GetFieldValue<int>("AuthorID"); __authorid_set = true; return __authorid; } set { __authorid = value; __authorid_set = true; } }
		private string __authortitle = null;
		private bool __authortitle_set = false;
		public virtual string AuthorTitle { get { if (!__authortitle_set) __authortitle = GetFieldValue<string>("AuthorTitle"); __authortitle_set = true; return __authortitle; } set { __authortitle = value; __authortitle_set = true; } }
		private IAgilityContentRepository<BlogAuthor> __author = null;
		public virtual IAgilityContentRepository<BlogAuthor> Author { get { if (__author == null) __author = GetLinkedContent<BlogAuthor>("Author"); return __author; } set { __author = value; } }
		private bool __enablecomments;
		private bool __enablecomments_set = false;
		public virtual bool EnableComments { get { if (!__enablecomments_set) __enablecomments = GetFieldValue<bool>("EnableComments"); __enablecomments_set = true; return __enablecomments; } set { __enablecomments = value; __enablecomments_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true; } }
		private Attachment __postimage = null;
		public virtual Attachment PostImage { get { if (__postimage == null) __postimage = GetAttachment("PostImage"); return __postimage; } set { __postimage = value; } }
		private bool __displayimageinpost;
		private bool __displayimageinpost_set = false;
		public virtual bool DisplayImageinPost { get { if (!__displayimageinpost_set) __displayimageinpost = GetFieldValue<bool>("DisplayImageinPost"); __displayimageinpost_set = true; return __displayimageinpost; } set { __displayimageinpost = value; __displayimageinpost_set = true; } }
		private Attachment __listingimageoverride = null;
		public virtual Attachment ListingImageOverride { get { if (__listingimageoverride == null) __listingimageoverride = GetAttachment("ListingImageOverride"); return __listingimageoverride; } set { __listingimageoverride = value; } }
		private string __categoriesids = null;
		private bool __categoriesids_set = false;
		public virtual string CategoriesIDs { get { if (!__categoriesids_set) __categoriesids = GetFieldValue<string>("CategoriesIDs"); __categoriesids_set = true; return __categoriesids; } set { __categoriesids = value; __categoriesids_set = true; } }
		private string __categoriestitle = null;
		private bool __categoriestitle_set = false;
		public virtual string CategoriesTitle { get { if (!__categoriestitle_set) __categoriestitle = GetFieldValue<string>("CategoriesTitle"); __categoriestitle_set = true; return __categoriestitle; } set { __categoriestitle = value; __categoriestitle_set = true; } }
		private IAgilityContentRepository<BlogCategory> __categories = null;
		public virtual IAgilityContentRepository<BlogCategory> Categories { get { if (__categories == null) __categories = GetLinkedContent<BlogCategory>("Categories"); return __categories; } set { __categories = value; } }
		private string __blogtagsids = null;
		private bool __blogtagsids_set = false;
		public virtual string BlogTagsIDs { get { if (!__blogtagsids_set) __blogtagsids = GetFieldValue<string>("BlogTagsIDs"); __blogtagsids_set = true; return __blogtagsids; } set { __blogtagsids = value; __blogtagsids_set = true; } }
		private string __blogtagstitle = null;
		private bool __blogtagstitle_set = false;
		public virtual string BlogTagsTitle { get { if (!__blogtagstitle_set) __blogtagstitle = GetFieldValue<string>("BlogTagsTitle"); __blogtagstitle_set = true; return __blogtagstitle; } set { __blogtagstitle = value; __blogtagstitle_set = true; } }
		private IAgilityContentRepository<BlogTag> __blogtags = null;
		public virtual IAgilityContentRepository<BlogTag> BlogTags { get { if (__blogtags == null) __blogtags = GetLinkedContent<BlogTag>("BlogTags"); return __blogtags; } set { __blogtags = value; } }
		private string __relatepostsby = null;
		private bool __relatepostsby_set = false;
		public virtual string RelatePostsBy { get { if (!__relatepostsby_set) __relatepostsby = GetFieldValue<string>("RelatePostsBy"); __relatepostsby_set = true; return __relatepostsby; } set { __relatepostsby = value; __relatepostsby_set = true; } }
		private IAgilityContentRepository<BlogPost> __relatedposts = null;
		public virtual IAgilityContentRepository<BlogPost> RelatedPosts { get { if (__relatedposts == null) __relatedposts = GetLinkedContent<BlogPost>("RelatedPosts", "", "itemOrder ", ""); return __relatedposts; } set { __relatedposts = value; } }
		private string __relatedpostsids = null;
		private bool __relatedpostsids_set = false;
		public virtual string RelatedPostsIDs { get { if (!__relatedpostsids_set) __relatedpostsids = GetFieldValue<string>("RelatedPostsIDs"); __relatedpostsids_set = true; return __relatedpostsids; } set { __relatedpostsids = value; __relatedpostsids_set = true; } }
		private string __relatedposttitles = null;
		private bool __relatedposttitles_set = false;
		public virtual string RelatedPostTitles { get { if (!__relatedposttitles_set) __relatedposttitles = GetFieldValue<string>("RelatedPostTitles"); __relatedposttitles_set = true; return __relatedposttitles; } set { __relatedposttitles = value; __relatedposttitles_set = true; } }

	}
	public partial class BlogTag : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }

	}
	public partial class CalloutItem : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __caption = null;
		private bool __caption_set = false;
		public virtual string Caption { get { if (!__caption_set) __caption = GetFieldValue<string>("Caption"); __caption_set = true; return __caption; } set { __caption = value; __caption_set = true; } }
		private string __link = null;
		private bool __link_set = false;
		public virtual string Link { get { if (!__link_set) __link = GetFieldValue<string>("Link"); __link_set = true; return __link; } set { __link = value; __link_set = true; } }

	}
	public partial class CaseStudy : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private int __authorid;
		private bool __authorid_set = false;
		public virtual int AuthorID { get { if (!__authorid_set) __authorid = GetFieldValue<int>("AuthorID"); __authorid_set = true; return __authorid; } set { __authorid = value; __authorid_set = true; } }
		private string __authorname = null;
		private bool __authorname_set = false;
		public virtual string AuthorName { get { if (!__authorname_set) __authorname = GetFieldValue<string>("AuthorName"); __authorname_set = true; return __authorname; } set { __authorname = value; __authorname_set = true; } }
		private IAgilityContentRepository<BlogAuthor> __author = null;
		public virtual IAgilityContentRepository<BlogAuthor> Author { get { if (__author == null) __author = GetLinkedContent<BlogAuthor>("Author"); return __author; } set { __author = value; } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true; } }
		private Attachment __image = null;
		public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true; } }

	}
	public partial class ContentPanel : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true; } }
		private string __secondarybutton = null;
		private bool __secondarybutton_set = false;
		public virtual string SecondaryButton { get { if (!__secondarybutton_set) __secondarybutton = GetFieldValue<string>("SecondaryButton"); __secondarybutton_set = true; return __secondarybutton; } set { __secondarybutton = value; __secondarybutton_set = true; } }
		private Attachment __image = null;
		public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __imageposition = null;
		private bool __imageposition_set = false;
		public virtual string ImagePosition { get { if (!__imageposition_set) __imageposition = GetFieldValue<string>("ImagePosition"); __imageposition_set = true; return __imageposition; } set { __imageposition = value; __imageposition_set = true; } }
		private bool __enablebackgroundimage;
		private bool __enablebackgroundimage_set = false;
		public virtual bool EnableBackgroundImage { get { if (!__enablebackgroundimage_set) __enablebackgroundimage = GetFieldValue<bool>("EnableBackgroundImage"); __enablebackgroundimage_set = true; return __enablebackgroundimage; } set { __enablebackgroundimage = value; __enablebackgroundimage_set = true; } }

	}
	public partial class CTABlock : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private Attachment __image = null;
		public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __link = null;
		private bool __link_set = false;
		public virtual string Link { get { if (!__link_set) __link = GetFieldValue<string>("Link"); __link_set = true; return __link; } set { __link = value; __link_set = true; } }

	}
	public partial class Event : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private IAgilityContentRepository<EventType> __eventtype = null;
		public virtual IAgilityContentRepository<EventType> EventType { get { if (__eventtype == null) __eventtype = GetLinkedContent<EventType>("EventType"); return __eventtype; } set { __eventtype = value; } }
		private int __eventtypeid;
		private bool __eventtypeid_set = false;
		public virtual int EventTypeID { get { if (!__eventtypeid_set) __eventtypeid = GetFieldValue<int>("EventTypeID"); __eventtypeid_set = true; return __eventtypeid; } set { __eventtypeid = value; __eventtypeid_set = true; } }
		private string __eventtypename = null;
		private bool __eventtypename_set = false;
		public virtual string EventTypeName { get { if (!__eventtypename_set) __eventtypename = GetFieldValue<string>("EventTypeName"); __eventtypename_set = true; return __eventtypename; } set { __eventtypename = value; __eventtypename_set = true; } }
		private int __organizerid;
		private bool __organizerid_set = false;
		public virtual int OrganizerID { get { if (!__organizerid_set) __organizerid = GetFieldValue<int>("OrganizerID"); __organizerid_set = true; return __organizerid; } set { __organizerid = value; __organizerid_set = true; } }
		private string __organizername = null;
		private bool __organizername_set = false;
		public virtual string OrganizerName { get { if (!__organizername_set) __organizername = GetFieldValue<string>("OrganizerName"); __organizername_set = true; return __organizername; } set { __organizername = value; __organizername_set = true; } }
		private IAgilityContentRepository<BlogAuthor> __organizer = null;
		public virtual IAgilityContentRepository<BlogAuthor> Organizer { get { if (__organizer == null) __organizer = GetLinkedContent<BlogAuthor>("Organizer"); return __organizer; } set { __organizer = value; } }
		private string __address = null;
		private bool __address_set = false;
		public virtual string Address { get { if (!__address_set) __address = GetFieldValue<string>("Address"); __address_set = true; return __address; } set { __address = value; __address_set = true; } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true; } }
		private string __externallink = null;
		private bool __externallink_set = false;
		public virtual string ExternalLink { get { if (!__externallink_set) __externallink = GetFieldValue<string>("ExternalLink"); __externallink_set = true; return __externallink; } set { __externallink = value; __externallink_set = true; } }
		private Attachment __thumbnail = null;
		public virtual Attachment Thumbnail { get { if (__thumbnail == null) __thumbnail = GetAttachment("Thumbnail"); return __thumbnail; } set { __thumbnail = value; } }
		private string __description = null;
		private bool __description_set = false;
		public virtual string Description { get { if (!__description_set) __description = GetFieldValue<string>("Description"); __description_set = true; return __description; } set { __description = value; __description_set = true; } }

	}
	public partial class EventType : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }

	}
	public partial class FaqItem : Agility.Web.AgilityContentItem
	{
		private string __question = null;
		private bool __question_set = false;
		public virtual string Question { get { if (!__question_set) __question = GetFieldValue<string>("Question"); __question_set = true; return __question; } set { __question = value; __question_set = true; } }
		private string __answer = null;
		private bool __answer_set = false;
		public virtual string Answer { get { if (!__answer_set) __answer = GetFieldValue<string>("Answer"); __answer_set = true; return __answer; } set { __answer = value; __answer_set = true; } }

	}
	public partial class FeatureBlock : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private Attachment __icon = null;
		public virtual Attachment Icon { get { if (__icon == null) __icon = GetAttachment("Icon"); return __icon; } set { __icon = value; } }
		private string __bottomlink = null;
		private bool __bottomlink_set = false;
		public virtual string BottomLink { get { if (!__bottomlink_set) __bottomlink = GetFieldValue<string>("BottomLink"); __bottomlink_set = true; return __bottomlink; } set { __bottomlink = value; __bottomlink_set = true; } }

	}
	public partial class GlobalFooter : Agility.Web.AgilityContentItem
	{
		private string __column1title = null;
		private bool __column1title_set = false;
		public virtual string Column1Title { get { if (!__column1title_set) __column1title = GetFieldValue<string>("Column1Title"); __column1title_set = true; return __column1title; } set { __column1title = value; __column1title_set = true; } }
		private IAgilityContentRepository<Link> __column1links = null;
		public virtual IAgilityContentRepository<Link> Column1Links { get { if (__column1links == null) __column1links = GetLinkedContent<Link>("Column1Links", "", "ItemOrder ", ""); return __column1links; } set { __column1links = value; } }
		private string __column1sortids = null;
		private bool __column1sortids_set = false;
		public virtual string Column1SortIDs { get { if (!__column1sortids_set) __column1sortids = GetFieldValue<string>("Column1SortIDs"); __column1sortids_set = true; return __column1sortids; } set { __column1sortids = value; __column1sortids_set = true; } }
		private string __column2title = null;
		private bool __column2title_set = false;
		public virtual string Column2Title { get { if (!__column2title_set) __column2title = GetFieldValue<string>("Column2Title"); __column2title_set = true; return __column2title; } set { __column2title = value; __column2title_set = true; } }
		private string __column2sortids = null;
		private bool __column2sortids_set = false;
		public virtual string Column2SortIDs { get { if (!__column2sortids_set) __column2sortids = GetFieldValue<string>("Column2SortIDs"); __column2sortids_set = true; return __column2sortids; } set { __column2sortids = value; __column2sortids_set = true; } }
		private IAgilityContentRepository<Link> __column2links = null;
		public virtual IAgilityContentRepository<Link> Column2Links { get { if (__column2links == null) __column2links = GetLinkedContent<Link>("Column2Links", "", "ItemOrder ", ""); return __column2links; } set { __column2links = value; } }
		private string __column3title = null;
		private bool __column3title_set = false;
		public virtual string Column3Title { get { if (!__column3title_set) __column3title = GetFieldValue<string>("Column3Title"); __column3title_set = true; return __column3title; } set { __column3title = value; __column3title_set = true; } }
		private string __column3sortids = null;
		private bool __column3sortids_set = false;
		public virtual string Column3SortIDs { get { if (!__column3sortids_set) __column3sortids = GetFieldValue<string>("Column3SortIDs"); __column3sortids_set = true; return __column3sortids; } set { __column3sortids = value; __column3sortids_set = true; } }
		private IAgilityContentRepository<Link> __column3links = null;
		public virtual IAgilityContentRepository<Link> Column3Links { get { if (__column3links == null) __column3links = GetLinkedContent<Link>("Column3Links", "", "ItemOrder ", ""); return __column3links; } set { __column3links = value; } }
		private string __followtitle = null;
		private bool __followtitle_set = false;
		public virtual string FollowTitle { get { if (!__followtitle_set) __followtitle = GetFieldValue<string>("FollowTitle"); __followtitle_set = true; return __followtitle; } set { __followtitle = value; __followtitle_set = true; } }
		private IAgilityContentRepository<SocialFollowLink> __followlinks = null;
		public virtual IAgilityContentRepository<SocialFollowLink> FollowLinks { get { if (__followlinks == null) __followlinks = GetLinkedContent<SocialFollowLink>("FollowLinks", "", "ItemOrder ", ""); return __followlinks; } set { __followlinks = value; } }
		private string __subscribetitle = null;
		private bool __subscribetitle_set = false;
		public virtual string SubscribeTitle { get { if (!__subscribetitle_set) __subscribetitle = GetFieldValue<string>("SubscribeTitle"); __subscribetitle_set = true; return __subscribetitle; } set { __subscribetitle = value; __subscribetitle_set = true; } }
		private string __subscribedescription = null;
		private bool __subscribedescription_set = false;
		public virtual string SubscribeDescription { get { if (!__subscribedescription_set) __subscribedescription = GetFieldValue<string>("SubscribeDescription"); __subscribedescription_set = true; return __subscribedescription; } set { __subscribedescription = value; __subscribedescription_set = true; } }
		private string __subscribeemailplaceholder = null;
		private bool __subscribeemailplaceholder_set = false;
		public virtual string SubscribeEmailPlaceholder { get { if (!__subscribeemailplaceholder_set) __subscribeemailplaceholder = GetFieldValue<string>("SubscribeEmailPlaceholder"); __subscribeemailplaceholder_set = true; return __subscribeemailplaceholder; } set { __subscribeemailplaceholder = value; __subscribeemailplaceholder_set = true; } }
		private string __subscribebuttonlabel = null;
		private bool __subscribebuttonlabel_set = false;
		public virtual string SubscribeButtonLabel { get { if (!__subscribebuttonlabel_set) __subscribebuttonlabel = GetFieldValue<string>("SubscribeButtonLabel"); __subscribebuttonlabel_set = true; return __subscribebuttonlabel; } set { __subscribebuttonlabel = value; __subscribebuttonlabel_set = true; } }
		private string __subscriberedirect = null;
		private bool __subscriberedirect_set = false;
		public virtual string SubscribeRedirect { get { if (!__subscriberedirect_set) __subscriberedirect = GetFieldValue<string>("SubscribeRedirect"); __subscriberedirect_set = true; return __subscriberedirect; } set { __subscriberedirect = value; __subscriberedirect_set = true; } }
		private string __subscribeposturl = null;
		private bool __subscribeposturl_set = false;
		public virtual string SubscribePOSTUrl { get { if (!__subscribeposturl_set) __subscribeposturl = GetFieldValue<string>("SubscribePOSTUrl"); __subscribeposturl_set = true; return __subscribeposturl; } set { __subscribeposturl = value; __subscribeposturl_set = true; } }
		private string __copyright = null;
		private bool __copyright_set = false;
		public virtual string Copyright { get { if (!__copyright_set) __copyright = GetFieldValue<string>("Copyright"); __copyright_set = true; return __copyright; } set { __copyright = value; __copyright_set = true; } }
		private string __privacypolicylink = null;
		private bool __privacypolicylink_set = false;
		public virtual string PrivacyPolicyLink { get { if (!__privacypolicylink_set) __privacypolicylink = GetFieldValue<string>("PrivacyPolicyLink"); __privacypolicylink_set = true; return __privacypolicylink; } set { __privacypolicylink = value; __privacypolicylink_set = true; } }
		private string __securitylink = null;
		private bool __securitylink_set = false;
		public virtual string SecurityLink { get { if (!__securitylink_set) __securitylink = GetFieldValue<string>("SecurityLink"); __securitylink_set = true; return __securitylink; } set { __securitylink = value; __securitylink_set = true; } }

	}
	public partial class GlobalHeader : Agility.Web.AgilityContentItem
	{
		private Attachment __logo = null;
		public virtual Attachment Logo { get { if (__logo == null) __logo = GetAttachment("Logo"); return __logo; } set { __logo = value; } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true; } }
		private IAgilityContentRepository<Link> __preheaderlinks = null;
		public virtual IAgilityContentRepository<Link> PreHeaderLinks { get { if (__preheaderlinks == null) __preheaderlinks = GetLinkedContent<Link>("PreHeaderLinks", "", "ItemOrder ", ""); return __preheaderlinks; } set { __preheaderlinks = value; } }
		private string __preheaderlinksortids = null;
		private bool __preheaderlinksortids_set = false;
		public virtual string PreHeaderLinkSortIDs { get { if (!__preheaderlinksortids_set) __preheaderlinksortids = GetFieldValue<string>("PreHeaderLinkSortIDs"); __preheaderlinksortids_set = true; return __preheaderlinksortids; } set { __preheaderlinksortids = value; __preheaderlinksortids_set = true; } }

	}
	public partial class Link : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true; } }

	}
	public partial class Logo : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __urlslug = null;
		private bool __urlslug_set = false;
		public virtual string URLSlug { get { if (!__urlslug_set) __urlslug = GetFieldValue<string>("URLSlug"); __urlslug_set = true; return __urlslug; } set { __urlslug = value; __urlslug_set = true; } }
		private Attachment ___logo = null;
		public virtual Attachment _Logo { get { if (___logo == null) ___logo = GetAttachment("Logo"); return ___logo; } set { ___logo = value; } }
		private string __shortdescription = null;
		private bool __shortdescription_set = false;
		public virtual string ShortDescription { get { if (!__shortdescription_set) __shortdescription = GetFieldValue<string>("ShortDescription"); __shortdescription_set = true; return __shortdescription; } set { __shortdescription = value; __shortdescription_set = true; } }
		private string __description = null;
		private bool __description_set = false;
		public virtual string Description { get { if (!__description_set) __description = GetFieldValue<string>("Description"); __description_set = true; return __description; } set { __description = value; __description_set = true; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true; } }
		private string __city = null;
		private bool __city_set = false;
		public virtual string City { get { if (!__city_set) __city = GetFieldValue<string>("City"); __city_set = true; return __city; } set { __city = value; __city_set = true; } }
		private string __state = null;
		private bool __state_set = false;
		public virtual string State { get { if (!__state_set) __state = GetFieldValue<string>("State"); __state_set = true; return __state; } set { __state = value; __state_set = true; } }
		private string __country = null;
		private bool __country_set = false;
		public virtual string Country { get { if (!__country_set) __country = GetFieldValue<string>("Country"); __country_set = true; return __country; } set { __country = value; __country_set = true; } }
		private string __logotagids = null;
		private bool __logotagids_set = false;
		public virtual string LogoTagIDs { get { if (!__logotagids_set) __logotagids = GetFieldValue<string>("LogoTagIDs"); __logotagids_set = true; return __logotagids; } set { __logotagids = value; __logotagids_set = true; } }
		private string __logotagnames = null;
		private bool __logotagnames_set = false;
		public virtual string LogoTagNames { get { if (!__logotagnames_set) __logotagnames = GetFieldValue<string>("LogoTagNames"); __logotagnames_set = true; return __logotagnames; } set { __logotagnames = value; __logotagnames_set = true; } }
		private IAgilityContentRepository<LogoTags> __logotags = null;
		public virtual IAgilityContentRepository<LogoTags> LogoTags { get { if (__logotags == null) __logotags = GetLinkedContent<LogoTags>("LogoTags", "", "ItemOrder ", ""); return __logotags; } set { __logotags = value; } }

	}
	public partial class LogoTags : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }

	}
	public partial class Person : Agility.Web.AgilityContentItem
	{
		private string __fullname = null;
		private bool __fullname_set = false;
		public virtual string FullName { get { if (!__fullname_set) __fullname = GetFieldValue<string>("FullName"); __fullname_set = true; return __fullname; } set { __fullname = value; __fullname_set = true; } }
		private string __jobtitle = null;
		private bool __jobtitle_set = false;
		public virtual string JobTitle { get { if (!__jobtitle_set) __jobtitle = GetFieldValue<string>("JobTitle"); __jobtitle_set = true; return __jobtitle; } set { __jobtitle = value; __jobtitle_set = true; } }
		private string __summary = null;
		private bool __summary_set = false;
		public virtual string Summary { get { if (!__summary_set) __summary = GetFieldValue<string>("Summary"); __summary_set = true; return __summary; } set { __summary = value; __summary_set = true; } }
		private Attachment __headshot = null;
		public virtual Attachment Headshot { get { if (__headshot == null) __headshot = GetAttachment("Headshot"); return __headshot; } set { __headshot = value; } }

	}
	public partial class Podcast : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private int __episodenumber;
		private bool __episodenumber_set = false;
		public virtual int EpisodeNumber { get { if (!__episodenumber_set) __episodenumber = GetFieldValue<int>("EpisodeNumber"); __episodenumber_set = true; return __episodenumber; } set { __episodenumber = value; __episodenumber_set = true; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true; } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true; } }
		private string __guest = null;
		private bool __guest_set = false;
		public virtual string Guest { get { if (!__guest_set) __guest = GetFieldValue<string>("Guest"); __guest_set = true; return __guest; } set { __guest = value; __guest_set = true; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true; } }
		private string __embed = null;
		private bool __embed_set = false;
		public virtual string Embed { get { if (!__embed_set) __embed = GetFieldValue<string>("Embed"); __embed_set = true; return __embed; } set { __embed = value; __embed_set = true; } }
		private Attachment __mainimage = null;
		public virtual Attachment MainImage { get { if (__mainimage == null) __mainimage = GetAttachment("MainImage"); return __mainimage; } set { __mainimage = value; } }
		private Attachment __listingimage = null;
		public virtual Attachment ListingImage { get { if (__listingimage == null) __listingimage = GetAttachment("ListingImage"); return __listingimage; } set { __listingimage = value; } }

	}
	public partial class Resource : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __url = null;
		private bool __url_set = false;
		public virtual string URL { get { if (!__url_set) __url = GetFieldValue<string>("URL"); __url_set = true; return __url; } set { __url = value; __url_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private int __authorid;
		private bool __authorid_set = false;
		public virtual int AuthorID { get { if (!__authorid_set) __authorid = GetFieldValue<int>("AuthorID"); __authorid_set = true; return __authorid; } set { __authorid = value; __authorid_set = true; } }
		private string __authorname = null;
		private bool __authorname_set = false;
		public virtual string AuthorName { get { if (!__authorname_set) __authorname = GetFieldValue<string>("AuthorName"); __authorname_set = true; return __authorname; } set { __authorname = value; __authorname_set = true; } }
		private IAgilityContentRepository<BlogAuthor> __author = null;
		public virtual IAgilityContentRepository<BlogAuthor> Author { get { if (__author == null) __author = GetLinkedContent<BlogAuthor>("Author"); return __author; } set { __author = value; } }
		private DateTime __date;
		private bool __date_set = false;
		public virtual DateTime Date { get { if (!__date_set) __date = GetFieldValue<DateTime>("Date"); __date_set = true; return __date; } set { __date = value; __date_set = true; } }
		private int __resourcetypeid;
		private bool __resourcetypeid_set = false;
		public virtual int ResourceTypeID { get { if (!__resourcetypeid_set) __resourcetypeid = GetFieldValue<int>("ResourceTypeID"); __resourcetypeid_set = true; return __resourcetypeid; } set { __resourcetypeid = value; __resourcetypeid_set = true; } }
		private string __resourcetypename = null;
		private bool __resourcetypename_set = false;
		public virtual string ResourceTypeName { get { if (!__resourcetypename_set) __resourcetypename = GetFieldValue<string>("ResourceTypeName"); __resourcetypename_set = true; return __resourcetypename; } set { __resourcetypename = value; __resourcetypename_set = true; } }
		private IAgilityContentRepository<ResourceType> __resourcetype = null;
		public virtual IAgilityContentRepository<ResourceType> ResourceType { get { if (__resourcetype == null) __resourcetype = GetLinkedContent<ResourceType>("ResourceType"); return __resourcetype; } set { __resourcetype = value; } }
		private Attachment __image = null;
		public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true; } }
		private Attachment __filedownload = null;
		public virtual Attachment FileDownload { get { if (__filedownload == null) __filedownload = GetAttachment("FileDownload"); return __filedownload; } set { __filedownload = value; } }

	}
	public partial class ResourceType : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }

	}
	public partial class SocialFollowLink : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private Attachment __logo = null;
		public virtual Attachment Logo { get { if (__logo == null) __logo = GetAttachment("Logo"); return __logo; } set { __logo = value; } }
		private string __followurl = null;
		private bool __followurl_set = false;
		public virtual string FollowURL { get { if (!__followurl_set) __followurl = GetFieldValue<string>("FollowURL"); __followurl_set = true; return __followurl; } set { __followurl = value; __followurl_set = true; } }

	}
	public partial class TabPanel : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __description = null;
		private bool __description_set = false;
		public virtual string Description { get { if (!__description_set) __description = GetFieldValue<string>("Description"); __description_set = true; return __description; } set { __description = value; __description_set = true; } }
		private Attachment __image = null;
		public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true; } }

	}
	public partial class Testimonial : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __jobtitle = null;
		private bool __jobtitle_set = false;
		public virtual string JobTitle { get { if (!__jobtitle_set) __jobtitle = GetFieldValue<string>("JobTitle"); __jobtitle_set = true; return __jobtitle; } set { __jobtitle = value; __jobtitle_set = true; } }
		private IAgilityContentRepository<Logo> __selectcustomer = null;
		public virtual IAgilityContentRepository<Logo> SelectCustomer { get { if (__selectcustomer == null) __selectcustomer = GetLinkedContent<Logo>("SelectCustomer"); return __selectcustomer; } set { __selectcustomer = value; } }
		private string __companyname = null;
		private bool __companyname_set = false;
		public virtual string CompanyName { get { if (!__companyname_set) __companyname = GetFieldValue<string>("CompanyName"); __companyname_set = true; return __companyname; } set { __companyname = value; __companyname_set = true; } }
		private Attachment __headshot = null;
		public virtual Attachment Headshot { get { if (__headshot == null) __headshot = GetAttachment("Headshot"); return __headshot; } set { __headshot = value; } }
		private string __excerpt = null;
		private bool __excerpt_set = false;
		public virtual string Excerpt { get { if (!__excerpt_set) __excerpt = GetFieldValue<string>("Excerpt"); __excerpt_set = true; return __excerpt; } set { __excerpt = value; __excerpt_set = true; } }
		private int __customerid;
		private bool __customerid_set = false;
		public virtual int CustomerID { get { if (!__customerid_set) __customerid = GetFieldValue<int>("CustomerID"); __customerid_set = true; return __customerid; } set { __customerid = value; __customerid_set = true; } }

	}
	public partial class Module_Callout : Agility.Web.AgilityContentItem
	{
		private int __calloutid;
		private bool __calloutid_set = false;
		public virtual int CalloutID { get { if (!__calloutid_set) __calloutid = GetFieldValue<int>("CalloutID"); __calloutid_set = true; return __calloutid; } set { __calloutid = value; __calloutid_set = true; } }
		private IAgilityContentRepository<CalloutItem> __callout = null;
		public virtual IAgilityContentRepository<CalloutItem> Callout { get { if (__callout == null) __callout = GetLinkedContent<CalloutItem>("Callout"); return __callout; } set { __callout = value; } }
		private string __theme = null;
		private bool __theme_set = false;
		public virtual string Theme { get { if (!__theme_set) __theme = GetFieldValue<string>("Theme"); __theme_set = true; return __theme; } set { __theme = value; __theme_set = true; } }

	}
	public partial class Module_CaseStudyDetails : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_ContactUsForm : Agility.Web.AgilityContentItem
	{
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true; } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string Subheading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("Subheading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true; } }
		private string __thanksmessage = null;
		private bool __thanksmessage_set = false;
		public virtual string ThanksMessage { get { if (!__thanksmessage_set) __thanksmessage = GetFieldValue<string>("ThanksMessage"); __thanksmessage_set = true; return __thanksmessage; } set { __thanksmessage = value; __thanksmessage_set = true; } }
		private string __validationmessage = null;
		private bool __validationmessage_set = false;
		public virtual string ValidationMessage { get { if (!__validationmessage_set) __validationmessage = GetFieldValue<string>("ValidationMessage"); __validationmessage_set = true; return __validationmessage; } set { __validationmessage = value; __validationmessage_set = true; } }
		private string __errormessage = null;
		private bool __errormessage_set = false;
		public virtual string ErrorMessage { get { if (!__errormessage_set) __errormessage = GetFieldValue<string>("ErrorMessage"); __errormessage_set = true; return __errormessage; } set { __errormessage = value; __errormessage_set = true; } }

	}
	public partial class Module_ContentPanel : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<ContentPanel> __panel = null;
		public virtual IAgilityContentRepository<ContentPanel> Panel { get { if (__panel == null) __panel = GetLinkedContent<ContentPanel>("Panel"); return __panel; } set { __panel = value; } }
		private int __panelid;
		private bool __panelid_set = false;
		public virtual int PanelID { get { if (!__panelid_set) __panelid = GetFieldValue<int>("PanelID"); __panelid_set = true; return __panelid; } set { __panelid = value; __panelid_set = true; } }

	}
	public partial class Module_CTABlocks : Agility.Web.AgilityContentItem
	{
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true; } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true; } }
		private IAgilityContentRepository<CTABlock> __ctablocks = null;
		public virtual IAgilityContentRepository<CTABlock> CTABlocks { get { if (__ctablocks == null) __ctablocks = GetLinkedContent<CTABlock>("CTABlocks", "", "ItemOrder ", ""); return __ctablocks; } set { __ctablocks = value; } }

	}
	public partial class Module_EventListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private IAgilityContentRepository<EventType> __filterbytype = null;
		public virtual IAgilityContentRepository<EventType> FilterByType { get { if (__filterbytype == null) __filterbytype = GetLinkedContent<EventType>("FilterByType"); return __filterbytype; } set { __filterbytype = value; } }
		private int __filterbytypeid;
		private bool __filterbytypeid_set = false;
		public virtual int FilterByTypeID { get { if (!__filterbytypeid_set) __filterbytypeid = GetFieldValue<int>("FilterByTypeID"); __filterbytypeid_set = true; return __filterbytypeid; } set { __filterbytypeid = value; __filterbytypeid_set = true; } }
		private bool __showpasteventsonly;
		private bool __showpasteventsonly_set = false;
		public virtual bool ShowPastEventsOnly { get { if (!__showpasteventsonly_set) __showpasteventsonly = GetFieldValue<bool>("ShowPastEventsOnly"); __showpasteventsonly_set = true; return __showpasteventsonly; } set { __showpasteventsonly = value; __showpasteventsonly_set = true; } }
		private IAgilityContentRepository<Event> __events = null;
		public virtual IAgilityContentRepository<Event> Events { get { if (__events == null) __events = GetLinkedContent<Event>("Events", "", "Date ", ""); return __events; } set { __events = value; } }
		private string __viewdetailslabel = null;
		private bool __viewdetailslabel_set = false;
		public virtual string ViewDetailsLabel { get { if (!__viewdetailslabel_set) __viewdetailslabel = GetFieldValue<string>("ViewDetailsLabel"); __viewdetailslabel_set = true; return __viewdetailslabel; } set { __viewdetailslabel = value; __viewdetailslabel_set = true; } }
		private string __backlabel = null;
		private bool __backlabel_set = false;
		public virtual string BackLabel { get { if (!__backlabel_set) __backlabel = GetFieldValue<string>("BackLabel"); __backlabel_set = true; return __backlabel; } set { __backlabel = value; __backlabel_set = true; } }
		private string __registerlabel = null;
		private bool __registerlabel_set = false;
		public virtual string RegisterLabel { get { if (!__registerlabel_set) __registerlabel = GetFieldValue<string>("RegisterLabel"); __registerlabel_set = true; return __registerlabel; } set { __registerlabel = value; __registerlabel_set = true; } }

	}
	public partial class Module_Faqs : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private IAgilityContentRepository<FaqItem> __faqs = null;
		public virtual IAgilityContentRepository<FaqItem> Faqs { get { if (__faqs == null) __faqs = GetLinkedContent<FaqItem>("Faqs", "", "Question ", ""); return __faqs; } set { __faqs = value; } }

	}
	public partial class Module_FeatureBlocks : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __featureblockids = null;
		private bool __featureblockids_set = false;
		public virtual string FeatureBlockIDs { get { if (!__featureblockids_set) __featureblockids = GetFieldValue<string>("FeatureBlockIDs"); __featureblockids_set = true; return __featureblockids; } set { __featureblockids = value; __featureblockids_set = true; } }
		private string __featureblocknames = null;
		private bool __featureblocknames_set = false;
		public virtual string FeatureBlockNames { get { if (!__featureblocknames_set) __featureblocknames = GetFieldValue<string>("FeatureBlockNames"); __featureblocknames_set = true; return __featureblocknames; } set { __featureblocknames = value; __featureblocknames_set = true; } }
		private IAgilityContentRepository<FeatureBlock> __featureblocks = null;
		public virtual IAgilityContentRepository<FeatureBlock> FeatureBlocks { get { if (__featureblocks == null) __featureblocks = GetLinkedContent<FeatureBlock>("FeatureBlocks", "", "Title ", ""); return __featureblocks; } set { __featureblocks = value; } }

	}
	public partial class Module_FeatureBlocksWithText : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __sidetitle = null;
		private bool __sidetitle_set = false;
		public virtual string SideTitle { get { if (!__sidetitle_set) __sidetitle = GetFieldValue<string>("SideTitle"); __sidetitle_set = true; return __sidetitle; } set { __sidetitle = value; __sidetitle_set = true; } }
		private string __sidebody = null;
		private bool __sidebody_set = false;
		public virtual string SideBody { get { if (!__sidebody_set) __sidebody = GetFieldValue<string>("SideBody"); __sidebody_set = true; return __sidebody; } set { __sidebody = value; __sidebody_set = true; } }
		private string __sidelink = null;
		private bool __sidelink_set = false;
		public virtual string SideLink { get { if (!__sidelink_set) __sidelink = GetFieldValue<string>("SideLink"); __sidelink_set = true; return __sidelink; } set { __sidelink = value; __sidelink_set = true; } }
		private string __featureblockids = null;
		private bool __featureblockids_set = false;
		public virtual string FeatureBlockIDs { get { if (!__featureblockids_set) __featureblockids = GetFieldValue<string>("FeatureBlockIDs"); __featureblockids_set = true; return __featureblockids; } set { __featureblockids = value; __featureblockids_set = true; } }
		private string __featureblocknames = null;
		private bool __featureblocknames_set = false;
		public virtual string FeatureBlockNames { get { if (!__featureblocknames_set) __featureblocknames = GetFieldValue<string>("FeatureBlockNames"); __featureblocknames_set = true; return __featureblocknames; } set { __featureblocknames = value; __featureblocknames_set = true; } }
		private IAgilityContentRepository<FeatureBlock> __featureblocks = null;
		public virtual IAgilityContentRepository<FeatureBlock> FeatureBlocks { get { if (__featureblocks == null) __featureblocks = GetLinkedContent<FeatureBlock>("FeatureBlocks", "", "Title ", ""); return __featureblocks; } set { __featureblocks = value; } }

	}
	public partial class Module_FormBuilder : Agility.Web.AgilityContentItem
	{
		private string __recordtypename = null;
		private bool __recordtypename_set = false;
		public virtual string RecordTypeName { get { if (!__recordtypename_set) __recordtypename = GetFieldValue<string>("RecordTypeName"); __recordtypename_set = true; return __recordtypename; } set { __recordtypename = value; __recordtypename_set = true; } }
		private string __responsetype = null;
		private bool __responsetype_set = false;
		public virtual string ResponseType { get { if (!__responsetype_set) __responsetype = GetFieldValue<string>("ResponseType"); __responsetype_set = true; return __responsetype; } set { __responsetype = value; __responsetype_set = true; } }
		private string __thankyoutemplate = null;
		private bool __thankyoutemplate_set = false;
		public virtual string ThankYouTemplate { get { if (!__thankyoutemplate_set) __thankyoutemplate = GetFieldValue<string>("ThankYouTemplate"); __thankyoutemplate_set = true; return __thankyoutemplate; } set { __thankyoutemplate = value; __thankyoutemplate_set = true; } }
		private string __redirecturl = null;
		private bool __redirecturl_set = false;
		public virtual string RedirectURL { get { if (!__redirecturl_set) __redirecturl = GetFieldValue<string>("RedirectURL"); __redirecturl_set = true; return __redirecturl; } set { __redirecturl = value; __redirecturl_set = true; } }
		private bool __includecaptcha;
		private bool __includecaptcha_set = false;
		public virtual bool IncludeCaptcha { get { if (!__includecaptcha_set) __includecaptcha = GetFieldValue<bool>("IncludeCaptcha"); __includecaptcha_set = true; return __includecaptcha; } set { __includecaptcha = value; __includecaptcha_set = true; } }
		private string __errortemplate = null;
		private bool __errortemplate_set = false;
		public virtual string ErrorTemplate { get { if (!__errortemplate_set) __errortemplate = GetFieldValue<string>("ErrorTemplate"); __errortemplate_set = true; return __errortemplate; } set { __errortemplate = value; __errortemplate_set = true; } }
		private bool __submitasemail;
		private bool __submitasemail_set = false;
		public virtual bool SubmitasEmail { get { if (!__submitasemail_set) __submitasemail = GetFieldValue<bool>("SubmitasEmail"); __submitasemail_set = true; return __submitasemail; } set { __submitasemail = value; __submitasemail_set = true; } }
		private string __emailsendto = null;
		private bool __emailsendto_set = false;
		public virtual string EmailSendTo { get { if (!__emailsendto_set) __emailsendto = GetFieldValue<string>("EmailSendTo"); __emailsendto_set = true; return __emailsendto; } set { __emailsendto = value; __emailsendto_set = true; } }
		private string __emailfrom = null;
		private bool __emailfrom_set = false;
		public virtual string EmailFrom { get { if (!__emailfrom_set) __emailfrom = GetFieldValue<string>("EmailFrom"); __emailfrom_set = true; return __emailfrom; } set { __emailfrom = value; __emailfrom_set = true; } }
		private string __emailsubjecttemplate = null;
		private bool __emailsubjecttemplate_set = false;
		public virtual string EmailSubjectTemplate { get { if (!__emailsubjecttemplate_set) __emailsubjecttemplate = GetFieldValue<string>("EmailSubjectTemplate"); __emailsubjecttemplate_set = true; return __emailsubjecttemplate; } set { __emailsubjecttemplate = value; __emailsubjecttemplate_set = true; } }
		private string __emailbodytemplate = null;
		private bool __emailbodytemplate_set = false;
		public virtual string EmailBodyTemplate { get { if (!__emailbodytemplate_set) __emailbodytemplate = GetFieldValue<string>("EmailBodyTemplate"); __emailbodytemplate_set = true; return __emailbodytemplate; } set { __emailbodytemplate = value; __emailbodytemplate_set = true; } }
		private bool __customizeform;
		private bool __customizeform_set = false;
		public virtual bool CustomizeForm { get { if (!__customizeform_set) __customizeform = GetFieldValue<bool>("CustomizeForm"); __customizeform_set = true; return __customizeform; } set { __customizeform = value; __customizeform_set = true; } }
		private string __submissionform = null;
		private bool __submissionform_set = false;
		public virtual string SubmissionForm { get { if (!__submissionform_set) __submissionform = GetFieldValue<string>("SubmissionForm"); __submissionform_set = true; return __submissionform; } set { __submissionform = value; __submissionform_set = true; } }
		private bool __submitintougc;
		private bool __submitintougc_set = false;
		public virtual bool SubmitIntoUGC { get { if (!__submitintougc_set) __submitintougc = GetFieldValue<bool>("SubmitIntoUGC"); __submitintougc_set = true; return __submitintougc; } set { __submitintougc = value; __submitintougc_set = true; } }

	}
	public partial class Module_InfoBox : Agility.Web.AgilityContentItem
	{
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true; } }

	}
	public partial class Module_LatestPosts : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private int __postcount;
		private bool __postcount_set = false;
		public virtual int PostCount { get { if (!__postcount_set) __postcount = GetFieldValue<int>("PostCount"); __postcount_set = true; return __postcount; } set { __postcount = value; __postcount_set = true; } }
		private IAgilityContentRepository<BlogPost> __posts = null;
		public virtual IAgilityContentRepository<BlogPost> Posts { get { if (__posts == null) __posts = GetLinkedContent<BlogPost>("Posts"); return __posts; } set { __posts = value; } }
		private string __categoryids = null;
		private bool __categoryids_set = false;
		public virtual string CategoryIDs { get { if (!__categoryids_set) __categoryids = GetFieldValue<string>("CategoryIDs"); __categoryids_set = true; return __categoryids; } set { __categoryids = value; __categoryids_set = true; } }
		private string __categorynames = null;
		private bool __categorynames_set = false;
		public virtual string CategoryNames { get { if (!__categorynames_set) __categorynames = GetFieldValue<string>("CategoryNames"); __categorynames_set = true; return __categorynames; } set { __categorynames = value; __categorynames_set = true; } }
		private IAgilityContentRepository<BlogCategory> __categories = null;
		public virtual IAgilityContentRepository<BlogCategory> Categories { get { if (__categories == null) __categories = GetLinkedContent<BlogCategory>("Categories"); return __categories; } set { __categories = value; } }
		private string __readmorelabel = null;
		private bool __readmorelabel_set = false;
		public virtual string ReadMoreLabel { get { if (!__readmorelabel_set) __readmorelabel = GetFieldValue<string>("ReadMoreLabel"); __readmorelabel_set = true; return __readmorelabel; } set { __readmorelabel = value; __readmorelabel_set = true; } }

	}
	public partial class Module_LatestResources : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private string __lefttypetitle = null;
		private bool __lefttypetitle_set = false;
		public virtual string LeftTypeTitle { get { if (!__lefttypetitle_set) __lefttypetitle = GetFieldValue<string>("LeftTypeTitle"); __lefttypetitle_set = true; return __lefttypetitle; } set { __lefttypetitle = value; __lefttypetitle_set = true; } }
		private string __leftbutton = null;
		private bool __leftbutton_set = false;
		public virtual string LeftButton { get { if (!__leftbutton_set) __leftbutton = GetFieldValue<string>("LeftButton"); __leftbutton_set = true; return __leftbutton; } set { __leftbutton = value; __leftbutton_set = true; } }
		private IAgilityContentRepository<Resource> __resources = null;
		public virtual IAgilityContentRepository<Resource> Resources { get { if (__resources == null) __resources = GetLinkedContent<Resource>("Resources"); return __resources; } set { __resources = value; } }

	}
	public partial class Module_LogoListing : Agility.Web.AgilityContentItem
	{
		private string __heading = null;
		private bool __heading_set = false;
		public virtual string Heading { get { if (!__heading_set) __heading = GetFieldValue<string>("Heading"); __heading_set = true; return __heading; } set { __heading = value; __heading_set = true; } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true; } }
		private IAgilityContentRepository<Logo> __logos = null;
		public virtual IAgilityContentRepository<Logo> Logos { get { if (__logos == null) __logos = GetLinkedContent<Logo>("Logos", "", "ItemOrder ", ""); return __logos; } set { __logos = value; } }
		private string __logoids = null;
		private bool __logoids_set = false;
		public virtual string LogoIDs { get { if (!__logoids_set) __logoids = GetFieldValue<string>("LogoIDs"); __logoids_set = true; return __logoids; } set { __logoids = value; __logoids_set = true; } }
		private string __rendertype = null;
		private bool __rendertype_set = false;
		public virtual string RenderType { get { if (!__rendertype_set) __rendertype = GetFieldValue<string>("RenderType"); __rendertype_set = true; return __rendertype; } set { __rendertype = value; __rendertype_set = true; } }
		private string __primarybutton = null;
		private bool __primarybutton_set = false;
		public virtual string PrimaryButton { get { if (!__primarybutton_set) __primarybutton = GetFieldValue<string>("PrimaryButton"); __primarybutton_set = true; return __primarybutton; } set { __primarybutton = value; __primarybutton_set = true; } }
		private string __secondarybutton = null;
		private bool __secondarybutton_set = false;
		public virtual string SecondaryButton { get { if (!__secondarybutton_set) __secondarybutton = GetFieldValue<string>("SecondaryButton"); __secondarybutton_set = true; return __secondarybutton; } set { __secondarybutton = value; __secondarybutton_set = true; } }

	}
	public partial class Module_PartnerListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private string __lefttypetitle = null;
		private bool __lefttypetitle_set = false;
		public virtual string LeftTypeTitle { get { if (!__lefttypetitle_set) __lefttypetitle = GetFieldValue<string>("LeftTypeTitle"); __lefttypetitle_set = true; return __lefttypetitle; } set { __lefttypetitle = value; __lefttypetitle_set = true; } }
		private string __leftbutton = null;
		private bool __leftbutton_set = false;
		public virtual string LeftButton { get { if (!__leftbutton_set) __leftbutton = GetFieldValue<string>("LeftButton"); __leftbutton_set = true; return __leftbutton; } set { __leftbutton = value; __leftbutton_set = true; } }
		private IAgilityContentRepository<Logo> __partners = null;
		public virtual IAgilityContentRepository<Logo> Partners { get { if (__partners == null) __partners = GetLinkedContent<Logo>("Partners"); return __partners; } set { __partners = value; } }
		private IAgilityContentRepository<LogoTags> __tags = null;
		public virtual IAgilityContentRepository<LogoTags> Tags { get { if (__tags == null) __tags = GetLinkedContent<LogoTags>("Tags"); return __tags; } set { __tags = value; } }
		private string __dynamicpagepath = null;
		private bool __dynamicpagepath_set = false;
		public virtual string DynamicPagePath { get { if (!__dynamicpagepath_set) __dynamicpagepath = GetFieldValue<string>("DynamicPagePath"); __dynamicpagepath_set = true; return __dynamicpagepath; } set { __dynamicpagepath = value; __dynamicpagepath_set = true; } }
		private string __tagids = null;
		private bool __tagids_set = false;
		public virtual string TagIDs { get { if (!__tagids_set) __tagids = GetFieldValue<string>("TagIDs"); __tagids_set = true; return __tagids; } set { __tagids = value; __tagids_set = true; } }
		private string __tagnames = null;
		private bool __tagnames_set = false;
		public virtual string TagNames { get { if (!__tagnames_set) __tagnames = GetFieldValue<string>("TagNames"); __tagnames_set = true; return __tagnames; } set { __tagnames = value; __tagnames_set = true; } }

	}
	public partial class Module_PeopleListing : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string Subtitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("Subtitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private IAgilityContentRepository<Person> __people = null;
		public virtual IAgilityContentRepository<Person> People { get { if (__people == null) __people = GetLinkedContent<Person>("People"); return __people; } set { __people = value; } }

	}
	public partial class Module_PostDetails : Agility.Web.AgilityContentItem
	{
		private string __categorylabel = null;
		private bool __categorylabel_set = false;
		public virtual string CategoryLabel { get { if (!__categorylabel_set) __categorylabel = GetFieldValue<string>("CategoryLabel"); __categorylabel_set = true; return __categorylabel; } set { __categorylabel = value; __categorylabel_set = true; } }
		private string __relatedpostslabel = null;
		private bool __relatedpostslabel_set = false;
		public virtual string RelatedPostsLabel { get { if (!__relatedpostslabel_set) __relatedpostslabel = GetFieldValue<string>("RelatedPostsLabel"); __relatedpostslabel_set = true; return __relatedpostslabel; } set { __relatedpostslabel = value; __relatedpostslabel_set = true; } }
		private int __relatedpostscount;
		private bool __relatedpostscount_set = false;
		public virtual int RelatedPostsCount { get { if (!__relatedpostscount_set) __relatedpostscount = GetFieldValue<int>("RelatedPostsCount"); __relatedpostscount_set = true; return __relatedpostscount; } set { __relatedpostscount = value; __relatedpostscount_set = true; } }

	}
	public partial class Module_PostListing : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<BlogPost> __posts = null;
		public virtual IAgilityContentRepository<BlogPost> Posts { get { if (__posts == null) __posts = GetLinkedContent<BlogPost>("Posts"); return __posts; } set { __posts = value; } }
		private int __postcount;
		private bool __postcount_set = false;
		public virtual int PostCount { get { if (!__postcount_set) __postcount = GetFieldValue<int>("PostCount"); __postcount_set = true; return __postcount; } set { __postcount = value; __postcount_set = true; } }

	}
	public partial class Module_ResourceDetails : Agility.Web.AgilityContentItem
	{

	}
	public partial class Module_RichTextArea : Agility.Web.AgilityContentItem
	{
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }

	}
	public partial class Module_SectionHeading : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }

	}
	public partial class Module_StayInTouch : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private IAgilityContentRepository<SocialFollowLink> __socialfollowlinks = null;
		public virtual IAgilityContentRepository<SocialFollowLink> SocialFollowLinks { get { if (__socialfollowlinks == null) __socialfollowlinks = GetLinkedContent<SocialFollowLink>("SocialFollowLinks"); return __socialfollowlinks; } set { __socialfollowlinks = value; } }

	}
	public partial class Module_TabPanels : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __subtitle = null;
		private bool __subtitle_set = false;
		public virtual string SubTitle { get { if (!__subtitle_set) __subtitle = GetFieldValue<string>("SubTitle"); __subtitle_set = true; return __subtitle; } set { __subtitle = value; __subtitle_set = true; } }
		private string __tabpanelids = null;
		private bool __tabpanelids_set = false;
		public virtual string TabPanelIDs { get { if (!__tabpanelids_set) __tabpanelids = GetFieldValue<string>("TabPanelIDs"); __tabpanelids_set = true; return __tabpanelids; } set { __tabpanelids = value; __tabpanelids_set = true; } }
		private string __tabpanelnames = null;
		private bool __tabpanelnames_set = false;
		public virtual string TabPanelNames { get { if (!__tabpanelnames_set) __tabpanelnames = GetFieldValue<string>("TabPanelNames"); __tabpanelnames_set = true; return __tabpanelnames; } set { __tabpanelnames = value; __tabpanelnames_set = true; } }
		private IAgilityContentRepository<TabPanel> __tabpanels = null;
		public virtual IAgilityContentRepository<TabPanel> TabPanels { get { if (__tabpanels == null) __tabpanels = GetLinkedContent<TabPanel>("TabPanels", "", "ItemOrder ", ""); return __tabpanels; } set { __tabpanels = value; } }

	}
	public partial class Module_Testimonials : Agility.Web.AgilityContentItem
	{
		private string __header = null;
		private bool __header_set = false;
		public virtual string Header { get { if (!__header_set) __header = GetFieldValue<string>("Header"); __header_set = true; return __header; } set { __header = value; __header_set = true; } }
		private string __subheading = null;
		private bool __subheading_set = false;
		public virtual string SubHeading { get { if (!__subheading_set) __subheading = GetFieldValue<string>("SubHeading"); __subheading_set = true; return __subheading; } set { __subheading = value; __subheading_set = true; } }
		private string __testimonialids = null;
		private bool __testimonialids_set = false;
		public virtual string TestimonialIDs { get { if (!__testimonialids_set) __testimonialids = GetFieldValue<string>("TestimonialIDs"); __testimonialids_set = true; return __testimonialids; } set { __testimonialids = value; __testimonialids_set = true; } }
		private IAgilityContentRepository<Testimonial> __testimonials = null;
		public virtual IAgilityContentRepository<Testimonial> Testimonials { get { if (__testimonials == null) __testimonials = GetLinkedContent<Testimonial>("Testimonials"); return __testimonials; } set { __testimonials = value; } }
		private string __bottomlink = null;
		private bool __bottomlink_set = false;
		public virtual string BottomLink { get { if (!__bottomlink_set) __bottomlink = GetFieldValue<string>("BottomLink"); __bottomlink_set = true; return __bottomlink; } set { __bottomlink = value; __bottomlink_set = true; } }

	}

}
