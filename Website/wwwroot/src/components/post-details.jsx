import React from 'react';
import { hot } from 'react-hot-loader/root'
import './post-details.sass'


class PostDetails extends React.Component {
    render() {
        return (
            <div class="postDetails">
                <h1>{this.props.post.title}</h1>
                <h2> Post Detail</h2>
            </div>
        );
    }
}
export default hot(PostDetails);

