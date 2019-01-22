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
	public partial class ContentPanel : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __textarea = null;
		private bool __textarea_set = false;
		public virtual string TextArea { get { if (!__textarea_set) __textarea = GetFieldValue<string>("TextArea"); __textarea_set = true; return __textarea; } set { __textarea = value; __textarea_set = true; } }
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
		private string __followlinkids = null;
		private bool __followlinkids_set = false;
		public virtual string FollowLinkIDs { get { if (!__followlinkids_set) __followlinkids = GetFieldValue<string>("FollowLinkIDs"); __followlinkids_set = true; return __followlinkids; } set { __followlinkids = value; __followlinkids_set = true; } }
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
	public partial class Module_ContentPanel : Agility.Web.AgilityContentItem
	{
		private IAgilityContentRepository<ContentPanel> __panel = null;
		public virtual IAgilityContentRepository<ContentPanel> Panel { get { if (__panel == null) __panel = GetLinkedContent<ContentPanel>("Panel"); return __panel; } set { __panel = value; } }
		private int __panelid;
		private bool __panelid_set = false;
		public virtual int PanelID { get { if (!__panelid_set) __panelid = GetFieldValue<int>("PanelID"); __panelid_set = true; return __panelid; } set { __panelid = value; __panelid_set = true; } }

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
	public partial class Module_LogoListing : Agility.Web.AgilityContentItem
	{
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
	public partial class Module_RichTextArea : Agility.Web.AgilityContentItem
	{
		private string __textblob = null;
		private bool __textblob_set = false;
		public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }

	}
	public partial class Module_TabPanels : Agility.Web.AgilityContentItem
	{
		private string __title = null;
		private bool __title_set = false;
		public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
		private string __tabpanelids = null;
		private bool __tabpanelids_set = false;
		public virtual string TabPanelIDs { get { if (!__tabpanelids_set) __tabpanelids = GetFieldValue<string>("TabPanelIDs"); __tabpanelids_set = true; return __tabpanelids; } set { __tabpanelids = value; __tabpanelids_set = true; } }
		private string __tabpanelnames = null;
		private bool __tabpanelnames_set = false;
		public virtual string TabPanelNames { get { if (!__tabpanelnames_set) __tabpanelnames = GetFieldValue<string>("TabPanelNames"); __tabpanelnames_set = true; return __tabpanelnames; } set { __tabpanelnames = value; __tabpanelnames_set = true; } }
		private IAgilityContentRepository<TabPanel> __tabpanels = null;
		public virtual IAgilityContentRepository<TabPanel> TabPanels { get { if (__tabpanels == null) __tabpanels = GetLinkedContent<TabPanel>("TabPanels", "", "ItemOrder ", ""); return __tabpanels; } set { __tabpanels = value; } }

	}

}