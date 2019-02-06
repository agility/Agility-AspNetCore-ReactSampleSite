import React from 'react';
import { hot } from 'react-hot-loader/root'
import './latest-resources.sass'

class LatestResources extends React.Component {

    render() {

        //show first 4 elements
        var objArr = [];
        var labelArr = [];
        var removerArr = [];
        var fullArr = this.props.items;
        var latestRes = fullArr.map(function (item) {
            var labelValue = item.label;
            labelArr.push(labelValue);
            objArr.push(item);
        });
        removerArr = objArr.splice(0,4);
        var four = removerArr.map(function (items){
            return <LatestResContent item={items} />
        });

        function labelClick(elem) {
            var target = elem.target;
            target.classList.toggle('active');
        }
        //create left checkboxes
        Array.prototype.unique = function() {
            return this.filter(function (value, index, self) {
                return self.indexOf(value) === index;
            });
        };
        labelArr = labelArr.unique();
        var labels = labelArr.map(function(label){
            return (<button className="latest-filter" onClick={labelClick}>{label}</button>);
        });

        return (

            <section className="features p-w latest-resources">
                <div className="canvas" id="canvas-2">
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
                <div className="latest-wrapper">
                    <div className="row-my">
                        <div className="col-md-4">
                            <div className="latest-left">
                                <h3 className="h3">{this.props.leftTopTitle}</h3>
                                <div className="assets">{labels}</div>
                                <h3 className="h3">{this.props.leftBottomTitle}</h3>
                                <a className="btn" href={this.props.leftButton.href} target={this.props.leftButton.target}>{this.props.leftButton.text}</a>
                            </div>
                        </div>
                        <div className="col-md-8">
                            <div className="row-my">
                                {four}
                            </div>
                        </div>
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(LatestResources);

class LatestResContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        var eventContent = this.props.item.text;
        eventContent = eventContent.substr(0, 75);
        eventContent = eventContent+'...';

        return (
            <div class="col-md-6">
                <div className="latest-item">
                    <div className="image">
                        <img src={this.props.item.image.url} alt=""/>
                        <span>{this.props.item.label}</span>
                    </div>
                    <div className="content">
                        <h4 className="h4">{this.props.item.title}</h4>
                        <p>{eventContent}</p>
                        <a href={this.props.item.primaryButton.href} target={this.props.item.primaryButton.target}>{this.props.item.primaryButton.text}</a>
                    </div>
                </div>
            </div>
        );
    }
}