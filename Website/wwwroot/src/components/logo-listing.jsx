import React from 'react';
import { hot } from 'react-hot-loader/root'
import './logo-listing.sass'

class LogoListing extends React.Component {
    render() {

        // const renderLogo = (logo) => {
        //     //render one tab
        //     return (
        //         <div key={logo.key}>
        //             <h3>{logo.title}</h3>
        //             <div>{logo.shortDescription}</div>
        //             <div dangerouslySetInnerHTML={{ __html: logo.textBlob }} />
        //             <div>
        //                 <img src={logo.logo.url} alt={logo.logo.label} />
        //             </div>
        //             <div>
        //                 <a href={logo.url.href} target={logo.url.target}>{logo.url.text}</a>
        //             </div>
        //         </div>
        //     );
        // }

        // //loop all the tabs and render them
        // const logos = this.props.logos.map(function (logo) {
        //     return renderLogo(logo)
        // })

        // return (
        //     <div className="logoListing">
        //         <h2>{this.props.renderType}</h2>

        //         {logos}

        //         <div>
        //             <a href={this.props.primaryButton.href} target={this.props.primaryButton.target}>{this.props.primaryButton.text}</a>
        //         </div>
        //         <div>
        //             <a href={this.props.secondaryButton.href} target={this.props.secondaryButton.target}>{this.props.secondaryButton.text}</a>
        //         </div>

        //     </div>
        // )


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

                <h2 className="title-conponent">Leaders work better together!</h2>
                <p>We believe heavily in real partnerships and believe you must integration and work with other leaders to be success.<br /> Here are just some of the platforms.</p>

                <ul className="work-list">
                    <li className="work-item"><img src="https://static.agilitycms.com/layout/img/work/img1.png" alt="" /></li>
                    <li className="work-item"><img src="https://static.agilitycms.com/layout/img/work/img2.png" alt="" /></li>
                    <li className="work-item"><img src="https://static.agilitycms.com/layout/img/work/img3.png" alt="" /></li>
                    <li className="work-item"><img src="https://static.agilitycms.com/layout/img/work/img4.png" alt="" /></li>
                    <li className="work-item"><img src="https://static.agilitycms.com/layout/img/work/img5.png" alt="" /></li>
                    <li className="work-item"><img src="https://static.agilitycms.com/layout/img/work/img6.png" alt="" /></li>
                </ul>

                <div className="buttons">
                    <button href="#" className="btn">Check Out More Integrations</button>
                    <button href="#" className="btn">Lets Chat!</button>
                </div>
            </section>
        );
    }
}
export default hot(LogoListing);

