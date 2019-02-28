import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.scss'
import SignIn from './sign-in.jsx'
import Hamburger from './hamburger.jsx'

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



        return (

            <div>
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
            </div>

        );
    }
}
export default hot(Header);

class HeaderSearch extends React.Component {
    constructor(props) {
        super(props);

        this.handleOnChange = this.handleOnChange.bind(this);
        this.loadResults = this.loadResults.bind(this);
        this.loadMore = this.loadMore.bind(this);


        this.state = {
            results: [],
            fromNumber: 0,
            toNumber: 0,
            query: '',
            loading: false,
            count: 0,
            take: 10,
            skip: 0
        }

        this.abortController = new AbortController();
    }


    componentDidMount() {
        //dropdown Menu
        if (document) {
            //search    
            document.addEventListener('keydown', function (event) {
                var key = event.key;
                if ("Escape" === key) {
                    hideSearch();
                }
            });

        }
    }

    componentWillMount(){
        this.timer = null;
    }

    loadMore() {
        this.loadResults(this.state.query, true);
    }

    loadResults(query, loadingMore){
        let skip = loadingMore ? this.state.skip + this.state.take : 0;
        let formData = new FormData();
        formData.append('query', query);
        formData.append('top', this.state.take);
        formData.append('skip', skip);

        if(loadingMore){
            this.setState({
                loading: true,
                query: query,
                skip: skip
            })
        } else {
            this.setState({
                loading: true,
                query: query,
                skip: skip,
                results: []
            })
        }


        this.abortController.abort();
        this.abortController = new AbortController();
        
        fetch('https://search.agilitycms.com/search', {
            method: 'post',
            body: formData,
            credentials: 'include',
            signal: this.abortController.signal,
            headers: {
                'as-WebsiteName': 'Agility CMS Website',
                'as-AuthKey': '35qIX1Ky0nQL1o9WTiGaVlZSy59P_6KB-teYWGz02Q4'
            }
        }).then(response => response.json())
        .then(data => {
            if(data.IsError){
                //something went wrong
                this.setState({
                    loading: false,
                    count: 0
                })
            } else if(data.ResponseData && data.ResponseData.Results) {
                //render results
                this.setState(prevState =>({
                    loading: false,
                    count: data.ResponseData.Count,
                    results: loadingMore ? prevState.results.concat(
                        data.ResponseData.Results.map(function(result){
                            return {
                                title: result.Title,
                                text: result.Description || result.Highlight,
                                category: result.Category,
                                href: result.Url
                            }
                        })
                    ) :
                    data.ResponseData.Results.map(function(result){
                        return {
                            title: result.Title,
                            text: result.Description || result.Highlight,
                            category: result.Category,
                            href: result.Url
                        }
                    })
                }));
            } else {
                //no results
                this.setState({
                    count: 0,
                    loading: false
                })
            }
        }).catch(err => {
            if(err.name === "AbortError"){
                console.warn('aborted');
                return;
            }

            this.setState({
                loading: false,
                count: 0
            })

            console.warn("An error occurred while loading data...", err);
        });
    }

    handleOnChange(event){
        var self = this;

        var query = event.target.value;

        self.setState(prevState => ({
            results: [],
            loading: false
        }));

        
        if(query.length >= 3){
        
            clearTimeout(self.timer);
    
            self.timer = setTimeout(function(){
                self.loadResults(query);
            }, 300);

        } else {
            self.setState({
                query: null,
                results: [],
                loading: false
            })
        }
    }

    render() {
        var self = this;

        var results = this.state.results.map(function (res) {
            return <HeaderSearchResult result={res} />
        });

        function hideSearch() {
            var searchFrame = document.querySelector('.search-frame');
            searchFrame.classList.toggle('open');
            document.querySelector('html').classList.toggle('search-open');
            document.querySelector('.open-search').classList.toggle('close');
            // document.getElementById('frontend-only').classList.toggle('search-open');
        }

        return (
            <div className="search-frame">
                <div className="search-inner" onClick={hideSearch}></div>
                <div className="search-form">
                    <form action="">
                        <input id="search-input" type="text" placeholder="Search" onChange={this.handleOnChange} />
                    </form>
                </div>
                <div className="search-result">
                    <div className="result-inner">
                        <div className="results-quant">
                            { this.state.loading && this.state.query &&
                                <p>Searching for {this.state.query}...</p>
                            }

                            {
                                !this.state.loading && this.state.query &&
                                <p>Results for {this.state.query} (<span>{this.state.count}</span>) - Showing {this.state.results.length}</p>
                            }
                        </div>
                        <div className="search-items">
                            {results}

                            {
                                this.state.results && this.state.results.length > 0 && this.state.results.length < this.state.count && !this.state.loading &&
                                <div className="load-more-container">
                                    <a href="#" onClick={this.loadMore} className="btn">
                                        Load More
                                    </a>
                                </div>
                            }

                            {
                                this.state.results && this.state.results.length > 0 && this.state.loading &&
                                <div className="load-more-container">
                                    <a href="#" className="btn" disabled>
                                        Loading...
                                    </a>
                                </div>
                            }
                        </div>
                        <div className="result-footer">
                            <p>Like our search? Get <a href="" target="_blank">Agility Search</a> for your website today.</p>
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}

class HeaderSearchResult extends React.Component {
    render() {

        var category = this.props.result.label;
        var categoryClass = 'label ' + category;

        return (
            <div className="search-item d-flex ai-center">
                <div className="si-left">
                    <h3 className="h3"><a href={this.props.result.href}>{this.props.result.title}</a></h3>
                    <div className="text" dangerouslySetInnerHTML={{ __html: this.props.result.text }}></div>
                </div>
                <div className="si-right">
                    <div className={categoryClass}>{category}</div>
                </div>
            </div>
        );
    }
}

