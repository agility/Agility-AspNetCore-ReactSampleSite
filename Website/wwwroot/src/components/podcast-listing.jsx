import React from 'react';
import { hot } from 'react-hot-loader/root'
import './podcast-listing.scss'
import moment from 'moment';

class PodcastListing extends React.Component {

    render() {
        console.log(this.props)
        var items = this.props.items.map(function (item, index) {
            return <PodcastListedItem item={item} id={index} key={item.key} />
        });

        return (
            <div className="podcast-listing">
                {items}
                {/* <div className="load-more">
                    <a href="#">Load more</a>
                </div> */}
            </div>


        );
    }
}
export default hot(PodcastListing);

class PodcastListedItem extends React.Component {
    render() {

        return (
            <div className="podcast-episode">
                <a href={this.props.item.url}>
                    {this.props.item.image &&
                        <div className="image">
                            <div className="block-hover">
                                <img src={this.props.item.image.url} alt="" />
                                <div className="play d-flex jc-c ai-center"><img src="/dist/img/Triangle.svg" alt="" /></div>
                            </div>
                            <img src="/dist/img/podcast.svg" alt="" className="podcast" />
                        </div>
                    }
                </a>
                <div className="content">
                    <h3 className="h3"><a href={this.props.item.url}>{this.props.item.title}</a></h3>
                    <div className="author">
                        <h5 className="h5">Episode #{this.props.item.episodeNumber}</h5>
                    </div>
                    <div className="text"><p>{this.props.item.excerpt}</p></div>
                    <span className="date">{moment(this.props.item.date).format("LL")}</span>
                </div>
            </div>
        );
    }
}