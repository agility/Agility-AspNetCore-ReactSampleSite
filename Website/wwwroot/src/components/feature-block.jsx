import React from 'react';
import { hot } from 'react-hot-loader/root'
import './feature-block.scss'

class FeatureBlock extends React.Component {
    render() {

        return (

            <div className="featureBlock">
                <h2>{this.props.data.title}</h2>
                <div dangerouslySetInnerHTML={{ __html: this.props.data.textBlob }} />
                <div>
                    <img src={this.props.data.icon.url} alt={this.props.data.icon.label} />
                </div>
            </div>
        );
    }
}
export default hot(FeatureBlock);

