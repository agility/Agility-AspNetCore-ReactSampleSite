import React from 'react';
import { hot } from 'react-hot-loader/root'
import './content-panel.sass'



class ContentPanel extends React.Component {
    render() {
        return (
            <section id="sec-1" className="front-start p-w">
                <div className="canvas" id="canvas-1">
                    <div className="img">
                        <div className="item item-tangle-top one w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top two w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top three w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top four w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top five w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top six w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top seven w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top eight w84 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top nine w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top ten w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top eleven w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top twelve w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top thirteen w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top fourteen w84 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top fifteen w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top sixteen w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/orange_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top seventeen w84">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top eighteen w84 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/white_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>
                
                <div className="rotated-bg"></div>
                <div className="start-content">
                    <h1>{this.props.title}</h1>
                    <div dangerouslySetInnerHTML={{ __html: this.props.textBlob }} />
                    <div className="start-buttons">
                        <a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a>
                        <a href={this.props.secondaryButton.href} target={this.props.secondaryButton.target} className="btn-link">{this.props.secondaryButton.text} <span><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/ico/gray.svg" alt="" /></span></a>
                    </div>
                </div>
                <div className="start-image">
                    <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/content/img1.png" alt="" />
                </div>
            </section>
        );
    }
}
export default hot(ContentPanel);

