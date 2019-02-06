import React from 'react';
import { hot } from 'react-hot-loader/root'
import './blog-listing.sass'

class BlogListing extends React.Component {

    render() {
        var four = this.props.items.map(function (items){
            return <BlogListingContent item={items} />
        });

        return (

            <div className="left-col">
                {four}
            </div>

        );
    }
}
export default hot(BlogListing);

class BlogListingContent extends React.Component {
    render() {

        var eventContent = this.props.item.text;
        eventContent = eventContent.substr(0, 240);
        eventContent = eventContent+'...';

        return (
            <div className="blog-post">
                <div className="image">
                    <a href={this.props.item.href}><img src={this.props.item.image.url} alt=""/></a>
                </div>
                <div className="content">
                    <h3 className="h3"><a href={this.props.item.href}>{this.props.item.title}</a></h3>
                    <div className="author">
                        <div className="author-image">
                            <img src={this.props.item.authorFoto.url} alt=""/>
                        </div>
                        <h5 class="h5">{this.props.item.authorName}</h5>
                    </div>
                    <div className="text"><p>{eventContent}</p></div>
                    <span className="date">{this.props.item.date}</span>
                </div>
            </div>
        );
    }
}