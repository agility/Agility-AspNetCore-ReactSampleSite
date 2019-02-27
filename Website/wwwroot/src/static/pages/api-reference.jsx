import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'
import { RedocStandalone } from 'redoc';

class ApiReference extends Component {
    render() {

        return (
            <div id="api-reference">
                <RedocStandalone specUrl="https://api.apis.guru/v2/specs/instagram.com/1.0.0/swagger.yaml"  />
            </div>
        );
    }
}

export default hot(ApiReference);