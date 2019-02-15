import React from 'react';
import { hot } from 'react-hot-loader/root'
import './sign-in.scss'
import { debug } from 'util';


class SignIn extends React.Component {
    constructor(props) {
        super(props)
    }
    outputLinks() {
        const links = this.props.preHeaderLinks.map(function (f) {
            return <TopHeaderLink data={f.url} key={f.key} />
        })
        return links;
        
    }
    render() {

        function showSearch() {
            var searchFrame = document.querySelector('.search-frame');
            searchFrame.classList.toggle('open');
        }

        return (
            <div className="sign-in p-w">
                <div className="container-my">
                    <button className="open-search" onClick={showSearch}><img src="dist/img/search_black.svg" alt=""/></button>
                    <ul className="sign-in-list">
                        <li><a href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</a></li>
                        {this.outputLinks()}
                    </ul>
                </div>
            </div>
        );
    }
}
export default hot(SignIn);

class TopHeaderLink extends React.Component{
    constructor(props) {
        super(props)
    }
    render() {
        return(
            <li><a href={this.props.data.href} target={this.props.data.target} className="sign-in-help">{this.props.data.text}</a></li>
        );
    }
}

