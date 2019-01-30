
import React from 'react';
import { hot } from 'react-hot-loader/root'
import './testimonials.sass'

class Testimonials extends React.Component {
    constructor() {
        super()
    }


    render() {
        console.log("testimonials", this.props);
        var testimonials = this.props.testimonials.map(function (f) {
            return <TestimonialSmallBlock data={f} key={f.key} />;
        })

        return (
            <section class="testimonials">
                <h2 >{this.props.header}</h2>
                <h3>

                    {this.props.subHeading}
                </h3>
                <div>
                    {testimonials}
                </div>
                <div>
                    <a href={this.props.bottomlink.href} target={this.props.bottomlink.target}>{this.props.bottomlink.text}</a>
                </div>
            </section>


        );
    }
}

class TestimonialSmallBlock extends React.Component {
    render() {

        return (

            <div class="testimonial-person">
                <h3>{this.props.data.title}</h3>
                <div>{this.props.data.jobTitle}</div>
                <div>{this.props.data.excerpt}</div>
            </div>
        );
    }
}

export default hot(Testimonials);

