import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.scss'
import { Button, Image } from 'semantic-ui-react'

class Header extends React.Component {
    render() {

        const outputLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                links.push(<li><a href={item.url.href} target={item.url.target}>{item.title}</a></li>)
            });

            return <ul>{links}</ul>;
        };

        return (
            <header>
                <a href="/"><img src={this.props.logo.url} alt={this.props.logo.label} /></a>
                <div>
                    {outputLinks(this.props.preHeaderLinks)}
                </div>
                <div>
                    <a href={this.props.primaryButton.href} target={this.props.primaryButton.target}>{this.props.primaryButton.text}</a>
                </div>
            </header>
        );
    }
}
export default hot(Header);

