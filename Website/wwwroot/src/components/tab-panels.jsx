import React from 'react';
import { hot } from 'react-hot-loader/root'
import './tab-panels.sass'

class TabPanels extends React.Component {
    constructor() {
        super()
    }

    componentDidMount() {
        document.addEventListener('click', function (event) {
            //if not tabs
            if(!event.target.classList.contains('features-tab')) return;
    
            //if tabs
            var elem = event.target;
            var elemAttr = elem.getAttribute('data-tab');
            var el = document.querySelectorAll('.features-tab');
            for (var i = 0; i < el.length; i++) {
                el[i].classList.remove('active');
            }
            elem.classList.add('active');
    
    
            var current = document.querySelector("[data-blocktab='"+ elemAttr +"']");
            var tab = document.querySelectorAll('.features-toggle-tab-item');
    
            function hideTabs() {
                for (var i = 0; i<tab.length; i++) {
                    tab[i].classList.remove('visible');
                    tab[i].classList.remove('active');
                }
            }
            hideTabs();
    
            function showTab(){
                document.querySelector(".features-toggle-tab-item[data-blocktab='"+ elemAttr +"']").classList.add('active');
    
                setTimeout(function () {
                    current.classList.add('visible');
                },300);
            }
            showTab();
    
    
        }, false);
    }
    rawMarkup(propName) {
        const rawMarkup = this.props[propName].toString();
        return { __html: rawMarkup };
    }
    render() {

        const renderTab = (tab) => {
            //render one tab
            return (
                <div key={tab.key}>
                    <h3>{tab.title}</h3>
                    <div dangerouslySetInnerHTML={{ __html: tab.textBlob }} />
                    <div>
                        <img src={tab.image.url} alt={tab.image.label} />
                    </div>
                    <div>
                        <a href={tab.primaryButton.href} target={tab.primaryButton.target}>{tab.primaryButton.text}</a>
                    </div>
                </div>
            );
        }

        const tabNav = this.props.tabs.map(function(tab) {
            return <TabPanelNavItem title={tab.title} key={tab.key} />
        })

        //loop all the tabs and render them
        const tabs = this.props.tabs.map(function (tab, index) {
            return <TabPanelContent tab={tab} key={tab.key} index={index} />
        })

        return (
            // <div className="tabPanel">
            //     <h2>{this.props.title}</h2>

            //     {tabs}

            // </div>

            <section id="sec-3" className="features p-w">
                <div className="canvas" id="canvas-3">
                    <div className="img">
                        <div className="item item-tangle-top-3 twentyone w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentytwo w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentythree w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfour w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfive w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentysix w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyseven w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyeight w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentynine w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 thirty w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>
                <div className="rotated-bg"></div>

                <h2 className="title-conponent" dangerouslySetInnerHTML={this.rawMarkup('title')}></h2>
                <span dangerouslySetInnerHTML={this.rawMarkup('subTitle')}></span>

                <ul className="features-tabs">
                    {tabNav}
                </ul>

                <div className="features-toggle-tab-items">
                    {tabs}
                    {/* <div className="features-toggle-tab-item active visible" data-blocktab="design">
                        <div className="img"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/features/pic_2.png" alt="" /></div>
                        <div className="content">
                            <h3 className="feature-title">Build the foundation for long lasting success. Start with a content first approach and design your content structures and relationships to enable easily distribution of your content ANYWHERE!</h3>
                            <ul className="feature-list">
                                <li className="feature-li-item"> <span></span>
                                    Set up fields, entries and relationships in whatever way makes the most sense for your project
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Content structure and distribution
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Choose the components you will need for your project (Digital Content, Media, UGC, Ecommerce, Ticketing, Search, Personalization)
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Workflow and approval setup
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Build in Localization
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Powerful templating
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Configurable Rich Authoring experience - Adjust the interface to the skillset of your team
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Plan Personalized Content needs
                                </li>
                            </ul>
                            <button className="btn">Checkout All Our Features</button>
                        </div>
                    </div>
                    <div className="features-toggle-tab-item" data-blocktab="build">
                        <div className="img"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/features/pic_2.png" alt="" /></div>
                        <div className="content">
                            <h3 className="feature-title">Build the foundation for long lasting success. Start with a content first approach and design your content structures and relationships to enable easily distribution of your content ANYWHERE!</h3>
                            <ul className="feature-list">
                                <li className="feature-li-item"> <span></span>
                                    Set up fields, entries and relationships in whatever way makes the most sense for your project
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Content structure and distribution
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Choose the components you will need for your project (Digital Content, Media, UGC, Ecommerce, Ticketing, Search, Personalization)
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Workflow and approval setup
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Build in Localization
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Powerful templating
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Configurable Rich Authoring experience - Adjust the interface to the skillset of your team
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Plan Personalized Content needs
                                </li>
                            </ul>
                            <button className="btn">Checkout All Our Features</button>
                        </div>
                    </div>
                    <div className="features-toggle-tab-item" data-blocktab="deploy">
                        <div className="img"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/features/pic_2.png" alt="" /></div>
                        <div className="content">
                            <h3 className="feature-title">Build the foundation for long lasting success. Start with a content first approach and design your content structures and relationships to enable easily distribution of your content ANYWHERE!</h3>
                            <ul className="feature-list">
                                <li className="feature-li-item"> <span></span>
                                    Set up fields, entries and relationships in whatever way makes the most sense for your project
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Content structure and distribution
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Choose the components you will need for your project (Digital Content, Media, UGC, Ecommerce, Ticketing, Search, Personalization)
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Workflow and approval setup
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Build in Localization
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Powerful templating
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Configurable Rich Authoring experience - Adjust the interface to the skillset of your team
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Plan Personalized Content needs
                                </li>
                            </ul>
                            <button className="btn">Checkout All Our Features</button>
                        </div>
                    </div>
                    <div className="features-toggle-tab-item" data-blocktab="manage">
                        <div className="img"><img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/features/pic_2.png" alt="" /></div>
                        <div className="content">
                            <h3 className="feature-title">Build the foundation for long lasting success. Start with a content first approach and design your content structures and relationships to enable easily distribution of your content ANYWHERE!</h3>
                            <ul className="feature-list">
                                <li className="feature-li-item"> <span></span>
                                    Set up fields, entries and relationships in whatever way makes the most sense for your project
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Content structure and distribution
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Choose the components you will need for your project (Digital Content, Media, UGC, Ecommerce, Ticketing, Search, Personalization)
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Workflow and approval setup
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Build in Localization
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Powerful templating
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Configurable Rich Authoring experience - Adjust the interface to the skillset of your team
                                </li>
                                <li className="feature-li-item"> <span></span>
                                    Plan Personalized Content needs
                                </li>
                            </ul>
                            <button className="btn">Checkout All Our Features</button>
                        </div>
                    </div> */}

                </div>
            </section>


        );
    }
}
export default hot(TabPanels);

class TabPanelNavItem extends React.Component {
    constructor(props) {
        super(props)

        //todo: make more friendly
        this.friendlyName = this.props.title.toLowerCase()
    }
    render() {
        return(
            <li className="features-tab" data-tab={this.friendlyName}>{this.props.title}</li>
        );
    }
}

class TabPanelContent extends React.Component {
    constructor(props) {
        super(props)

        //todo: make more friendly
        this.friendlyName = this.props.tab.title.toLowerCase()
    }
    render() {
        console.log(this.props);
        
        let containerClass = null;
        if(this.props.index == 0) {
            containerClass = "active visible"; 
        }

        return(

            <div className={'features-toggle-tab-item ' + containerClass} data-blocktab={this.friendlyName}>
                <div className="img"><img src={this.props.tab.image.url} alt={this.props.tab.image.label} /></div>
                <div className="content">
                    <h3 className="feature-title">{this.props.tab.description}</h3>

                    <div dangerouslySetInnerHTML={{ __html: this.props.tab.textBlob }} />

                    <button href={this.props.tab.primaryButton.href} target={this.props.tab.primaryButton.target} className="btn">{this.props.tab.primaryButton.text}</button>
                </div>
            </div>
        );
    }
}

