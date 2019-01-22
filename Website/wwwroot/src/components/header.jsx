import React from 'react';
import { hot } from 'react-hot-loader/root'
import './header.scss'
import { Button, Image } from 'semantic-ui-react'

class Header extends React.Component {
    render() {
        return (
            <header>

                <Image src={this.props.logo.url} size='small' />
                <h1>Header DEV TEST</h1>
            </header>
        );
    }
}
export default hot(Header);

