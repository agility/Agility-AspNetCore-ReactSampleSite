import React from 'react';
import { hot } from 'react-hot-loader/root'
import './blog-post-details.sass'
import './rich-text.sass'

class BlogPostDetails extends React.Component {

    render() {

        return (

            <section className="blog-post-details">
                <div className="rich-text">
                    <div className="container p-w-small">
                        <h1 className="h1">{this.props.title}</h1>
                        <h4 className="h4">{this.props.subTitle}</h4>
                        <div className="meta d-flex ai-center">
                            <div className="author d-flex ai-center">
                                <div className="author-image"><img src={this.props.authorFoto.url} alt=""/></div>
                                <h5 className="h5">{this.props.authorName}</h5>
                            </div>
                            <span className="date">{this.props.date}</span>
                        </div>
                        <div className="image"><img src={this.props.image.url} alt=""/></div>
                        <div className="content" dangerouslySetInnerHTML={{__html: this.props.text}}></div>
                        <a href="/blog-listing" className="back d-flex ai-center"><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt=""/><span>Back to All Articles</span></a>
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(BlogPostDetails);