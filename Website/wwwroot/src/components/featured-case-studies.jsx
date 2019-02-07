import React from 'react';
import { hot } from 'react-hot-loader/root'
import './featured-case-studies.sass'

class FeaturedCaseStudies extends React.Component {

    render() {
        var four = this.props.items.map(function (items){
            return <FeaturedCaseStudiesContent item={items} />
        });

        return (

            <section className="features p-w featured-case-studies">
                <div className="canvas" id="canvas-3">
                    <div className="img">
                        <div className="item item-tangle-top-3 twentyone w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentytwo w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentythree w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfour w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfive w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentysix w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyseven w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyeight w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentynine w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 thirty w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>
                <h2 className="title-component">{this.props.title}</h2>
                <div className="case-wrapper">
                    <div className="row-my">
                        {four}
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

        var products = this.props.item.products.map(function (products){
            return (<img src={products.image.url} alt={products.name}/>);
        });

        return (
            <div class="col-md-4">
                <div className="case-item">
                    <div className="image">
                        <a href={this.props.item.app.href}><img src={this.props.item.image.url} alt=""/></a>
                    </div>
                    <div className="app-name">
                        <a href={this.props.item.app.href} target={this.props.item.app.target}><img src={this.props.item.app.image.url} alt=""/></a>
                    </div>
                    <div className="content">
                        <p>{this.props.item.text}</p>
                    </div>
                    <div className="products">
                        {products}
                    </div>
                </div>
            </div>
        );
    }
}