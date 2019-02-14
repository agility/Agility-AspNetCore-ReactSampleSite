import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import PostDetails from '../../components/post-details.jsx'
import PostDetailsProps from '../data/blog-post-details.json'

class BlogPost extends Component {
    render() {

        var body = document.getElementById('frontend-only');
        body.classList.add('shadow');

        return (
            <div id="blog-post-details">
                <PostDetails {...PostDetailsProps } />
            </div>
        );
    }
}

export default hot(BlogPost);