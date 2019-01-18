import React from 'react';
import { hot } from 'react-hot-loader/root'
import './footer.scss'


class Footer extends React.Component {
    render() {
        return (
            <footer className="container">
                <h1>{this.props.column1Title}</h1>
            </footer>
        );
    }
}
export default hot(Footer);

