import React from 'react';
import { hot } from 'react-hot-loader/root'
import './footer.scss'


class Footer extends React.Component {

    // outputLinks = () => {
    //     let lst = this.props.column1Links;
    //     let links = []
    //     if (!lst || lst.length == null) return null;

    //     lst.forEach(item => {

    //         links.push(<td>{item.title}</td>)
    //     });

    //     return <ol>{links}</ol>;
    // };

    render() {

        const outputLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                links.push(<li><a href={item.url.href} target={item.url.target}>{item.title}</a></li>)
            });

            return <ul>{links}</ul>;
        };

        const outputFollowLinks = (lst) => {
            let links = []
            if (!lst || lst.length == null) return null;

            lst.forEach(item => {
                var img = <img src={item.logo.url} alt={item.logo.label}></img>;
                var a = <a href={item.followURL.href} target={item.followURL.target} title={item.title}>{img}</a>
                links.push(<li>{a}</li>)
            });

            return <ul>{links}</ul>;
        };

        return (
            <footer className="container" >
                <h3>{this.props.column1Title}</h3>
                {outputLinks(this.props.column1Links)}

                <h3>{this.props.column2Title}</h3>
                {outputLinks(this.props.column2Links)}

                <h3>{this.props.column3Title}</h3>
                {outputLinks(this.props.column3Links)}

                {/* follow links */}
                {outputFollowLinks(this.props.followLinks)}

                <h3>{this.props.subscribeTitle}</h3>
                <div>{this.props.subscribeDescription}</div>
                <form>
                    <input type="text" placeholder={this.props.subscribeEmailPlaceholder} />
                    <input type="submit" value={this.props.subscribeButtonLabel} />
                </form>

            </footer >
        );
    }
}
export default hot(Footer);

