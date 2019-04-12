import React from 'react';
import { hot } from 'react-hot-loader/root'
import './podcast-listing.scss'
import moment from 'moment';

class PodcastListing extends React.Component {
    constructor(props) {
        super(props)
        
        this.loadMore = this.loadMore.bind(this);
        this.handleHistoryEvent = this.handleHistoryEvent.bind(this);

        this.state = {
            podcasts: this.props.podcasts,
            skip: this.props.podcasts.length,
            take: this.props.itemsPerPage,
            loadingMore: false,
            totalCount: this.props.totalCount,
            noMoreData: false,
            refName: this.props.refName,
            sortBy: this.props.sortBy
        };
    }

    componentDidMount() {
        this.handleHistoryEvent();
    }

    loadMore(event) {

        event.preventDefault();

        var url = "/Listing/Podcasts?sortBy=" + this.state.sortBy +"&refName=" + this.state.refName + "&skip=" + this.state.skip + "&take=" + this.state.take;

        this.setState({ loadingMore: true });

        fetch(url)
            .then(response => response.json())
            .then(data => {

                let noMore = false;
                if (!data.podcasts || !data.podcasts.length || data.podcasts.length == 0) {
                    noMore = true;
                }

                this.setState(prevState => ({
                    podcasts: prevState.podcasts.concat(data.podcasts),
                    loadingMore: false,
                    skip: prevState.skip + data.podcasts.length,
                    take: data.take,
                    noMoreData: noMore
                }));

                //set the state in the browser in case we come back
                window.history.replaceState(this.state, null);

            }).catch(err => {
                console.warn("An error occurred while loading more data...", err);
                this.setState(prevState => ({
                    loadingMore: false,
                    noMoreData: true
                }));
            });

        return false;
    }

    handleHistoryEvent() {
        var self = this;

        if (window != undefined
            && window
            && window.history
            && window.history.state) {

            //if we have some podcasts listed in the state, use them here
            let newState = window.history.state;
            if (newState.podcasts && newState.podcasts.length > 0) {

                self.setState(prevState => ({
                    podcasts: newState.podcasts,
                    loadingMore: false,
                    skip: newState.skip,
                    take: newState.take,
                    noMoreData: newState.noMoreData,
                    totalCount: newState.totalCount,
                    refName: newState.refName,
                    sortBy: newState.sortBy
                }));
            }
        }
    }

    render() {
        var podcasts = this.state.podcasts.map(function (item, index) {
            return <PodcastListedItem item={item} id={index} key={item.key} />
        });

        return (
            <div className="podcast-listing">
                {podcasts}

                {this.state.loadingMore &&
                    <div><a className="btn" disabled> Loading... </a></div>
                }
                {!this.state.loadingMore &&
                    !this.state.noMoreData &&
                    this.state.podcasts &&
                    this.state.podcasts.length < this.state.totalCount &&
                    <div className="load-more"><a href="#" onClick={this.loadMore} className="btn"> Load More</a></div>
                }
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