import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import PeopleListing from '../../components/people-listing.jsx'
import PeopleListingProps from '../data/people-listing-leadership.json'
import PeopleListingBoardProps from '../data/people-listing-advisory-board.json'

class Team extends Component {
    render() {

        return (
            <div id="team-page">
                <div className="team-top">
                    <PeopleListing {...PeopleListingProps } />
                </div>
                <div className="team-bottom">
                    <PeopleListing {...PeopleListingBoardProps } />
                </div>
            </div>
        );
    }
}

export default hot(Team);