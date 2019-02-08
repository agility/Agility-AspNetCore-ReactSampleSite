import React from 'react';
import moment from 'moment'
import { hot } from 'react-hot-loader/root'
import './post-listing.sass'
import ResponsiveImage from './responsive-image.jsx'


class PostListing extends React.Component {
    constructor(props) {
        super(props)

        this.state = {
            posts: this.props.posts,
            skip: this.props.skip,
            take: this.props.take,
            loadingMore: false,
            noMoreData: false
        };
        this.loadMore = this.loadMore.bind(this);

    }

    componentDidMount() {

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

                //set the url in the browser...
                let url = location.pathname + "?skip=" + this.state.skip;
                window.history.pushState({ path: url }, '', url);

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


        const renderPost = (post) => {
            //render one tab
            return (
                <li key={post.key} className="post">

                    {post.image &&
                        <a href={post.url}>
                            <div className="postImage">
                                <ResponsiveImage url={post.image.url} alt={post.image.label} breaks={[{ w: 600, m: 1400 }, { w: 400, m: 800 }]} />
                            </div>
                        </a>
                    }

                    <a href={post.url}>
                        <h3 className="postTitle">{post.title}</h3>
                    </a>

                    <h4 className="postAuthorDate">{post.author} - {moment(post.date).format("LL")}</h4>
                    <div className="postExcerpt" dangerouslySetInnerHTML={{ __html: post.excerpt }} ></div>
                </li>
            );
        }

        // const postsX = this.state.posts.map(renderPost);

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
                        <h5 class="h5">{this.props.item.author.title}</h5>
                    </div>
                    <div className="text"><p>{this.props.item.excerpt}</p></div>
                    <span className="date">{moment(this.props.item.date).format("LL")}</span>
                </div>
            </div>
        );
    }
}