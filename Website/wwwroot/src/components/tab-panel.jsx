import React from 'react';
import { hot } from 'react-hot-loader/root'
import './tab-panel.scss'

class ContentPanel extends React.Component {
    render() {
        return (
            <div className="tabPanel">
                <h2>{this.props.title}</h2>
                <div dangerouslySetInnerHTML={{ __html: this.props.textBlob }} />
                <div>
                    <span>{this.props.imagePosition}</span>
                    <img src={this.props.image.url} alt={this.props.image.label} />
                </div>
                <div>
                    <a href={this.props.primaryButton.href} target={this.props.primaryButton.target}>{this.props.primaryButton.text}</a>
                </div>
                <div>
                    <a href={this.props.secondaryButton.href} target={this.props.secondaryButton.target}>{this.props.secondaryButton.text}</a>
                </div>
            </div>
        );
    }
}
export default hot(ContentPanel);

