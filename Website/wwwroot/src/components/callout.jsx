import React from 'react';
import { hot } from 'react-hot-loader/root'
import './callout.sass'

class Callout extends React.Component {

    render() {

        var bgColor = this.props.bgColor;
        var buttonColor = this.props.buttonColor;
        var bgColorStyle = {background: bgColor};
        var buttonBG = {background: buttonColor};
        return (

            <section className="features p-w callout" style={bgColorStyle}>
                <h3 className="h3">{this.props.title}</h3>
                <p>{this.props.subTitle}</p>
                <a href={this.props.primaryButton.href} className="btn" target={this.props.primaryButton.target} style={buttonBG}>{this.props.primaryButton.text}</a>
            </section>


        );
    }
}
export default hot(Callout);