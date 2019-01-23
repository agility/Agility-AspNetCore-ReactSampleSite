import React from 'react';
import { hot } from 'react-hot-loader/root'
import './logo-listing.sass'

class LogoListing extends React.Component {
    render() {


        

        return (
            <section id="sec-5" className="work p-w">
                <div className="canvas" id="canvas-5">
                    <div className="img">
                        <div className="item item-tangle-top-5 twentyone w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentytwo w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentythree w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyfour w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyfive w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentysix w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyseven w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentyeight w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 twentynine w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-5 thirty w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>

                <div className="rotated-bg"></div>

                <h2 className="title-conponent">Leaders work better together!</h2>
                <p>We believe heavily in real partnerships and believe you must integration and work with other leaders to be success.<br /> Here are just some of the platforms.</p>

                <ul className="work-list">
                    <li className="work-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/work/img1.png" alt="" /></li>
                    <li className="work-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/work/img2.png" alt="" /></li>
                    <li className="work-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/work/img3.png" alt="" /></li>
                    <li className="work-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/work/img4.png" alt="" /></li>
                    <li className="work-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/work/img5.pngg" alt="" /></li>
                    <li className="work-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/work/img6.png" alt="" /></li>
                </ul>

                <div className="buttons">
                    <a href="#" className="btn">Check Out More Integrations</a>
                    <a href="#" className="btn">Lets Chat!</a>
                </div>
            </section>
        );
    }
}
export default hot(LogoListing);

