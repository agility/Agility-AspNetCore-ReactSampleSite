import React from 'react';
import { hot } from 'react-hot-loader/root'
import './stay-in-touch-box.scss'

class StayInTouchBox extends React.Component {

    render() {
        var four = this.props.links.map(function (item) {
            return <StayInTouchBoxContent item={item} key={item.key} />
        });

        return (

            <div className="stay-in-touch-box">
                <h4 className="h4">{this.props.title}</h4>
                <div className="social">
                    {four}
                </div>
            </div>

        );
    }
}
export default hot(StayInTouchBox);

class StayInTouchBoxContent extends React.Component {
    render() {

        return (
            <a
                href={this.props.item.followURL.href}
                target={this.props.item.followURL.target}>
                <img src={this.props.item.logo.url} alt="" />
                <span>{this.props.item.title}</span>
            </a>
        );
    }
}