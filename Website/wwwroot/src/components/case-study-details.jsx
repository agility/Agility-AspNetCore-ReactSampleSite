import React from 'react';
import { hot } from 'react-hot-loader/root'

import './case-study-details.sass'


class CaseStudyDetails extends React.Component {
    render() {
        return (
            <div className="caseStudyDetails">
                <h1>{this.props.item.title}</h1>
                <h2> Case Study Detail</h2>
            </div>
        );
    }
}
export default hot(CaseStudyDetails);

