import '../scss/global.scss'


import React from 'react'
import ReactDOM from 'react-dom'
import ReactDOMServer from 'react-dom/server'
global['React'] = React;
global['ReactDOM'] = ReactDOM;
global['ReactDOMServer'] = ReactDOMServer;


//React Components
import TestComponent from './test-component'


global['Components'] = {
  TestComponent
}


//support hot module reloading ;)
if (module.hot) {
  module.hot.accept();
}
