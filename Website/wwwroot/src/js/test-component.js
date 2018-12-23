import React from 'react';
import { hot } from 'react-hot-loader/root'


class TestComponent extends React.Component {
    render() {
        
        return (
            <div className="container">
                <h1>This is cool</h1>
                <p>yoooo</p>
            </div>
        );
    }
}
export default hot(TestComponent);

