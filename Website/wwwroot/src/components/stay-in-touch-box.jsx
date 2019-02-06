import React from 'react';
import { hot } from 'react-hot-loader/root'
import './stay-in-touch-box.sass'

class StayInTouchBox extends React.Component {

    render() {

        var four = this.props.items.map(function (items){
            return <StayInTouchBoxContent item={items} />
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
            <a href={this.props.item.href} target="_blank"><img src={this.props.item.ico.url} alt=""/><span>{this.props.item.title}</span></a>
        );
    }
}