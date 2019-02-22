import React from 'react';
import { hot } from 'react-hot-loader/root'
import './podcast-details.scss'
import './rich-text.scss'
import ResponsiveImage from './responsive-image.jsx'
import moment from 'moment';

class BlogPostDetails extends React.Component {

    render() {

        return (

            <section className="podcast-details">
                <div className="rich-text">
                    <div className="container p-w-small">
                        <h1 className="h1">{this.props.title}</h1>
                        <div className="meta d-flex ai-center">
                            <div className="author d-flex ai-center">
                                <h5 className="h5">Episode #{this.props.episodeNumber}</h5>
                            </div>
                            <span className="date">{moment(this.props.date).format("LL")}</span>
                        </div>
                        <div className="image" >
                            <ResponsiveImage img={this.props.mainImage}
                                breaks={[{ w: 640, max: 480 }, { w: 900, max: 400 }, { w: 1200, max: 700 }]} />
                        </div>
                        <div dangerouslySetInnerHTML={{ __html: this.props.embed }}></div>
                        <div className="content" dangerouslySetInnerHTML={{ __html: this.props.textBlob }}></div>
                        <a href="/agileliving" className="back d-flex ai-center"><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /><span>Back to Episodes</span></a>
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(BlogPostDetails);