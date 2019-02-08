import React from 'react';
import { hot } from 'react-hot-loader/root'
import './content-panel.sass'



class ContentPanel extends React.Component {

    constructor() {
        super();
    }


    render() {

        return (
            <section className="front-start p-w">
                <div className="canvas" id="canvas-1">
                    <div className="img">
                        {/* <div className="item item-tangle-top one w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top two w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top three w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top four w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top five w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top six w58 rotate">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top seven w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top eight w84 rotate">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top nine w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top ten w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top eleven w58 rotate">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top twelve w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top thirteen w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top fourteen w84 rotate">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top fifteen w58 rotate">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top sixteen w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top seventeen w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top eighteen w84 rotate">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div> */}
                    </div>
                </div>

                <div className={this.props.enableBackgroundImage ? 'rotated-bg' : ''}></div>

                {this.props.imagePosition === 'left' &&
                    <div className="start-image left">
                        <img src={this.props.image.url + '?w=500&h=500'} alt={this.props.image.label} />
                    </div>
                }

                <div className="start-content">
                    <h1>{this.props.title}</h1>
                    <div dangerouslySetInnerHTML={{ __html: this.props.textBlob }} />
                    <div className="start-buttons">
                        <a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a>
                        <a href={this.props.secondaryButton.href} target={this.props.secondaryButton.target} className="btn-link">{this.props.secondaryButton.text} <span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /></span></a>
                    </div>
                </div>

                {this.props.imagePosition === 'right' &&
                    <div className="start-image right">
                        <img src={this.props.image.url + '?w=500&h=500'} alt={this.props.image.label} />
                    </div>
                }


            </section>
        );
    }
}
export default hot(ContentPanel);

