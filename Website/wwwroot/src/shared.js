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
import FeatureBlocks from './components/feature-blocks.jsx'
import LogoListing from './components/logo-listing.jsx'
import TabPanels from './components/tab-panels.jsx'
import TabPanelsProducts from './components/tab-panels-products.jsx'
import LogoCloud from './components/logo-cloud.jsx'
import PostDetails from './components/post-details.jsx'
import PostListing from './components/post-listing.jsx'
import ProductsStaff from './components/products-staff.jsx'
import ProductsFeatures from './components/products-features.jsx'
import SectionHeading from './components/section-heading.jsx'
import ContactUs from './components/contact-us.jsx'


global['Components'] = {
  FeatureBlocks,
  ContentPanel,
  TabPanels,
  TabPanelsProducts,
  LogoCloud,
  LogoListing,
  PostDetails,
  PostListing,
  ProductsStaff,
  ProductsFeatures,
  SectionHeading,
  ContactUs,
  Header,
  Footer
}


