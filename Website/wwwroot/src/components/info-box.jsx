import React from 'react';
import { hot } from 'react-hot-loader/root'
import './info-box.sass'

class InfoBox extends React.Component {

    render() {

        return (

            <div className="info-box">
                <h4 className="h4">{this.props.title}</h4>
                <div className="about">
                    <p dangerouslySetInnerHTML={{__html: this.props.content}}></p>
                </div>
            </div>

        );
    }
}
export default hot(InfoBox);