import React from 'react';
import { hot } from 'react-hot-loader/root'
import './testimonials-listing.sass'

class TestimonialsListing extends React.Component {
    constructor() {
        super()
    }

    render() {

        const testimonials = this.props.testimonials.map(function (item) {
            return <TestimonialContent item={item} />
        })

        return (

            <section className="features p-w testimonials-listing">
                <div className="canvas" id="canvas-4">
                    <div className="img">
                        {/* <div className="item item-tangle-top-3 twentyone w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentytwo w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentythree w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfour w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfive w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentysix w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyseven w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyeight w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentynine w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 thirty w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div> */}
                    </div>
                </div>

                <h2 className="title-conponent">{this.props.header}</h2>
                <h3 className="testimonials-subtitle">{this.props.subHeading}</h3>
                <div className="products-staff">
                    <div className="row-my">
                        {testimonials}
                    </div>
                    <div className="button-wrap">
                        <a className="btn" href={this.props.bottomlink.href} target={this.props.bottomlink.target}>{this.props.bottomlink.text}</a>
                    </div>
                </div>

            </section>


        );
    }
}
export default hot(TestimonialsListing);

class TestimonialContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        return (

            <div className="staff-item">
                <div className="item-inner">
                    <div className="image">
                        {this.props.item.headshot &&
                            <img src={this.props.item.headshot.url + '?w=200&h=200'} alt={this.props.item.title} />
                        }
                    </div>
                    <div className="title">
                        <h3>{this.props.item.title}</h3>
                        <span>{this.props.item.jobTitle}</span>
                    </div>
                    <p>{this.props.item.excerpt}</p>
                </div>
            </div>
        );
    }
}