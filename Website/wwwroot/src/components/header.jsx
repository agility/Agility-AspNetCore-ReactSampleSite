import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.scss'


class Header extends React.Component {
    render() {
        return (
            <header>
                <h1>Header</h1>
            </header>
        );
    }
}
export default hot(Header);

