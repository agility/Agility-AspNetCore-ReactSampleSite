import React from 'react';
import { hot } from 'react-hot-loader/root'
import './listen-to-podcast.scss'

class StayInTouchBox extends React.Component {

    render() {
        console.log(this.props);


        var four = this.props.items.map(function (item) {
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
            <a href={this.props.item.url.href} target="_blank"><img src={this.props.item.image.url} alt={this.props.item.image.label} /></a>
        );
    }
}