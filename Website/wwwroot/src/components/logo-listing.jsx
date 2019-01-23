import React from 'react';
import { hot } from 'react-hot-loader/root'
import './tab-panel.sass'

class LogoListing extends React.Component {
    constructor() {
        super()
    }

    render() {

        const renderLogo = (logo) => {
            //render one tab
            return (
                <div key={logo.key}>
                    <h3>{logo.title}</h3>
                    <div>{logo.shortDescription}</div>
                    <div dangerouslySetInnerHTML={{ __html: logo.textBlob }} />
                    <div>
                        <img src={logo.logo.url} alt={logo.logo.label} />
                    </div>
                    <div>
                        <a href={logo.url.href} target={logo.url.target}>{logo.url.text}</a>
                    </div>
                </div>
            );
        }

        //loop all the tabs and render them
        const logos = this.props.logos.map(function (logo) {
            return renderLogo(logo)
        })

        return (
            <div className="logoListing">
                <h2>{this.props.renderType}</h2>

                {logos}

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
export default hot(LogoListing);

