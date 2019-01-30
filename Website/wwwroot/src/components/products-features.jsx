import React from 'react';
import { hot } from 'react-hot-loader/root'
import './products-features.sass'

class ProductsFeatures extends React.Component {
    constructor() {
        super()
    }
    rawMarkup(propName) {
        const rawMarkup = this.props[propName].toString();
        return { __html: rawMarkup };
    }
    render() {

        const productsFeatures = this.props.items.map(function (item) {
            return <ProductsFeaturesContent item={item}/>
        })

        return (

            <section id="sec-5" className="features p-w">
                <div className="canvas" id="canvas-5">
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

                <h2 className="title-conponent" dangerouslySetInnerHTML={this.rawMarkup('title')}></h2>
                <div className="products-features">
                    <div className="row-my">
                        <div className="col-md-4">
                            <div className="features-left">
                                <h3 dangerouslySetInnerHTML={this.rawMarkup('titleLeft')}></h3>
                                <div className="text" dangerouslySetInnerHTML={this.rawMarkup('textLeft')}></div>
                                <a class="btn" href="">Checkout Details Features Here</a>
                            </div>
                        </div>
                        <div className="col-md-8">
                            <div className="features-right">
                                <div className="row-my">
                                    {productsFeatures}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </section>


        );
    }
}

export default hot(ProductsFeatures);

class ProductsFeaturesContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        return (
            <div className="col-md-4">
                <div className="featurer-item">
                    <div className="item-inner">
                        <div className="image">
                            <img src={this.props.item.image.url} alt={this.props.item.title}/>
                        </div>
                        <div className="title">
                            <h4>{this.props.item.title}</h4>
                        </div>
                        <p>{this.props.item.content}</p>
                        <a href={this.props.item.button.href} target={this.props.item.button.target}><span>{this.props.item.button.text}</span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt=""/></a>
                    </div>
                </div>
            </div>
        );
    }
}