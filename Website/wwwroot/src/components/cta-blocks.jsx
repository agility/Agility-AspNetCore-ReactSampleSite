import React from 'react';
import { hot } from 'react-hot-loader/root'
import './cta-blocks.sass'

class ComunityApps extends React.Component {

    render() {

        const comunityApps = this.props.items.map(function (item) {
            return <ComunityAppsContent item={item}/>
        })

        return (

            <section className="features p-w comunity-apps">
                <div className="canvas" id="canvas-3">
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
                <h2 className="title-conponent">{this.props.title}</h2>
                <p className="intro">{this.props.titleBold}</p>
                <div className="apps-content">
                    <div className="row-my">
                        {comunityApps}
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(ComunityApps);

class ComunityAppsContent extends React.Component {

    render() {

        return (
            <div className="col-md-4">
                <div className="app-item">
                    <a href="">
                        <div className="image">
                            <img src={this.props.item.image.url} alt=""/>
                        </div>
                        <p>{this.props.item.title}</p>
                    </a>
                </div>
            </div>
        );
    }
}