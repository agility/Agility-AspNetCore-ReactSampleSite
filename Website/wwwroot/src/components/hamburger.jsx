import React from 'react';
import { hot } from 'react-hot-loader/root'
import './hamburger.sass'


class Hamburger extends React.Component {
    constructor(props) {
        super(props)
    }

    

    componentDidMount() {
        var menu = document.querySelector('.mobile-menu-inner .has-children'); 
        menu.onclick = function() {
            this.classList.toggle('open');
        };

        this.menuOpenClose();
    }

    menuOpenClose() {
        var btnMenuOpen = document.querySelector('.Button-menu');
        var html = document.querySelector('html');
        var menuContainer = document.querySelector('.Sidebar');
        var isOpen = false;

        if (btnMenuOpen) {
            btnMenuOpen.addEventListener('click', function() {
                if(isOpen == false){
                    menuContainer.classList.add('active');
                    btnMenuOpen.classList.add('active');
                    html.classList.add('overflow-scroll');
                    isOpen = true;
                }else{
                    menuContainer.classList.remove('active');
                    btnMenuOpen.classList.remove('active');
                    html.classList.remove('overflow-scroll');
                    isOpen = false;
                }
            });
        }

        var openMenuBlock = document.querySelector('#nav-icon-close'); // Using a class instead, see note below.
        var openMenuBtn = document.querySelector('.mobile-logo'); // Using a class instead, see note below.
        openMenuBlock.onclick = function() {
            menuContainer.classList.remove('active');
            btnMenuOpen.classList.remove('active');
            html.classList.remove('overflow-scroll');
            isOpen = false;
        };
        openMenuBtn.onclick = function() {
            menuContainer.classList.remove('active');
            btnMenuOpen.classList.remove('active');
            html.classList.remove('overflow-scroll');
            isOpen = false;
        };
    }

    render() {
        return (
            <div>
                <button className='Button-menu' id="nav-icon1"><span></span><span></span><span></span></button>

                <div className="Sidebar mob-menu">

                    <div className="inner">
                        <div className="mobile-logo">
                            <a href="#"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/logo-original.svg" alt=""/></a>
                        </div>
                        <button className='Button-menu' id="nav-icon-close"><span></span><span></span><span></span></button>
                        <div className="mobile-menu-inner">
                            <ul className="mob-menu">
                                <li className="mobile-menu-li has-children"><a href="#" className="mobile-menu-a">Product</a>
                                    <span className="sub-menu-icon"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/ico/down.svg" alt=""/></span>
                                    <div className="sub-menu-inner">
                                        <ul className="sub-menu">
                                            <li className="sub-menu-li"><a href="#" className="sub-menu-a">Product 1</a></li>
                                            <li className="sub-menu-li"><a href="#" className="sub-menu-a">Product 2</a></li>
                                            <li className="sub-menu-li"><a href="#" className="sub-menu-a">Product 3</a></li>
                                        </ul>
                                    </div>
                                </li>
                                <li className="mobile-menu-li"><a href="#" className="mobile-menu-a">Customers</a></li>
                                <li className="mobile-menu-li"><a href="#" className="mobile-menu-a">Pricing</a></li>
                                <li className="mobile-menu-li"><a href="#" className="mobile-menu-a">Documentation</a></li>
                                <li className="mobile-menu-li"><a href="#" className="mobile-menu-a">Community</a></li>
                                <li className="mobile-menu-li"><a href="#" className="mobile-menu-a">Help</a></li>
                                <li className="mobile-menu-li"><a href="#" className="mobile-menu-a sign-in">Sign In</a></li>
                            </ul>
                        </div>
                        <div className="buttons">
                            <button className="btn">Try for FREE</button>
                            <button className="btn">Lets Chat!</button>
                        </div>
                    </div>

                </div>
            </div>
        );
    }
}
export default hot(Hamburger);

