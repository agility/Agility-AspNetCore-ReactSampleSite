import React from 'react';
import { hot } from 'react-hot-loader/root'
import './resource-details.sass'


class ResourceDetails extends React.Component {
    render() {
        console.log(this.props);
        return (
            <div className="resourceDetails">
                <h1>{this.props.resource.title}</h1>
                <h2>{this.props.resource.subTitle}</h2>
                <h3>{this.props.resource.authorName}</h3>
                <div>{this.props.resource.date}</div>
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
