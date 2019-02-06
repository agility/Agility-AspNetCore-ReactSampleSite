import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel-right.json'

import TabPanels from '../../components/tab-panels.jsx'
import TabPanelsProps from '../data/tab-panels.json'

import FAQs from '../../components/faqs.jsx'
import FAQsProps from '../data/faqs.json'

import LogoListing from '../../components/logo-listing.jsx'
import LogoListingProps from '../data/logo-listing.json'

import Callout from '../../components/callout.jsx'
import CalloutProps from '../data/callout.json'

class Partners extends Component {
  render() {

    return (
      <div id="partners-page">
        <ContentPanel {...ContentPanelProps } />
        <TabPanels {...TabPanelsProps} />
        <LogoListing {...LogoListingProps} />
        <FAQs {...FAQsProps} />
        <Callout {...CalloutProps} />
      </div>
    );
  }
}

export default hot(Partners);