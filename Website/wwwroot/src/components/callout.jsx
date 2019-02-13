import React from 'react';
import { hot } from 'react-hot-loader/root'
import './callout.sass'

class Callout extends React.Component {

    render() {
        var isPrimaryTheme = this.props.theme === 'primary';
        var calloutClasses = 'features p-w callout' + (!isPrimaryTheme ? ' callout-secondary' : '');
        var buttonClasses = 'btn' + (isPrimaryTheme ? ' btn-secondary' : '');

        return (

            <section className={calloutClasses}>
                <h3>{this.props.title}</h3>
                <p>{this.props.caption}</p>
                <a href={this.props.link.href} className={buttonClasses} target={this.props.link.target}>{this.props.link.text}</a>
            </section>


        );
    }
}
export default hot(Callout);