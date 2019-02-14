import React from 'react';
import moment from 'moment'
import { hot } from 'react-hot-loader/root'
import ResponsiveImage from './responsive-image.jsx'
import './post-details.sass'
import RichText from './rich-text.jsx'

class PostDetails extends React.Component {
    render() {

        return (

            <section className="blog-post-details">
                <div className="">
                    <div className="container p-w-small rich-text">
                        <h1 className="h1">{this.props.post.title}</h1>
                        {this.props.post.subTitle &&
                            <h4 className="h4">{this.props.post.subTitle}</h4>
                        }
                        <div className="meta d-flex ai-center">
                            <div className="author d-flex ai-center">
                                <div className="author-image">
                                    <img src={this.props.author.image ? this.props.author.image.url + '?w=100' : "https://static.agilitycms.com/authors/blank-head-profile-pic.jpg?w=100"} alt={this.props.author.title} />
                                </div>
                                <h5 className="h5">{this.props.author.title}</h5>
                            </div>
                            <span className="date">{moment(this.props.post.date).format("LL")}</span>
                        </div>

                        {this.props.post.postImage &&
                            <div className="image">
                                <ResponsiveImage img={this.props.post.postImage}
                                    breaks={[{ w: 640, max: 640 }, { w: 780, max: 800 }, { w: 1200, max: 1920 }]} />
                            </div>
                        }
                        
                    </div>
                    <RichText html={this.props.post.textBlob} />
                    
                    <div className="container p-w-small">
                        <a href="/posts" className="back d-flex ai-center"><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /><span>Back to All Articles</span></a>
                    </div>

                </div>
            </section>

        );
    }
}
export default hot(PostDetails);

