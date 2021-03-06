import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import FeaturedResources from '../../components/featured-resources.jsx'
import FeaturedResourcesProps from '../data/featured-resources.json'

import FilteredListing from '../../components/filtered-listing.jsx'
import FilteredListingProps from '../data/filtered-listing.json'

import FeaturedCaseStudies from '../../components/featured-case-studies.jsx'
import FeaturedCaseStudiesProps from '../data/featured-case-studies.json'

import LatestBlogPosts from '../../components/latest-blog-posts.jsx'
import LatestBlogPostsProps from '../data/latest-blog-posts.json'

class Resources extends Component {
    render() {

        var body = document.getElementById('frontend-only');
        body.classList.add('shadow');

        return (
            <div id="resource-page">
                <FeaturedResources {...FeaturedResourcesProps } />
                <FilteredListing {...FilteredListingProps } />
                <FeaturedCaseStudies {...FeaturedCaseStudiesProps } />
                <LatestBlogPosts {...LatestBlogPostsProps } />
            </div>
        );
    }
}

export default hot(Resources);