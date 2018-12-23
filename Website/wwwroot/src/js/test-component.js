import React from 'react';
import { hot } from 'react-hot-loader/root'
import { Button } from 'semantic-ui-react'


class TestComponent extends React.Component {
    render() {
        
        return (
            <div className="container">
                <h1>This is cool</h1>
                <p>yoooo</p>
                <Button content="My Button" primary />
            </div>
        );
    }
}
export default hot(TestComponent);

