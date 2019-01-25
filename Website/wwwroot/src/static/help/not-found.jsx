import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'
import SamplePageCode from './_boilerplate-page.txt'
import SamplePageRoute from './_boilerplate-route.txt'
import './not-found.sass'

class NotFound extends Component {
  render() {

    return (
      <div id="not-found" className="p-w">        
        <h1>Could not find this page in the frontend app</h1>
        <p>See <a href="/help">Help Page</a> for details on how to create a new static page.</p>
      </div>
    );
  }
}

export default hot(NotFound);