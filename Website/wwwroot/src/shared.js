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
import LogoCloud from './components/logo-cloud.jsx'
import SectionHeading from './components/section-heading.jsx'



global['Components'] = {
  FeatureBlocks,
  ContentPanel,
  TabPanels,
  LogoCloud,
  LogoListing,
  SectionHeading,
  Header,
  Footer
}


