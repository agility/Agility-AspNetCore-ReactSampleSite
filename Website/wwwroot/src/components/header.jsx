import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.scss'
import SignIn from './sign-in.jsx'
import Hamburger from './hamburger.jsx'
import HeaderSearch from './header-search.jsx'

class Header extends React.Component {
    constructor(props) {
        super(props);
    }

    componentDidMount() {
        //dropdown Menu
        if (document) {
            var hiddenParent = document.querySelector('.has-children');
            hiddenParent.addEventListener('click', function (e) {
                this.classList.toggle('open');
            });

            //check for preview bar
            //HACK
            var previewBar = document.getElementById('pnlAgilityStatusBar');
            if(previewBar) {
                document.getElementsByClassName('header-container')[0].classList.add('is-preview');
            }
        }
    }

    render() {
        let headerClass = "header p-w";

        const renderMenu = (menu, level) => {
            let links = []
            if (!menu || !menu.length || menu.length == 0) return null;

            let itemClassName = "h-menu-li";
            let aClassName = "h-menu-a"
            if (level > 0) {
                itemClassName = "sub-menu-li";
                aClassName = "sub-menu-a"
            }

            menu.forEach(item => {

                const subLinks = renderMenu(item.children, level + 1);
                if (subLinks == null) {
                    //no sub menu
                    links.push(<li className={itemClassName} key={item.key}><a href={item.url} target={item.target} className={aClassName}>{item.text}</a></li>)
                } else {
                    //has a sub menu
                    var li = <li className={itemClassName + ' has-children'} key={item.key}><a href={item.url} target={item.target} className={aClassName}>{item.text}</a>
                        <span className="sub-menu-icon"><img src="https://static.agilitycms.com/layout/img/ico/down.svg" alt="" /></span>
                        <div className="sub-menu-inner">
                            {subLinks}
                        </div>
                    </li>;

                    links.push(li);
                }
            });

            let className = "header-menu";
            if (level > 0) {
                className = "sub-menu";
            }

            return <ul className={className}>{links}</ul>;
        };



        return (

            <div className="header-container">
                <HeaderSearch />
                <SignIn preHeaderLinks={this.props.preHeaderLinks} preHeaderPrimaryButton={this.props.preHeaderPrimaryButton} />
                <Hamburger />
                <header className={headerClass}>
                    <div className="container-my">
                        <div className="header-logo">
                            <a href="/"><img src={this.props.logo.url} alt={this.props.logo.label} /></a>
                        </div>

                        {renderMenu(this.props.menu, 0)}

                        <a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a>
                    </div>
                </header>
                <div className="drop-shadow"></div>
            </div>

        );
    }
}
export default hot(Header);


