import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import PostListing from '../../components/post-listing.jsx'
import PostListingProps from '../data/blog-listing.json'

import StayInTouchBox from '../../components/stay-in-touch-box.jsx'
import StayInTouchBoxProps from '../data/stay-in-touch-box.json'

import InfoBox from '../../components/info-box.jsx'
import InfoBoxProps from '../data/info-box.json'

class BlogListing extends Component {
    render() {

        var body = document.getElementById('frontend-only');
        body.classList.add('shadow');

        return (

            <div className="p-w two-column-page">
                <div className="container-my">
                    <div className="row-my">
                        <div className="col-md-7">
                            <PostListing {...PostListingProps } />
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