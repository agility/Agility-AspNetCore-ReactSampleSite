import React from 'react';
import { hot } from 'react-hot-loader/root'
import './rich-text.sass'

class RichText extends React.Component {

    render() {

        return (

            <section className="rich-text">
                <div className="container p-w-small">
                    <div className="content" dangerouslySetInnerHTML={{__html: this.props.html}}></div>
                </div>
            </section>


        );
    }
}
export default hot(RichText);