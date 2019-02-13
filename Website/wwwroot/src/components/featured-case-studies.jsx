import React from 'react';
import { hot } from 'react-hot-loader/root'
import './featured-case-studies.sass'
import ResponsiveImage from './responsive-image.jsx'


class FeaturedCaseStudies extends React.Component {

    render() {

        var items = this.props.items.map(function (item) {
            return <FeaturedCaseStudiesContent key={item.key} item={item} />
        });

        return (

            <section className="features p-w featured-case-studies">

                <h2 className="title-component">{this.props.title}</h2>
                <div className="case-wrapper">
                    <div className="row-my">
                        {items}
                    </div>
                </div>
                <a class="btn" href={this.props.primaryButton.href} target={this.props.primaryButton.target}>{this.props.primaryButton.text}</a>
            </section>

        );
    }
}
export default hot(FeaturedCaseStudies);

class FeaturedCaseStudiesContent extends React.Component {
    render() {

        var products = this.props.item.products.map(function (product) {
            return (<img key={product.key} src={product.icon.url} alt={product.icon.label} />);
        });

        return (
            <div class="col-md-4">
                <div className="case-item">
                    <div className="image">
                        <a href={this.props.item.url}>
                            <ResponsiveImage img={this.props.item.image}
                                breaks={[{ w: 640, max: 640 }, { w: 768, min: 800 }, { w: 480, min: 1190 }]} />
                        </a>
                    </div>
                    <div className="app-name">
                        <a href={this.props.item.url}><img src={this.props.item.logo.url} alt={this.props.item.logo.label} /></a>
                    </div>
                    <div className="content">
                        <p>{this.props.item.text}</p>
                    </div>
                    <div className="products">
                        <a href={this.props.item.url}>
                            {products}
                        </a>
                    </div>
                </div>
            </div>
        );
    }
}