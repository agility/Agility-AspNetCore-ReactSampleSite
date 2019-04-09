import React from 'react';
import { hot } from 'react-hot-loader/root'
import './logo-listing.scss'

class LogoListing extends React.Component {
    render() {

        const renderLogo = (logo) => {
            //render one tab

            return (

                <li className="work-item" key={logo.key}>
                    <a href={logo.url.href} target={logo.url.target}><img src={logo._Logo.url} alt={logo._Logo.label} /></a>
                </li>

            );
        }

        //loop all the tabs and render them
        let logos = null;
        if(this.props.logos && this.props.logos.length > 0) {
            logos = this.props.logos.map(function (logo) {
                return renderLogo(logo)
            })
        }
            
        

        return (
            <section id="sec-5" className="work p-w">
                <div className="canvas" id="canvas-5">
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

                <div className="rotated-bg"></div>

                {
                    this.props.heading &&
                    <h2 className="title-conponent">{this.props.heading}</h2>
                }

                {
                    this.props.subHeading &&
                    <p>{this.props.subHeading}</p>
                }

                {
                    logos && logos.length > 0 &&
                    <div className="container-my">
                        <ul className="work-list">
                            {logos}
                        </ul>
                    </div>
                }

                {
                    (this.props.primaryButton || this.props.secondaryButton) &&
                    <div className="buttons">
                        {
                            this.props.primaryButton &&
                            <a className="btn" href={this.props.primaryButton.href} target={this.props.primaryButton.target}>{this.props.primaryButton.text}</a>
                        }

                        {
                            this.props.secondaryButton &&
                            <a className="btn" href={this.props.secondaryButton.href} target={this.props.secondaryButton.target}>{this.props.secondaryButton.text}</a>
                        }
                    </div>
                }

            </section>
        );
    }
}
export default hot(LogoListing);

