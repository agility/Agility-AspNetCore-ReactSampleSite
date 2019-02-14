import React from 'react';
import { hot } from 'react-hot-loader/root'
import './latest-blog-posts.sass'
import ResponsiveImage from './responsive-image.jsx'


class LatestBlogPosts extends React.Component {

    render() {

        var self = this;
        var four = this.props.items.map(function (item) {
            return <LatestBlogPostsContent item={item} key={item.key} readMoreText={self.props.readMoreLabel} />
        });

        return (

            <section className="features p-w latest-blog-posts">

                <h2 className="title-component">{this.props.title}</h2>
                <div className="blog-wrapper">
                    <div className="row-my">
                        {four}
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(LatestBlogPosts);

class LatestBlogPostsContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {



        return (
            <div class="col-md-4">
                <div className="blog-item">
                    {this.props.item.image != null &&
                        <div className="image"><a href={this.props.item.url} >
                            <ResponsiveImage img={this.props.item.image}
                                breaks={[{ w: 640, h: 369, max: 640 }, { w: 768, h: 433, min: 800 }, { w: 480, h: 277, min: 1190 }]} /></a>
                        </div>
                    }
                    <div className="content">
                        <h4 className="h4">{this.props.item.title}</h4>
                        <p>{this.props.item.excerpt}</p>
                        <a href={this.props.item.url} >{this.props.readMoreText}</a>
                    </div>
                </div>
            </div>
        );
    }
}