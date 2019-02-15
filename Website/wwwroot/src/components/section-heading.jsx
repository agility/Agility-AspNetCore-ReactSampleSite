import React from 'react';
import { hot } from 'react-hot-loader/root'
import './section-heading.scss'

class SectionHeading extends React.Component {
    constructor(props) {
        super()
    }
    rawMarkup(propName) {
        const rawMarkup = this.props[propName].toString();
        return { __html: rawMarkup };
    }
    render() {
        return (
           <section className="section-heading p-w">
               <h2 className="title-conponent" dangerouslySetInnerHTML={this.rawMarkup('title')}></h2>
               <span>{this.props.subTitle}</span>
           </section>
        );
    }
}
export default hot(SectionHeading);

