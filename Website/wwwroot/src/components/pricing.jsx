import React from 'react';
import { hot } from 'react-hot-loader/root'
import './pricing.scss'

class Pricing extends React.Component {

    render() {

        const price = this.props.items.map(function (item) {
            return <PriceContent item={item} />
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
        var priceClass = 'price-item '+this.props.item.currentClass;
        var priceVal = this.props.item.price;
        var price;
        var buttonText;
        if ('Free' == priceVal) {
            price = priceVal;
        } else {
            price = '$ <span>'+priceVal+'</span> / <em>mo</em>';
        }
        if ('current' == this.props.item.currentClass) {
            buttonText = 'Current Plan';
        } else {
            buttonText = 'Let`s try';
        }
        var benefits = this.props.item.benefits;
        var liArray = [];
        for (var i = 0; i < benefits.length; i++) {
            var liArr = '<li>'+benefits[i].item+'</li>';
            liArray.push(liArr);
        }
        var list = liArray.join('');

        return (
            <div className="col-md-3 col-sm-6">
                <div className={priceClass}>
                    <h3 className="item-title">{this.props.item.heading}</h3>
                    <div className="image">
                        <img src={this.props.item.image.url} alt=""/>
                    </div>
                    <div className="intro"><p>{this.props.item.introText}</p></div>
                    <div className="price" dangerouslySetInnerHTML={{ __html: price }}></div>
                    <div className="price-intro"><p>{this.props.item.priceText}</p></div>
                    <div className="benefits">
                        <ul dangerouslySetInnerHTML={{ __html: list }}></ul>
                    </div>
                    <div className="buttons">
                        <a href="" className="btn">{buttonText}</a>
                    </div>
                </div>
            </div>
        );
    }
}