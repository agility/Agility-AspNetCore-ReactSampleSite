import React from 'react';
import moment from 'moment'
import { hot } from 'react-hot-loader/root'
import './post-details.sass'


class PostDetails extends React.Component {
    render() {
        return (
            <div className="postDetails">

                <h1>{this.props.post.title}</h1>
                <div>{moment(this.props.post.date).format("LL")}</div>
                {this.props.author &&
                    <div>{this.props.author.title}</div>
                }

                {this.props.category &&
                    <div>{this.props.category.title}</div>
                }

                {this.props.post.image &&
                    <div>
                        <img src={this.props.post.image.url} alt={this.props.post.image.label} />
                    </div>
                }

                <div dangerouslySetInnerHTML={{ __html: this.props.post.textBlob }} />
            </div>
        );
    }
}
export default hot(PostDetails);

