import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel-right.json'

import BlogListingTemplate from '../../components/blog-listing.jsx'
import BlogListingTemplateProps from '../data/podcast-listing.json'

import StayInTouchBox from '../../components/stay-in-touch-box.jsx'
import StayInTouchBoxProps from '../data/subscribe-to-podcast.json'

class PodcastListing extends Component {
    render() {

        return (
            <div id="podcast-listing-page">
                <ContentPanel {...ContentPanelProps } />
                <div className="p-w blog-listing-page">
                    <div className="row-my">
                        <div className="col-md-7">
                            <BlogListingTemplate {...BlogListingTemplateProps } />
                            <div className="load-more">
                                <a href="#">Load more</a>
                            </div>
                        </div>
                        <div className="col-md-5">
                            <div className="right-col">
                                <StayInTouchBox {...StayInTouchBoxProps } />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default hot(PodcastListing);