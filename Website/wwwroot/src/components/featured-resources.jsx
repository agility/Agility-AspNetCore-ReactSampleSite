import React from 'react';
import { hot } from 'react-hot-loader/root'
import './featured-resources.sass'

class FeaturedResources extends React.Component {


    render() {

        var self = this;
        const featuredRes = this.props.items.map(function (item) {
            return <FeaturedResContent key={item.key} item={item} readMoreLabel={self.props.readMoreLabel} />
        });

        return (

            <section className="features p-w featured-resources get-shadow">
                <h2 className="title-component">{this.props.title}</h2>
                <p className="intro">{this.props.subTitle}</p>
                <div className="featured-wrapper">
                    <div className="row-my">
                        {featuredRes}
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(FeaturedResources);

class FeaturedResContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        return (
            <div className="col-md-4">
                <div className="featured-item">
                    <div className="image"><img src={this.props.item.image.url} alt="" /></div>
                    <div className="content">
                        <h3>{this.props.item.title}</h3>
                        <p>{this.props.item.text}</p>
                        <a href={this.props.item.url} className="btn" ><span>{this.props.readMoreLabel}</span></a>
                    </div>
                </div>
            </div>
        );
    }
}