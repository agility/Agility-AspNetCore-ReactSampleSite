import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel-right.json'
import ContentPanelPropsLeft from '../data/content-panel-left.json'


import EventListing from '../../components/event-listing.jsx'
import EventListingProps from '../data/event-listing.json'

import CtaBlocks from '../../components/cta-blocks.jsx'
import CtaBlocksProps from '../data/cta-blocks.json'

class Community extends Component {
    render() {

        return (
            <div id="comunity-page">
                <ContentPanel {...ContentPanelProps } />
                <ContentPanel {...ContentPanelPropsLeft } />
                <EventListing {...EventListingProps } />
                <CtaBlocks {...CtaBlocksProps } />
            </div>
        );
    }
}

export default hot(Community);