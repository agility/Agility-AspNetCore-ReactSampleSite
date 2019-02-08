import React from 'react';
import { hot } from 'react-hot-loader/root'
import './featured-resources.sass'

class FeaturedResources extends React.Component {


    render() {

        const featuredRes = this.props.items.map(function (item) {
            return <FeaturedResContent item={item} />
        });

        return (

            <section className="features p-w featured-resources get-shadow">
                <div className="canvas" id="canvas-1">
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

        var eventContent = this.props.item.text;
        eventContent = eventContent.substr(0, 75);
        eventContent = eventContent+'...';

        return (
            <div class="col-md-4">
                <div className="featured-item">
                    <div className="image"><img src={this.props.item.image.url} alt=""/></div>
                    <div className="content">
                        <p>{eventContent}</p>
                        <a href={this.props.item.primaryButton.href} className="btn" target={this.props.item.primaryButton.target}><span>{this.props.item.primaryButton.text}</span><img src={this.props.item.primaryButton.ico.url} alt=""/></a>
                    </div>
                </div>
            </div>
        );
    }
}