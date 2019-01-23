import React from 'react';
import { hot } from 'react-hot-loader/root'
import './logo-cloud.sass'

class LogoListing extends React.Component {
    render() {


        

        return (
            <section id="sec-4" className="friends p-w">
                <div className="canvas" id="canvas-4">
                    <div className="img">
                        <div className="item item-tangle-top-4 twentyone w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentytwo w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentythree w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyfour w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyfive w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentysix w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyseven w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyeight w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentynine w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 thirty w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>

                <h2 className="title-conponent">Don't just take our word for it!</h2>
                <p>These industry leaders have trusted Agility for years, there is a reason their teams are more Agile then ever before.</p>

                <ul className="friends-list">
                    <li className="friend-item"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap5.png" alt="" /></li>
                    <li className="friend-item delay-2"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap2.png" alt="" /></li>
                    <li className="friend-item delay-5"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap3.png" alt="" /></li>
                    <li className="friend-item delay-4"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap4.png" alt="" /></li>
                    <li className="friend-item delay-6"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap5.png" alt="" /></li>
                    <li className="friend-item delay-3"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap6.png" alt="" /></li>
                    <li className="friend-item delay-4"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/friends/Bitmap7.png" alt="" /></li>
                </ul>

                <div className="buttons">
                    <a href="#" className="btn">See Our Case Studies</a>
                    <a href="#" className="btn">Lets Chat!</a>
                </div>
            </section>
        );
    }
}
export default hot(LogoListing);

