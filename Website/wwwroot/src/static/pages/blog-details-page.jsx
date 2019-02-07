import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import BlogPostDetails from '../../components/blog-post-details.jsx'
import BlogPostDetailsProps from '../data/blog-post-details.json'

class BlogPost extends Component {
    render() {

        return (
            <div id="blog-post-details">
                <BlogPostDetails {...BlogPostDetailsProps } />
            </div>
        );
    }
}

export default hot(BlogPost);