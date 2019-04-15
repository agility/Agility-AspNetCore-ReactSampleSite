import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import RequestADemo from '../../components/request-a-demo.jsx'
import FormPageProps from '../data/form-yellow.json'

class FormYellow extends Component {
    render() {

        return (
            <RequestADemo {...FormPageProps } />
        );
    }
}

export default hot(FormYellow);