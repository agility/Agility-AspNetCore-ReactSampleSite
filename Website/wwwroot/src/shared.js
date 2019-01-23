import React from 'react'
import ReactDOM from 'react-dom'
import ReactDOMServer from 'react-dom/server'
global['React'] = React;
global['ReactDOM'] = ReactDOM;
global['ReactDOMServer'] = ReactDOMServer;


//React Components
import ContentPanel from './components/content-panel.jsx'
import FeatureBlocks from './components/feature-blocks.jsx'
import LogoListing from './components/logo-listing.jsx'
import LogoCloud from './components/logo-cloud.jsx'
import Header from './components/header.jsx'
import Footer from './components/footer.jsx'


global['Components'] = {
  FeatureBlocks,
  ContentPanel,
  LogoCloud,
  LogoListing,
  Header,
  Footer
}


