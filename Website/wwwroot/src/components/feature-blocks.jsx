import React from 'react';
import { hot } from 'react-hot-loader/root'
import './feature-blocks.scss'

class ContentPanel extends React.Component {
    render() {
        console.log("props", this.props);
        return (
            <div className="featureBlocks">
                <h2>{this.props.title}</h2>
                <div>TODO: render the features in child components, or from a function call.</div>
            </div>
        );
    }
}
export default hot(ContentPanel);

