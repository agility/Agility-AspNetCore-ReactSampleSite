import React from 'react';
import { hot } from 'react-hot-loader/root'
import './listen-to-podcast.scss'

class ListenToPodcast extends React.Component {

    render() {



        var four = this.props.items.map(function (item) {
            return <ListenToPodcastContent item={item} key={item.key} />
        });

        return (

            <div className="listen-to-podcast">
                <h4 className="h4">{this.props.title}</h4>
                <div className="platform">
                    {four}
                </div>
            </div>


        );
    }
}
export default hot(ListenToPodcast);

class ListenToPodcastContent extends React.Component {
    render() {

        return (
            <a href={this.props.item.url.href} target="_blank"><img src={this.props.item.ico.url} alt="" /></a>
        );
    }
}