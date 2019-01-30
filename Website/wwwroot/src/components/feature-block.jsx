import React from 'react';
import { hot } from 'react-hot-loader/root'


class FeatureBlock extends React.Component {
    render() {

        return (

            <div className="ben-item slide">
                <div className="img"><img src={this.props.data.icon.url} alt={this.props.data.icon.label} /></div>
                <h3 className="ben-title">{this.props.data.title}</h3>
                <div dangerouslySetInnerHTML={{ __html: this.props.data.textBlob }} />
            </div>
        );
    }
}

export default hot(FeatureBlock);
