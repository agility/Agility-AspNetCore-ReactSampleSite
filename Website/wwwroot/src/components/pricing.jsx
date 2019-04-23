import React from 'react';
import { hot } from 'react-hot-loader/root'
import './pricing.scss'

class Pricing extends React.Component {

    render() {

        const price = this.props.items.map(function (item) {
            return <PriceContent item={item} key={item.key} />
        });

        return (
            <section className="p-w pricing">
                <h2 className="title-conponent">{this.props.title}</h2>
                <div className="container-my">
                    <div className="row-my">
                        {price}
                    </div>
                </div>
            </section>
        );
    }
}
export default hot(Pricing);

class PriceContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {
        var priceClass = 'price-item';
        
        if(this.props.item.isRecommended){
            priceClass += ' current';
        }

        var price = '$ <span>' + this.props.item.price + '</span> ' + this.props.item.pricePerUnitLabel;

        if(this.props.item.price <= 0){
            price = this.props.item.pricePerUnitLabel;
        }

        var features = this.props.item.features;
        var liArray = [];
        for (var i = 0; i < features.length; i++) {
            var liArr = '<li>'+ features[i].label + '<strong> ' + features[i].value +'</strong>' + '</li>';
            liArray.push(liArr);
        }
        var list = liArray.join('');

        return (
            <div className="col-md-3 col-sm-6">
                <div className={priceClass}>
                    <h3 className="item-title">{this.props.item.title}</h3>
                    {
                        this.props.item.icon && 
                        <div className="image">
                            <img src={this.props.item.icon.url} alt=""/>
                        </div>
                    }
                    
                    <div className="intro"><p>{this.props.item.description}</p></div>
                    <div className="price" dangerouslySetInnerHTML={{ __html: price }}></div>
                    <div className="price-intro"><p>{this.props.item.subtitle}</p></div>
                    <div className="features">
                        <ul dangerouslySetInnerHTML={{ __html: list }}></ul>
                    </div>
                    {
                        this.props.item.callToAction && 
                        <div className="buttons">
                            <a href={this.props.item.callToAction.href} target={this.props.item.callToAction.target} className="btn">{this.props.item.callToAction.text}</a>
                        </div>
                    }
                </div>
            </div>
        );
    }
}