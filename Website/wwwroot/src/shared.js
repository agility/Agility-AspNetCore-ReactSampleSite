import React from 'react'
import ReactDOM from 'react-dom'
import ReactDOMServer from 'react-dom/server'
global['React'] = React;
global['ReactDOM'] = ReactDOM;
global['ReactDOMServer'] = ReactDOMServer;

//React Components

// -- global
import Header from './components/header.jsx'
import Footer from './components/footer.jsx'
import AnimatedBg from './components/animated-bg.jsx'
import GlobalScripts from './components/global-scripts.jsx'


// -- modules
import CaseDetails from './components/case-study-details.jsx'
import CaseStudyContentPanel from './components/case-study-content-panel.jsx'
import ContentPanel from './components/content-panel.jsx'
import ComunitySummit from './components/comunity-summit.jsx'
import Callout from './components/callout.jsx'
import EventListing from './components/event-listing.jsx'
import CtaBlocks from './components/cta-blocks.jsx'
import FeatureBlocks from './components/feature-blocks.jsx'
import FeatureBlocksWithText from './components/feature-blocks-w-text.jsx'
import JobListing from './components/job-listing.jsx'
import FeaturedResources from './components/featured-resources.jsx'
import FeaturedCaseStudies from './components/featured-case-studies.jsx'
import FAQs from './components/faqs.jsx'
import RequestADemo from './components/request-a-demo.jsx'
import BecomeAPartner from './components/become-a-partner.jsx'

import InfoBox from './components/info-box.jsx'
import LogoListing from './components/logo-listing.jsx'
import FilteredListing from './components/filtered-listing.jsx'
import LatestBlogPosts from './components/latest-blog-posts.jsx'
import ListenToPodcast from './components/listen-to-podcast.jsx'
import PodcastListing from './components/podcast-listing.jsx'

import Pricing from './components/pricing.jsx'
import TabPanels from './components/tab-panels.jsx'
import PeopleListing from './components/people-listing.jsx'
import LogoCloud from './components/logo-cloud.jsx'
import PostDetails from './components/post-details.jsx'
import PodcastDetails from './components/podcast-details.jsx'
import PostListing from './components/post-listing.jsx'
import ResourceDetails from './components/resource-details.jsx'
import CaseStudyDetails from './components/case-study-details.jsx'
import PartnerDetails from './components/partner-details.jsx'
import PartnerContentPanel from './components/partner-content-panel.jsx'


import TestimonialsListing from './components/testimonials-listing.jsx'
import RichText from './components/rich-text.jsx'
import SectionHeading from './components/section-heading.jsx'
import StayInTouchBox from './components/stay-in-touch-box.jsx'
import ContactUs from './components/contact-us.jsx'
import Blank from './components/blank.jsx'
import Share from './components/share.jsx'


global['Components'] = {
  Blank,
  FeatureBlocks,
  CaseDetails,
  CaseStudyContentPanel,
  PartnerDetails,
  PartnerContentPanel,
  ComunitySummit,
  Callout,
  EventListing,
  CtaBlocks,
  FeatureBlocksWithText,
  Pricing,
  JobListing,
  FeaturedResources,
  FeaturedCaseStudies,
  FAQs,
  RequestADemo,
  BecomeAPartner,
  InfoBox,
  ContentPanel,
  TabPanels,
  FilteredListing,
  LatestBlogPosts,
  ListenToPodcast,
  LogoCloud,
  LogoListing,
  PeopleListing,
  PostDetails,
  PostListing,
  PodcastDetails,
  PodcastListing,
  CaseStudyDetails,
  ResourceDetails,
  TestimonialsListing,
  RichText,
  SectionHeading,
  ContactUs,
  Header,
  Footer,
  StayInTouchBox,
  AnimatedBg,
  GlobalScripts,
  Share
}


