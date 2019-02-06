import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import RichTextPage from '../../components/rich-text.jsx'
import RichTextProps from '../data/rich-text.json'

class RichText extends Component {
    render() {

        return (
            <div id="rich-text-page">
                <RichTextPage {...RichTextProps } />
            </div>
        );
    }
}

export default hot(RichText);