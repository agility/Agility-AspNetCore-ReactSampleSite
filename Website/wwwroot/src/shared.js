import React from 'react'
import ReactDOM from 'react-dom'
import ReactDOMServer from 'react-dom/server'
global['React'] = React;
global['ReactDOM'] = ReactDOM;
global['ReactDOMServer'] = ReactDOMServer;


//React Components
import ContentPanel from './components/content-panel.jsx'
import FeatureBlocks from './components/feature-blocks.jsx'
import Header from './components/header.jsx'
import Footer from './components/footer.jsx'


global['Components'] = {
  FeatureBlocks,
  ContentPanel,
  Header,
  Footer
}


