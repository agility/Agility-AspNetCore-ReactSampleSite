import React from 'react';
import { hot } from 'react-hot-loader/root'
import './comunity-summit.sass'

class ComunitySummit extends React.Component {
    render() {
        return (

            <section className="features p-w comunity-summit">
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
                <div className="summit-content">
                    <div className="row-my">
                        <div className="col-md-6">
                            <div className="image">
                                <img src={this.props.image.url} alt=""/>
                            </div>
                        </div>
                        <div className="col-md-6">
                            <div className="summit-right">
                                <h3>{this.props.title}</h3>
                                <h4>{this.props.titleBold}</h4>
                                <p>{this.props.content}</p>
                                <div className="buttons">
                                    <a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a>
                                    <a className="arrow-button" href={this.props.secondaryButton.href} target={this.props.secondaryButton.target}>
                                        <span>{this.props.secondaryButton.text}</span>
                                        <img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </section>


        );
    }
}
export default hot(ComunitySummit);