import React from 'react';
import { hot } from 'react-hot-loader/root'
import './post-details.sass'


class ContactUs extends React.Component {
    render() {
        return (
            <div class="contactUs">

                {/* <h1>{this.props.post.title}</h1> */}
                <h2> Contact Us</h2>
            </div>
        );
    }
}
export default hot(ContactUs);

