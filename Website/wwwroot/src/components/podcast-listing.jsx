import React from 'react';
import { hot } from 'react-hot-loader/root'
import './post-listing.scss'
import './podcast-listing.scss'

class BlogListing extends React.Component {

    render() {
        var four = this.props.items.map(function (items, index){
            return <BlogListingContent item={items} id={index} />
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

        var elemId = this.props.id;
        elemId = 'frame-'+elemId;

        function playVideo(e) {
            var iframe = e.target.parentElement.parentElement.parentElement.children[0];
            /*var iframeId = iframe.id;*/
            e.target.parentElement.parentElement.remove();
            /*var iframeDom = document.getElementById(iframeId);*/
        }

        return (
            <div className="blog-post">
                <div className="image">
                    <iframe id={elemId} src={this.props.item.video.url} frameborder="0"></iframe>
                    <div className="block-hover">
                        <img src={this.props.item.image.url} alt=""/>
                        <div className="play d-flex jc-c ai-center"><img src="dist/img/Triangle.svg" onClick={playVideo} alt=""/></div>
                    </div>
                    <img className="podcast" src="dist/img/podcast.svg" alt="" />
                </div>
                <div className="content">
                    <h3 className="h3"><a href={this.props.item.href}>{this.props.item.title}</a></h3>
                    <div className="author">
                        <h5 class="h5">{this.props.item.authorName}</h5>
                    </div>
                    <div className="text"><p>{eventContent}</p></div>
                    <span className="date">{this.props.item.date}</span>
                </div>
            </div>
        );
    }
}