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
                    <h1>Design > Build > Deploy Faster with Agility!</h1>
                    <h2>Want to be more flexible, quicker to market and adapt<br /> to the pace of business? Bring Agility to your team.</h2>
                    <p>Agility is a content first Headless CMS. Start with your most valuable asset, your<br /> content. Then Build, Deploy and Engage your customers with a platform that<br /> manages your content across all your digital channels.</p>
                    <div className="start-buttons">
                        <button className="btn">Request a Demo</button>
                        <a href="#" className="btn-link">Try for FREE <span><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/ico/gray.svg" alt="" /></span></a>
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

