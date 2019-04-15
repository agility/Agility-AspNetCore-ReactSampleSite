import React from 'react';
import { hot } from 'react-hot-loader/root'
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';
import './tab-panels.scss'


class TabPanels extends React.Component {
    constructor() {
        super()
    }

    componentDidMount() {
        
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

        const tabNav = this.props.tabs.map(function (tab) {
            return <Tab key={tab.key}>{tab.title}</Tab>
        })

        //loop all the tabs and render them
        const tabs = this.props.tabs.map(function (tab, index) {
            return <TabPanel key={tab.key}>
                <div className="img"><img src={tab.image.url} alt={tab.image.label} /></div>
                    <div className="content">
                        <h3 className="feature-title">{tab.description}</h3>

                        <div dangerouslySetInnerHTML={{ __html: tab.textBlob }} />

                        {tab.primaryButton &&
                        <a href={tab.primaryButton.href} target={tab.primaryButton.target} className="btn">{tab.primaryButton.text}</a>
                        }
                </div>
            </TabPanel>
        })

        return (
  

            <section id="sec-3" className="features p-w">
                <div className="canvas" id="canvas-3">
                    <div className="img">
                        <div className="item item-tangle-top-3 twentyone w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentytwo w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentythree w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfour w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfive w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentysix w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyseven w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyeight w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentynine w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 thirty w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>

                <h2 className="title-conponent" dangerouslySetInnerHTML={this.rawMarkup('title')}></h2>
                <span dangerouslySetInnerHTML={this.rawMarkup('subTitle')}></span>

                <Tabs forceRenderTabPanel={true}>
                    <TabList>
                        {tabNav}
                    </TabList>
                    <div className="container-my">
                        <div className="features-toggle-tab-items">
                            {tabs}
                        </div>
                    </div>
                </Tabs>
            </section>


        );
    }
}
export default hot(TabPanels);



