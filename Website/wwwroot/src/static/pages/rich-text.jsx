import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import RichText from '../../components/rich-text.jsx'
import RichTextProps from '../data/rich-text.json'

class RichTextPage extends Component {
    render() {

        return (
            <div id="rich-text-page">
                <RichText {...RichTextProps } />
            </div>
        );
    }
}

export default hot(RichTextPage);