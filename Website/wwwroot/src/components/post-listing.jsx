import React from 'react';
import { hot } from 'react-hot-loader/root'
import './post-listing.sass'


class PostListing extends React.Component {
    render() {

        const renderPost = (post) => {
            //render one tab
            return (
                <li key={post.key} className="post">

                    {post.image &&
                        <a href={post.url}>
                            <div className="postImage">
                                <picture>
                                    <source srcset={post.image.srcLarge} media="(min-width: 1400px)" />
                                    <source srcset={post.image.srcMedium} media="(min-width: 800px)" />
                                    <img src={post.image.srcSmall} alt={post.image.alt} />
                                </picture>
                            </div>
                        </a>
                    }

                    <a href={post.url}>
                        <h3 className="postTitle">{post.title}</h3>
                    </a>

                    <h4 className="postAuthorDate">{post.author} - {post.date}</h4>
                    <div className="postExcerpt" dangerouslySetInnerHTML={{ __html: post.excerpt }} />
                </li>
            );
        }

        //loop all the tabs and render them
        const posts = this.props.posts.map(renderPost);


        return (
            <ul class="postListing">
                {posts}
            </ul>
        );
    }
}
export default hot(PostListing);

