import React from 'react';
import { hot } from 'react-hot-loader/root'
import './sign-in.sass'


class SignIn extends React.Component {
    render() {
        return (
            <div className="sign-in p-w">
                <ul className="sign-in-list">
                    <li><button className="btn">Lets Chat!</button></li>
                    <li><a href="#" className="sign-in-help">Help</a></li>
                    <li><a href="#" className="sign-in-log">Sign In</a></li>
                </ul>
            </div>
        );
    }
}
export default hot(SignIn);

