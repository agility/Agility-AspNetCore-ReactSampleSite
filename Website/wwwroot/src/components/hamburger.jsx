import React from 'react';
import { hot } from 'react-hot-loader/root'
import './hamburger.scss'


class Hamburger extends React.Component {
    constructor(props) {
        super(props)
    }



    componentDidMount() {
        if (!document) return;

        var menu = document.querySelector('.mobile-menu-inner .has-children');
        menu.onclick = function (e) {
            //don't toggle again if we've just clicked a child item anchor are going to load a new page
            if (e.target.className == "sub-menu-a") return;
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
            btnMenuOpen.addEventListener('click', function () {
                if (isOpen == false) {
                    menuContainer.classList.add('active');
                    btnMenuOpen.classList.add('active');
                    html.classList.add('overflow-scroll');
                    isOpen = true;
                } else {
                    menuContainer.classList.remove('active');
                    btnMenuOpen.classList.remove('active');
                    html.classList.remove('overflow-scroll');
                    isOpen = false;
                }
            });
        }

        var openMenuBlock = document.querySelector('#nav-icon-close'); // Using a class instead, see note below.
        var openMenuBtn = document.querySelector('.mobile-logo'); // Using a class instead, see note below.
        openMenuBlock.onclick = function () {
            menuContainer.classList.remove('active');
            btnMenuOpen.classList.remove('active');
            html.classList.remove('overflow-scroll');
            isOpen = false;
        };
        openMenuBtn.onclick = function () {
            menuContainer.classList.remove('active');
            btnMenuOpen.classList.remove('active');
            html.classList.remove('overflow-scroll');
            isOpen = false;
        };
    }

    render() {

        function setNativeValue(element, value) {
            const valueSetter = Object.getOwnPropertyDescriptor(element, 'value').set;
            const prototype = Object.getPrototypeOf(element);
            const prototypeValueSetter = Object.getOwnPropertyDescriptor(prototype, 'value').set;

            if (valueSetter && valueSetter !== prototypeValueSetter) {
                prototypeValueSetter.call(element, value);
            } else {
                valueSetter.call(element, value);
            }
        }

        function showSearch(b) {
            b.target.classList.toggle('close');
            var searchFrame = document.querySelector('.search-frame');
            searchFrame.classList.toggle('open');
            document.querySelector('html').classList.toggle('search-open');

            var searchInput = document.getElementById('search-input')

            setNativeValue(searchInput, '');
            searchInput.dispatchEvent(new Event('input', { bubbles: true }));

            searchInput.focus();
        }



        const renderMobileMenu = () => {
            let links = [];

            const menu = this.props.menu;
            if (!menu || !menu.length || menu.length == 0) return null;

            //loop through sitemap
            menu.forEach(item => {
                let link = null;
                const hasChildren = item.children != null && item.children.length > 0;
                if (hasChildren) {
                    const children = item.children.map(function (child) {
                        return <li key={child.key} className="sub-menu-inner"><a className="sub-menu-a" href={child.url} target={child.target}>{child.text}</a></li>;
                    });

                    link =
                        <li key={item.key} className="mobile-menu-li has-children">
                            <a href={item.url} target={item.target} className="mobile-menu-a">{item.text}</a>
                            <span className="sub-menu-icon">
                                <img src="https://static.agilitycms.com/layout/img/ico/down.svg" alt="Expand/Collapse"></img>
                            </span>
                            <div className="sub-menu-inner">
                                <ul className="sub-menu">
                                    {children}
                                </ul>
                            </div>
                        </li>;
                } else {
                    link =
                        <li key={item.key} className="mobile-menu-li">
                            <a href={item.url} target={item.target} className="mobile-menu-a">{item.text}</a>
                        </li>;
                }

                links.push(link)
            });

            //add-in the other links
            let preHeaderLinks = [];

            this.props.preHeaderLinks.forEach(item => {
                const link = <li key={item.key} className="mobile-menu-li">
                    <a href={item.url.href} target={item.url.target} className="mobile-menu-a">{item.url.text}</a>
                </li>;
                preHeaderLinks.push(link);
            })

            return (
                <ul className="mob-menu">
                    {links}
                    {preHeaderLinks}
                </ul>
            );
        };

        return (
            <div>
                <button className='Button-menu' id="nav-icon1"><span></span><span></span><span></span></button>

                <div className="Sidebar mob-menu">

                    <div className="inner">
                        <div className="mobile-logo">
                            {this.props.mobileLogo &&
                                <a href="/"><img src={this.props.mobileLogo.url} alt={this.props.mobileLogo.label} /></a>
                            }
                        </div>
                        <div className="search-mobile">
                            <div className="sign-in">
                                <button className="open-search" onClick={showSearch}></button>
                            </div>
                        </div>
                        <button className='Button-menu' id="nav-icon-close"><span></span><span></span><span></span></button>
                        <div className="mobile-menu-inner">
                            {renderMobileMenu()}
                        </div>
                        <div className="buttons">
                            {this.props.preHeaderPrimaryButton &&
                                <a href={this.props.preHeaderPrimaryButton.href} target={this.props.preHeaderPrimaryButton.target} className="btn">{this.props.preHeaderPrimaryButton.text}</a>
                            }
                            {this.props.primaryButton &&
                                <a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a>
                            }
                        </div>
                    </div>

                </div>
            </div>
        );
    }
}
export default hot(Hamburger);

