import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel-right.json'

import Pricing from '../../components/pricing.jsx'
import PricingProps from '../data/pricing.json'

import FAQs from '../../components/faqs.jsx'
import FAQsProps from '../data/faqs.json'

class PricingPage extends Component {
  render() {

    return (
      <div id="pricing-page">
        <ContentPanel {...ContentPanelProps } />
        <Pricing {...PricingProps } />
        <FAQs {...FAQsProps} />
      </div>
    );
  }
}

export default hot(PricingPage);