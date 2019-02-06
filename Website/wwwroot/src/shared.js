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

// -- modules
import BlogListing from './components/blog-listing.jsx'
import ContentPanel from './components/content-panel.jsx'
import ComunitySummit from './components/comunity-summit.jsx'
import Callout from './components/callout.jsx'
import EventListing from './components/event-listing.jsx'
import CtaBlocks from './components/cta-blocks.jsx'
import FeatureBlocks from './components/feature-blocks.jsx'
import FeatureBlocksWithText from './components/feature-blocks-w-text.jsx'
import FeaturedResources from './components/featured-resources.jsx'
import FeaturedCaseStudies from './components/featured-case-studies.jsx'
import FAQs from './components/faqs.jsx'
import InfoBox from './components/info-box.jsx'
import LogoListing from './components/logo-listing.jsx'
import LatestResources from './components/latest-resources.jsx'
import LatestBlogPosts from './components/latest-blog-posts.jsx'
import TabPanels from './components/tab-panels.jsx'
import LogoCloud from './components/logo-cloud.jsx'
import PostDetails from './components/post-details.jsx'
import PostListing from './components/post-listing.jsx'
import TestimonialsListing from './components/testimonials-listing.jsx'
import ProductsFeatures from './components/feature-block-w-text.jsx'
import RichText from './components/rich-text.jsx'
import SectionHeading from './components/section-heading.jsx'
import StayInTouchBox from './components/stay-in-touch-box.jsx'
import ContactUs from './components/contact-us.jsx'


global['Components'] = {
  BlogListing,
  FeatureBlocks,
  ComunitySummit,
  Callout,
  EventListing,
  CtaBlocks,
  FeatureBlocksWithText,
  FeaturedResources,
  FeaturedCaseStudies,
  FAQs,
  InfoBox,
  ContentPanel,
  TabPanels,
  LatestResources,
  LatestBlogPosts,
  LogoCloud,
  LogoListing,
  PostDetails,
  PostListing,
  TestimonialsListing,
  ProductsFeatures,
  RichText,
  SectionHeading,
  ContactUs,
  Header,
  Footer,
  StayInTouchBox,
  AnimatedBg
}


