import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import CaseStudyContentPanel from '../../components/case-study-content-panel.jsx'
import CaseStudyContentPanelProps from '../data/case-study-content-panel.json'

import CaseDetails from '../../components/case-study-details.jsx'
import CaseDetailsProps from '../data/case-study-details.json'

import LogoListing from '../../components/logo-listing.jsx'
import LogoListingProps from '../data/logo-listing.json'

class CaseStudyDetails extends Component {
    render() {

        return (
            <div id="case-study-details-page">
                <CaseStudyContentPanel {...CaseStudyContentPanelProps } />
                <CaseDetails {...CaseDetailsProps } />
                <LogoListing {...LogoListingProps } />
            </div>
        );
    }
}

export default hot(CaseStudyDetails);