import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel.json'



import TabPanels from '../../components/tab-panels.jsx'
import TabPanelsProps from '../data/tab-panels.json'


class Product extends Component {
  render() {

    return (
      <div id="product-page">        
        <ContentPanel {...ContentPanelProps } />
        <TabPanels {...TabPanelsProps} />
      </div>
    );
  }
}

export default hot(Product);