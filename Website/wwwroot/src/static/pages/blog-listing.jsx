import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import BlogListingTemplate from '../../components/blog-listing.jsx'
import BlogListingTemplateProps from '../data/blog-listing.json'

import StayInTouchBox from '../../components/stay-in-touch-box.jsx'
import StayInTouchBoxProps from '../data/stay-in-touch-box.json'

import InfoBox from '../../components/info-box.jsx'
import InfoBoxProps from '../data/info-box.json'

class BlogListing extends Component {
    render() {

        return (
            <div id="blog-listing-page">
                <div className="p-w blog-listing-page">
                    <div className="row-my">
                        <div className="col-md-7">
                            <BlogListingTemplate {...BlogListingTemplateProps } />
                        </div>
                        <div className="col-md-5">
                            <div className="right-col">
                                <StayInTouchBox {...StayInTouchBoxProps } />
                                <InfoBox {...InfoBoxProps } />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default hot(BlogListing);