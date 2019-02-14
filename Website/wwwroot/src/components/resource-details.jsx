import React from 'react';
import moment from 'moment';
import { hot } from 'react-hot-loader/root'
import './resource-details.scss'

class ResourceDetails extends React.Component {
    render() {

        return (
            <section className="resource-details">
                <div className="rich-text">
                    <div className="container p-w-small">
                        <h1 className="h1">{this.props.resource.title}</h1>
                        {this.props.resource.subTitle &&
                            <h4 className="h4">{this.props.resource.subTitle}</h4>
                        }
                        <div className="meta d-flex ai-center">
                            <div className="author d-flex ai-center">
                                <div className="author-image">
                                    <img src={this.props.author.image ? this.props.author.image.url + '?w=100' : "https://static.agilitycms.com/authors/blank-head-profile-pic.jpg?w=100"} alt={this.props.author.title} />
                                </div>
                                <h5 className="h5">{this.props.author.title}</h5>
                            </div>
                            <span className="date">{moment(this.props.resource.date).format("LL")}</span>
                        </div>

                        {this.props.resource.postImage &&
                            <div className="image">
                                <ResponsiveImage img={this.props.resource.postImage}
                                    breaks={[{ w: 640, max: 640 }, { w: 780, max: 800 }, { w: 1200, max: 1920 }]} />
                            </div>
                        }

                        <div className="content" dangerouslySetInnerHTML={{ __html: this.props.resource.textBlob }} />

                        {
                            this.props.backButton && this.props.backButton.text && this.props.backButton.href &&
                            <a href={this.props.backButton.href} className="back d-flex ai-center"><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /><span>{this.props.backButton.text}</span></a>
                        }
                    </div>
                </div>
            </section>
        );
    }
}
export default hot(ResourceDetails);
