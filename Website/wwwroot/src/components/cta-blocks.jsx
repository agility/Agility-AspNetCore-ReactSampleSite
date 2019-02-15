import React from 'react';
import { hot } from 'react-hot-loader/root'
import ResponsiveImage from './responsive-image.jsx'
import './cta-blocks.scss'

class CtaBlocks extends React.Component {

    render() {

        const blocks = this.props.items.map(function (item) {
            return <CtaBlock item={item} key={item.key} />
        })

        return (

            <section className="features p-w comunity-apps">

                <h2 className="title-conponent">{this.props.heading}</h2>
                <p className="intro">{this.props.subHeading}</p>
                <div className="apps-content">
                    <div className="container-my">
                        <div className="row-my">
                            {blocks}
                        </div>
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(CtaBlocks);

class CtaBlock extends React.Component {

    render() {

        return (
            <div className="col-md-4">
                <div className="app-item">
                    <a href={this.props.item.link.href} title={this.props.item.link.text} target={this.props.item.link.target}>
                        <div className="image">
                            <ResponsiveImage img={this.props.item.image}
                                breaks={[{ w: 640, max: 480 }, { w: 900, max: 400 }, { w: 1200, max: 700 }]} />

                        </div>
                        <p>{this.props.item.title}</p>
                    </a>
                </div>
            </div>
        );
    }
}