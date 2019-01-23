import React from 'react'
import ReactDOM from 'react-dom'
import ReactDOMServer from 'react-dom/server'
global['React'] = React;
global['ReactDOM'] = ReactDOM;
global['ReactDOMServer'] = ReactDOMServer;


//React Components
import ContentPanel from './components/content-panel.jsx'
import Header from './components/header.jsx'
import Footer from './components/footer.jsx'


global['Components'] = {
  ContentPanel,
  Header,
  Footer
}


