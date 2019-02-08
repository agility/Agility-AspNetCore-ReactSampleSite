import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import FeaturedResources from '../../components/featured-resources.jsx'
import FeaturedResourcesProps from '../data/featured-resources.json'

import LatestResources from '../../components/latest-resources.jsx'
import LatestResourcesProps from '../data/latest-resources.json'

import FeaturedCaseStudies from '../../components/featured-case-studies.jsx'
import FeaturedCaseStudiesProps from '../data/featured-case-studies.json'

import LatestBlogPosts from '../../components/latest-blog-posts.jsx'
import LatestBlogPostsProps from '../data/latest-blog-posts.json'

class Resources extends Component {
    render() {

        return (
            <div id="resource-page" className="header-shadow">
                <FeaturedResources {...FeaturedResourcesProps } />
                <LatestResources {...LatestResourcesProps } />
                <FeaturedCaseStudies {...FeaturedCaseStudiesProps } />
                <LatestBlogPosts {...LatestBlogPostsProps } />
            </div>
        );
    }
}

export default hot(Resources);