import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'
import { RedocStandalone } from 'redoc';

class ApiReference extends Component {
    componentDidMount() {
        (function (p,o,s,t,m,a,n) {
            !p[s] && (p[s] = function () { (p[t] || (p[t] = [])).push(arguments); });
            !o.getElementById(s+t) && o.getElementsByTagName("head")[0].appendChild((
            (n = o.createElement("script")),
            (n.id = s+t), (n.async = 1), (n.src = m), n
            ));
        }(window, document, "_pm", "PostmanRunObject", "https://run.pstmn.io/button.js"));
    }
    render() {

        return (

            <div id="api-reference">
                <div className="postman-run-button"
                        data-postman-action="collection/import"
                        data-postman-var-1="3497f11fc6243a0dc5da"></div>

                <RedocStandalone specUrl="https://g5s2z5b3.stackpathcdn.com/swagger/v1/swagger.json"  />
            </div>
        );
    }
}

export default hot(ApiReference);