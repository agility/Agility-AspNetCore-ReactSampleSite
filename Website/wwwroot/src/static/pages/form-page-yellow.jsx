import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import FormPage from '../../components/form.jsx'
import FormPageProps from '../data/form-yellow.json'

class FormYellow extends Component {
    render() {

        return (
            <div id="form-page" className="yellow">
                <FormPage {...FormPageProps } />
            </div>
        );
    }
}

export default hot(FormYellow);