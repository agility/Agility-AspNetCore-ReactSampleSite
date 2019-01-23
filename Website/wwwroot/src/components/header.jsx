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
        return (
            <div>
                <SignIn />
                <Hamburger />
                <header className="header p-w">
                    <div className="header-logo">
                        <a href="#"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/logo.svg" alt=""/></a>
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
                    <button className="btn">Try for FREE</button>
                </header>
            </div>
        );
    }
}
export default hot(Header);

