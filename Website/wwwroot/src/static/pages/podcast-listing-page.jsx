import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel-right.json'

import PodcastListing from '../../components/podcast-listing.jsx'
import PodcastListingProps from '../data/podcast-listing.json'

import ListenToPodcast from '../../components/listen-to-podcast.jsx'
import ListenToPodcastProps from '../data/listen-to-podcast.json'

class Podcast extends Component {
    render() {

        return (
            <div id="podcast-listing-page">
                <ContentPanel {...ContentPanelProps } />
                <div className="p-w podcast-listing two-column-page">
                    <div className="container-my">
                        <div className="row-my">
                            <PodcastListing {...PodcastListingProps } />
                            <ListenToPodcast {...ListenToPodcastProps } />
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default hot(Podcast);