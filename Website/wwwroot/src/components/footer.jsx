import React from 'react';
import { hot } from 'react-hot-loader/root'
import './foter.sass'


class Footer extends React.Component {

    render() {

        const outputLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                links.push(<li><a href={item.url.href} target={item.url.target}>{item.title}</a></li>)
            });

            return <ul>{links}</ul>;

        }
        return (
            // <footer className="container">
            //     <h3>{this.props.column1Title}</h3>
            //     {outputLinks(this.props.column1Links)}

            //     <h3>{this.props.column2Title}</h3>
            //     {outputLinks(this.props.column2Links)}

            //     <h3>{this.props.column3Title}</h3>
            //     {outputLinks(this.props.column3Links)}

            // </footer>
            
            <footer className="foter p-w">
                <div className="foter-inner">

                    <ul className="foter-menu menu-product">
                        <li className="foter-menu-li title"><span>Product</span></li>
                        <li className="foter-menu-li"><a href="#">Why Agility?</a></li>
                        <li className="foter-menu-li"><a href="#">Content First</a></li>
                        <li className="foter-menu-li"><a href="#">Features</a></li>
                        <li className="foter-menu-li"><a href="#">Ecommerce</a></li>
                        <li className="foter-menu-li"><a href="#">Ticketing</a></li>
                        <li className="foter-menu-li"><a href="#">Pricing </a></li>
                    </ul>
                    <ul className="foter-menu menu-about">
                        <li className="foter-menu-li title"><span>About Us</span></li>
                        <li className="foter-menu-li"><a href="#">About Us</a></li>
                        <li className="foter-menu-li"><a href="#">Our Team</a></li>
                        <li className="foter-menu-li"><a href="#">Culture & Careers </a></li>
                        <li className="foter-menu-li"><a href="#">Community</a></li>
                        <li className="foter-menu-li"><a href="#">Blog</a></li>
                    </ul>
                    <ul className="foter-menu menu-information">
                        <li className="foter-menu-li title"><span>Information</span></li>
                        <li className="foter-menu-li"><a href="#">Documentation</a></li>
                        <li className="foter-menu-li"><a href="#">Guides</a></li>
                        <li className="foter-menu-li"><a href="#">Help / Support</a></li>
                        <li className="foter-menu-li"><a href="#">Partners</a></li>
                    </ul>
                    <ul className="foter-menu menu-social">
                        <li className="foter-menu-li title"><span>Follow Us</span></li>
                        <li className="foter-menu-li"><a href="#"><img src="img/foter/facebook.svg" alt="" /></a></li>
                        <li className="foter-menu-li"><a href="#"><img src="img/foter/twitter.svg" alt="" /></a></li>
                    </ul>
                    <div className="foter-subscribe">
                        <span>Subscribe to Agility</span>
                        <p>Learn about our platform and all the stuf going on in our<br /> Community</p>
                        <form action="" className="foter-subscribe-form">
                            <input type="text" placeholder="Email" />
                            <input type="submit" value="Subscribe" />
                        </form>
                    </div>

                </div>

                <div className="foter-copyright">
                    <p>© Copyright, Agility 2019</p>
                    <ul className="foter-copyright-menu">
                        <li><a href="#">Privacy Policy</a></li>
                        <span>|</span>
                        <li><a href="#">Security</a></li>
                    </ul>
                </div>
            </footer>

        );
    }
}
export default hot(Footer);

