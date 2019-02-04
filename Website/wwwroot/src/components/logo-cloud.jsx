import React from 'react';
import { hot } from 'react-hot-loader/root'
import './logo-cloud.sass'

class LogoListing extends React.Component {
    render() {

        const renderLogo = (logo, index) => {
            //render one logo
            var className = "friend-item delay-" + (index + 1);

            return (
                <li className={className} key={logo.key}>
                    <a href={logo.url.href} target={logo.url.target}><img src={logo.logo.url} alt={logo.logo.label} /></a>
                </li>
            );
            // <div key={logo.key}>
            //     <h3>{logo.title}</h3>
            //     <div>{logo.shortDescription}</div>
            //     <div dangerouslySetInnerHTML={{ __html: logo.textBlob }} />
            //     <div>
            //         <img src={logo.logo.url} alt={logo.logo.label} />
            //     </div>
            //     <div>
            //         <a href={logo.url.href} target={logo.url.target}>{logo.url.text}</a>
            //     </div>
            // </div>
        }

        //loop all the logos and render them
        const logos = this.props.logos.map(function (logo, index) {
            return renderLogo(logo, index);
        })


        return (
            <section id="sec-4" className="friends p-w">
                <div className="canvas" id="canvas-4">
                    <div className="img">
                        <div className="item item-tangle-top-4 twentyone w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentytwo w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentythree w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyfour w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyfive w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentysix w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyseven w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentyeight w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 twentynine w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-4 thirty w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>

                <h2 className="title-conponent">{this.props.heading}</h2>
                <p>{this.props.subHeading}</p>

                <ul className="friends-list">
                    {logos}
                    {/* <li className="friend-item delay-2"><img src="https://static.agilitycms.com/layout/img/friends/Bitmap2.png" alt="" /></li>
                    <li className="friend-item delay-5"><img src="https://static.agilitycms.com/layout/img/friends/Bitmap3.png" alt="" /></li>
                    <li className="friend-item delay-4"><img src="https://static.agilitycms.com/layout/img/friends/Bitmap4.png" alt="" /></li>
                    <li className="friend-item delay-6"><img src="https://static.agilitycms.com/layout/img/friends/Bitmap5.png" alt="" /></li>
                    <li className="friend-item delay-3"><img src="https://static.agilitycms.com/layout/img/friends/Bitmap6.png" alt="" /></li>
                    <li className="friend-item delay-4"><img src="https://static.agilitycms.com/layout/img/friends/Bitmap7.png" alt="" /></li> */}
                </ul>

                <div className="buttons">
                    <a href={this.props.primaryButton.href} className="btn" target={this.props.primaryButton.target}>{this.props.primaryButton.text}</a>
                    <a href={this.props.secondaryButton.href} className="btn" target={this.props.secondaryButton.target}>{this.props.secondaryButton.text}</a>
                </div>
            </section>
        );
    }
}
export default hot(LogoListing);

