import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.scss'
import SignIn from './sign-in.jsx'
import Hamburger from './hamburger.jsx'

class Header extends React.Component {
    constructor() {
        super()
    }
    componentDidMount() {
        //dropdown Menu
        if (document) {
            var hiddenParent = document.querySelector('.has-children');
            hiddenParent.addEventListener('click', function (e) {
                this.classList.toggle('open');
            });

            //search    
            document.addEventListener('keydown', function(event) {
                var key = event.key;
                if ("Escape" === key) {
                    hideSearch();
                }
            });

        }
    }

    render() {



        let headerClass = "header p-w";

        //MOD: JOEL V - THIS BREAKS SERVER RENDERING - should be handled in css
        // var url = "";//document.location;
        // url = url.toString();
        // url = url.split('/');
        // var curUrl = url[3];
        // if ('' == curUrl || 'product' == curUrl || 'community' == curUrl || 'partners' == curUrl) {
        //     var headerClass = "header p-w";
        // } else  {
        //     ;
        // }

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

        function hideSearch() {
            var searchFrame = document.querySelector('.search-frame');
            searchFrame.classList.toggle('open');
            document.querySelector('html').classList.toggle('search-open');
            document.querySelector('.open-search').classList.toggle('close');
            document.getElementById('frontend-only').classList.toggle('search-open');
        }

        var searchResults = require('../static/data/search-results.json');
        searchResults = searchResults.results;
        var results = searchResults.map(function(res){
            return <SearchResults result={res}/>
        });

        return (

            <div>
                <div className="search-frame">
                    <div className="search-inner" onClick={hideSearch}></div>
                    <div className="search-form">
                        <form action="">
                            <input type="text" placeholder="Search" />
                        </form>
                    </div>
                    <div className="search-result">
                        <div className="result-inner">
                            <div className="results-quant">
                                <p>Results for Hello (<span>3</span>)</p>
                            </div>
                            <div className="search-items">
                                {results}
                            </div>
                            <div className="result-footer">
                                <p>Like our search? Get <a href="" target="_blank">Agility Search</a> for your website today.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <SignIn preHeaderLinks={this.props.preHeaderLinks} primaryButton={this.props.primaryButton} />
                <Hamburger />
                <header className={headerClass}>
                    <div className="container-my">
                        <div className="header-logo">
                            <a href="/"><img src={this.props.logo.url} alt={this.props.logo.label} /></a>
                        </div>

                        {renderMenu(this.props.menu, 0)}

                        <button href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</button>
                    </div>
                </header>
            </div>

        );
    }
}
export default hot(Header);

class SearchResults extends React.Component{
    render() {

        var label = this.props.result.label;
        var labelClass = 'label '+label;

        return(
            <div className="search-item d-flex ai-center">
                <div className="si-left">
                    <h3 className="h3"><a href={this.props.result.href}>{this.props.result.title}</a></h3>
                    <div className="text" dangerouslySetInnerHTML={{__html: this.props.result.text}}></div>
                </div>
                <div className="si-right">
                    <div className={labelClass}>{label}</div>
                </div>
            </div>
        );
    }
}

