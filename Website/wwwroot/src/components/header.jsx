import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.sass'
import SignIn from './sign-in.jsx'
import Hamburger from './hamburger.jsx'


class Header extends React.Component {
    constructor() {
        super()
    }
    componentDidMount() {
        //dropdown Menu
        var hiddenParent = document.querySelector('.has-children');
        hiddenParent.addEventListener('click', function(e){
            
            this.classList.toggle('open');
        });
    }
    render() {

        const outputLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                links.push(<li key={item.key}><a href={item.url.href} target={item.url.target}>{item.title}</a></li>)
            });

            return <ul>{links}</ul>;
        };

        return (
            <div>
                <SignIn />
                <Hamburger />
                <header className="header p-w">
                    <div className="header-logo">
                        <a href="/"><img src={this.props.logo.url} alt={this.props.logo.label} /></a>
                    </div>
                    <ul className="header-menu">
                        <li className="h-menu-li has-children"><a href="#" className="h-menu-a">Product</a>
                            <span className="sub-menu-icon"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/ico/down.svg" alt=""/></span>
                            <div className="sub-menu-inner">
                                <ul className="sub-menu">
                                    <li className="sub-menu-li"><a href="#" className="sub-menu-a">Product 1</a></li>
                                    <li className="sub-menu-li"><a href="#" className="sub-menu-a">Product 2</a></li>
                                    <li className="sub-menu-li"><a href="#" className="sub-menu-a">Product 3</a></li>
                                </ul>
                            </div>
                        </li>
                        <li className="h-menu-li"><a href="#" className="h-menu-a">Customers</a></li>
                        <li className="h-menu-li"><a href="#" className="h-menu-a">Pricing</a></li>
                        <li className="h-menu-li"><a href="#" className="h-menu-a">Documentation</a></li>
                        <li className="h-menu-li"><a href="#" className="h-menu-a">Community</a></li>
                    </ul>
                    <a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a>
                </header>
            </div>
        );
    }
}
export default hot(Header);

