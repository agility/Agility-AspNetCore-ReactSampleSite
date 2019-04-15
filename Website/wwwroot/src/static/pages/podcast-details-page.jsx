import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import PodcastDetails from '../../components/podcast-details.jsx'
import PodcastDetailsProps from '../data/podcast-details.json'

class PodcastDetailsPage extends Component {
    render() {

        var body = document.getElementById('frontend-only');
        body.classList.add('shadow');

        return (
            <div id="podcast-post-details">
                <PodcastDetails {...PodcastDetailsProps } />
            </div>
        );
    }
}

export default hot(PodcastDetailsPage);