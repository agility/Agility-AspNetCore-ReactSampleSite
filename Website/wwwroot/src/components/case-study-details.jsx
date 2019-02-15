import React from 'react';
import { hot } from 'react-hot-loader/root'
import './case-study-details.scss'
import './rich-text.scss'

class CaseDetails extends React.Component {

    render() {

        var bgColor = this.props.bgColor;
        const metrics = this.props.metrics.map(function (item) {
            return (
                <div class="metrics-item" style={{color: bgColor}}>
                    <h4 className="h4" dangerouslySetInnerHTML={{__html: item.value}}></h4>
                    <hr style={{backgroundColor: bgColor}}/>
                    <span>{item.title}</span>
                </div>
            );
        });

        return (
            <section className="p-w case-study-details">
                <div className="canvas" id="canvas-4">
                    <div className="img">
                        <div className="item item-tangle-top-5 twentyone w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentytwo w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentythree w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyfour w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyfive w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentysix w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyseven w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyeight w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentynine w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 thirty w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>
                <div className="container-my">
                    <div className="row-my">
                        {
                            metrics && metrics.length > 0 &&
                            <div className="col-md-12">
                                <div className="case-study-top d-flex jc-sb">
                                    {metrics}
                                </div>
                            </div>
                        }

                        <div className={this.props.rightContentCopy || this.props.quote ? "col-md-8" : "col-md-12"}>
                            <div className="case-study-left">
                                <div className="rich-text" dangerouslySetInnerHTML={{__html: this.props.body}}></div>
                            </div>
                        </div>

                        {
                            (this.props.rightContentCopy || this.props.quote) &&
                            <div className="col-md-4">
                                <div className="case-study-right">
                                    <div className="rich-text" dangerouslySetInnerHTML={{__html: this.props.rightContentCopy}}></div>
                                    <div className="color-text"><p>{this.props.quote}</p></div>
                                </div>
                            </div>
                        }

                    </div>
                </div>
            </section>


        );
    }
}
export default hot(CaseDetails);
