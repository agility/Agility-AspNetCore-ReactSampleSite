import React from 'react';
import { hot } from 'react-hot-loader/root'
import './callout.scss'

class Callout extends React.Component {

    render() {
        var isPrimaryColor = this.props.theme === 'primary';
        var calloutClasses = 'features p-w callout' + (!isPrimaryColor ? ' callout-secondary' : '');
        var buttonClasses = 'btn' + (!isPrimaryColor ? ' btn-secondary' : '');

        return (

            <section className={calloutClasses}>
                {this.props.title && this.props.title.length > 0 &&
                <h3>{this.props.title}</h3>
                }
                {this.props.caption && this.props.caption.length > 0 &&
                <p>{this.props.caption}</p>
                }
                {this.props.link &&
                <a href={this.props.link.href} className={buttonClasses} target={this.props.link.target}>{this.props.link.text}</a>
                }
            </section>


        );
    }
}
export default hot(Callout);