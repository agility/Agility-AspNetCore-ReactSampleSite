import React from 'react';
import { hot } from 'react-hot-loader/root'
import './tab-panel.sass'

class ContentPanel extends React.Component {
    constructor() {
        super()
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

        //loop all the tabs and render them
        const tabs = this.props.tabs.map(function (tab) {
            return renderTab(tab)
        })

        return (
            <div className="tabPanel">
                <h2>{this.props.title}</h2>

                {tabs}

            </div>
        );
    }
}
export default hot(ContentPanel);

