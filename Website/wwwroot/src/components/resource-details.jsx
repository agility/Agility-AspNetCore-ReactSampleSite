import React from 'react';
import moment from 'moment';
import { hot } from 'react-hot-loader/root'
import './resource-details.sass'


class ResourceDetails extends React.Component {
    render() {

        return (
            <div className="resourceDetails">
                {this.props.resourceType &&
                    <div>{this.props.resourceType.title}</div>
                }

                <h1>{this.props.resource.title}</h1>
                <h2>{this.props.resource.subTitle}</h2>

                {this.props.author &&
                    <div>{this.props.author.title}</div>
                }
                <div>{moment(this.props.resource.date).format("LL")}</div>
                {this.props.resource.image &&
                    <div>
                        <picture>
                            <source srcset={this.props.resource.image.url + '?w=1200'} media="(min-width: 1400px)" />
                            <source srcset={this.props.resource.image.url + '?w=700'} media="(min-width: 800px)" />
                            <img src={this.props.resource.image.url + '?w=640'} alt={this.props.resource.image.alt} />
                        </picture>
                    </div>
                }
                <div dangerouslySetInnerHTML={{ __html: this.props.resource.textBlob }} />
            </div>
        );
    }
}
export default hot(ResourceDetails);
