import React from 'react';
import moment from 'moment'
import { hot } from 'react-hot-loader/root'
import './post-listing.sass'


class PostListing extends React.Component {
    constructor(props) {
        super(props)

        this.state = {
            posts: this.props.posts,
            skip: 0,
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
                                <picture>
                                    <source srcSet={post.image.url + "?w=600"} media="(min-width: 1400px)" />
                                    <source srcSet={post.image.url + '?w=400'} media="(min-width: 800px)" />
                                    <img src={post.image.url} alt={post.image.alt} />
                                </picture>
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

        //loop all the tabs and render them
        const posts = this.state.posts.map(renderPost);

        return (
            <div>
                <ul className="postListing">
                    {posts}
                </ul>
                {this.state.loadingMore &&
                    <div>Loading...</div>
                }
                {!this.state.loadingMore && !this.state.noMoreData &&
                    <div><a href="#" onClick={this.loadMore}> Load More</a></div>
                }
            </div>
        );
    }
}
export default hot(PostListing);

