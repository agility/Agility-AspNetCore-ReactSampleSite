import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import FormPage from '../../components/form.jsx'
import FormPageProps from '../data/form-purple.json'

class Form extends Component {
    render() {

        return (
            <div id="form-page" className="purple">
                <FormPage {...FormPageProps } />
            </div>
        );
    }
}

export default hot(Form);