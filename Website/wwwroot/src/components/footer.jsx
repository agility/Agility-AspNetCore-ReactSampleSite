import React from 'react';
import { hot } from 'react-hot-loader/root'
import './footer.sass'


class Footer extends React.Component {

    render() {
        
        const outputLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                links.push(<li className="foter-menu-li" key={item.key}><a href={item.url.href} target={item.url.target}>{item.title}</a></li>)
            });

            return <ul>{links}</ul>;
        };

        const outputFollowLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                var img = <img src={item.logo.url} alt={item.logo.label}></img>;
                var a = <a href={item.followURL.href} target={item.followURL.target} title={item.title}>{img}</a>
                links.push(<li className="foter-menu-li" key={item.key}>{a}</li>)
            });

            return links;
        };

        const getYear = () => {
            const d = new Date();
            return d.getFullYear();
        }

        return (

            // </footer>
            <footer className="foter p-w">
                <div className="foter-inner">

                    <ul className="foter-menu menu-product">
                        <li className="foter-menu-li title"><span>{this.props.column1Title}</span></li>
                        {outputLinks(this.props.column1Links)}
                    </ul>
                    <ul className="foter-menu menu-about">
                        <li className="foter-menu-li title"><span>{this.props.column2Title}</span></li>
                        {outputLinks(this.props.column2Links)}
                    </ul>
                    <ul className="foter-menu menu-information">
                        <li className="foter-menu-li title"><span>{this.props.column3Title}</span></li>
                        {outputLinks(this.props.column3Links)}
                    </ul>
                    <ul className="foter-menu menu-social">
                        <li className="foter-menu-li title"><span>{this.props.followTitle}</span></li>
                        {outputFollowLinks(this.props.followLinks)}
                    </ul>
                    <div className="foter-subscribe">
                        <span>{this.props.subscribeTitle}</span>
                        <p>{this.props.subscribeDescription}</p>
                        <form action="" className="foter-subscribe-form">
                            <input type="text" placeholder={this.props.subscribeEmailPlaceholder} />
                            <input type="submit" placeholder={this.props.subscribeButtonLabel} />
                        </form>
                    </div>

                </div>

                <div className="foter-copyright">
                    <p>{this.props.bottomCopyright} {getYear()}</p>
                    <ul className="foter-copyright-menu">
                        <li dangerouslySetInnerHTML={{__html: this.props.bottomPrivacyPolicyLink}}></li>
                        <span>|</span>
                        <li dangerouslySetInnerHTML={{__html: this.props.bottomSecurityLink}}></li>
                    </ul>
                </div>
            </footer>

                
        );
    }
}
export default hot(Footer);

