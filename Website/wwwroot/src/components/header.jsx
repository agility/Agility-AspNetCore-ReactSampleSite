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
        hiddenParent.addEventListener('click', function (e) {

            this.classList.toggle('open');
        });
    }
    render() {

        const renderMenu = (menu, level) => {
            let links = []
            if (!menu || !menu.length || menu.length == 0) return null;

            menu.forEach(item => {

                const subLinks = renderMenu(item.children);
                if (subLinks == null) {
                    //no sub menu
                    links.push(<li className="h-menu-li" key={item.key}><a href={item.url} target={item.target} className="h-menu-a">{item.text}</a></li>)
                } else {
                    //has a sub menu
                    var li = <li className="h-menu-li has-children" key={item.key}><a href={item.url} target={item.target} className="h-menu-a">{item.text}</a>
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

            return <ul class={className}>{links}</ul>;
        };
        console.log(this.props);
        return (
            <div>
                <SignIn preHeaderLinks={this.props.preHeaderLinks} primaryButton={this.props.primaryButton} />
                <Hamburger />
                <header className="header p-w">
                    <div className="header-logo">
                        <a href="/"><img src={this.props.logo.url} alt={this.props.logo.label} /></a>
                    </div>

                    {renderMenu(this.props.menu)}

                    <button href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</button>
                </header>
            </div>
        );
    }
}
export default hot(Header);

