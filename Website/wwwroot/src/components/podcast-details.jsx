import React from 'react';
import { hot } from 'react-hot-loader/root'
import './podcast-details.sass'
import './rich-text.sass'

class BlogPostDetails extends React.Component {

    render() {

        return (

            <section className="blog-post-details">
                <div className="rich-text">
                    <div className="container p-w-small">
                        <h1 className="h1">{this.props.title}</h1>
                        <div className="meta d-flex ai-center">
                            <div className="author d-flex ai-center">
                                <h5 className="h5">{this.props.authorName}</h5>
                            </div>
                            <span className="date">{this.props.date}</span>
                        </div>
                        <div className="image">
                            <iframe src={this.props.video.url} frameBorder="0"></iframe>
                        </div>
                        <div className="content" dangerouslySetInnerHTML={{__html: this.props.text}}></div>
                        <a href="/podcast-listing" className="back d-flex ai-center"><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt=""/><span>Back to Episodes</span></a>
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(BlogPostDetails);