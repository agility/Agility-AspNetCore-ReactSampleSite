import React from 'react';
import moment from 'moment'
import { hot } from 'react-hot-loader/root'
import './post-listing.scss'
import ResponsiveImage from './responsive-image.jsx'


class PostListing extends React.Component {
    constructor(props) {
        super(props)



        this.loadMore = this.loadMore.bind(this);
        this.handleHistoryEvent = this.handleHistoryEvent.bind(this);
        //init state from props
        this.state = {
            posts: this.props.posts,
            skip: this.props.skip,
            take: this.props.take,
            loadingMore: false,
            noMoreData: false
        };

    }

    componentWillMount() {

    }

    componentDidMount() {
        this.handleHistoryEvent();
    }

    handleHistoryEvent() {
        var self = this;

        if (window != undefined
            && window
            && window.history
            && window.history.state) {

            //if we have some posts listed in the state, use them here
            let newState = window.history.state;
            if (newState.posts && newState.posts.length > 0) {

                self.setState(prevState => ({
                    posts: newState.posts,
                    loadingMore: false,
                    skip: newState.skip,
                    take: newState.take,
                    noMoreData: newState.noModeData
                }));


            }
        }
    }


    loadMore(event) {

        event.preventDefault();

        var url = "Listing/Posts?skip=" + (this.state.skip + this.state.take) + "&take=" + this.state.take;

        this.setState({ loadingMore: true });

        fetch(url)
            .then(response => response.json())
            .then(data => {

                let noMore = false;
                if (!data.posts || !data.posts.length || data.posts.length == 0) {
                    noMore = true;
                }

                this.setState(prevState => ({
                    posts: prevState.posts.concat(data.posts),
                    loadingMore: false,
                    skip: data.skip,
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

    render() {


        var posts = this.state.posts.map(item => {
            return <PostListItem item={item} />
        });

        return (
            <div className="left-col">

                {posts}

                {this.state.loadingMore &&
                    <div><a className="btn" disabled> Loading... </a></div>
                }
                {!this.state.loadingMore && !this.state.noMoreData &&

                    <div><a href="#" onClick={this.loadMore} className="btn"> Load More</a></div>
                }
            </div>
        );
    }
}
export default hot(PostListing);


class PostListItem extends React.Component {
    render() {

        return (
            <div className="blog-post" key={this.props.item.key}>
                {this.props.item.image &&
                    <div className="image">
                        <a href={this.props.item.url}>
                            <ResponsiveImage img={this.props.item.image}
                                breaks={[{ w: 640, max: 640 }, { w: 780, max: 800 }]} /></a>
                    </div>
                }
                <div className="content">
                    <h3 className="h3"><a href={this.props.item.url}>{this.props.item.title}</a></h3>
                    <div className="author">
                        <div className="author-image">

                            <img src={this.props.item.author.image ? this.props.item.author.image.url + '?w=100' : "https://static.agilitycms.com/authors/blank-head-profile-pic.jpg?w=100"} alt="" />
                        </div>
                        <h5 className="h5">{this.props.item.author.title}</h5>
                    </div>
                    <div className="text"><p>{this.props.item.excerpt}</p></div>
                    <span className="date">{moment(this.props.item.date).format("LL")}</span>
                </div>
            </div>
        );
    }
}