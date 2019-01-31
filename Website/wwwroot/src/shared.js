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

// -- modules
import ContentPanel from './components/content-panel.jsx'
import ComunitySummit from './components/comunity-summit.jsx'
import EventListing from './components/event-listing.jsx'
import CtaBlocks from './components/cta-blocks.jsx'
import FeatureBlocks from './components/feature-blocks.jsx'
import FeatureBlocksWithText from './components/feature-blocks-w-text.jsx'
import LogoListing from './components/logo-listing.jsx'
import TabPanels from './components/tab-panels.jsx'
import LogoCloud from './components/logo-cloud.jsx'
import PostDetails from './components/post-details.jsx'
import PostListing from './components/post-listing.jsx'
import TestimonialsListing from './components/testimonials-listing.jsx'
import ProductsFeatures from './components/feature-block-w-text.jsx'
import SectionHeading from './components/section-heading.jsx'
import Testimonials from './components/testimonials.jsx'
import ContactUs from './components/contact-us.jsx'


global['Components'] = {
  FeatureBlocks,
  ComunitySummit,
  EventListing,
  CtaBlocks,
  FeatureBlocksWithText,
  ContentPanel,
  TabPanels,
  LogoCloud,
  LogoListing,
  PostDetails,
  PostListing,
  TestimonialsListing,
  ProductsFeatures,
  SectionHeading,
  Testimonials,
  ContactUs,
  Header,
  Footer
}


