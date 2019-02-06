import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel-right.json'

import FeatureBlocks from '../../components/feature-blocks.jsx'
import FeatureBlocksProps from '../data/feature-blocks.json'

import TabPanels from '../../components/tab-panels.jsx'
import TabPanelsProps from '../data/tab-panels.json'

import LogoCloud from '../../components/logo-cloud.jsx'
import LogoCloudProps from '../data/logo-cloud.json'

import LogoListing from '../../components/logo-listing.jsx'
import LogoListingProps from '../data/logo-listing.json'

class Home extends Component {
  render() {

    return (
      <div id="home-page">        
        <ContentPanel {...ContentPanelProps } />
        <FeatureBlocks {...FeatureBlocksProps} />
        <TabPanels {...TabPanelsProps} />
        <LogoCloud {...LogoCloudProps} />
        <LogoListing {...LogoListingProps} />
      </div>
    );
  }
}

export default hot(Home);