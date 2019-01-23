import React from 'react';
import { hot } from 'react-hot-loader/root'
import FeatureBlock from "./feature-block.jsx"
import './feature-blocks.scss'

class FeatureBlocks extends React.Component {
    render() {


        var features = this.props.features.map(function (f) {
            return <FeatureBlock data={f} key={f.key} />;
        })

        return (
            <div className="featureBlocks">
                <h2>{this.props.title}</h2>
                <div>{features}</div>
            </div>
        );
    }
}
export default hot(FeatureBlocks);

