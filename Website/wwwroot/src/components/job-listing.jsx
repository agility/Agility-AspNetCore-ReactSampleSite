
import React from 'react';
import { hot } from 'react-hot-loader/root'
import './job-listing.scss'

class JobListing extends React.Component {
    constructor() {
        super()
    }
    componentDidMount() {

    }

    render() {


        var jobs = this.props.jobs.map(function (f) {
            return <JobContent data={f} key={f.key} />;
        })

        return (

            <section className="features p-w job-listing">
                <div className="canvas" id="canvas-5">
                    <div className="img">
                        <div className="item item-tangle-top-3 twentyone w58">
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
                        </div>
                    </div>
                </div>

                <h2 className="title-conponent">{this.props.title}</h2>
                <div className="products-features">
                    <div className="container-my">
                        <div className="row-my">
                            <div className="col-md-4">
                                <div className="features-left">
                                    <h3>{this.props.sideTitle}</h3>
                                    <div className="text" dangerouslySetInnerHTML={{ __html: this.props.sideBody }} />
                                    <a class="btn" href={this.props.sideLink.href} target={this.props.sideLink.target}>{this.props.sideLink.text}</a>
                                </div>
                            </div>
                            <div className="col-md-8">
                                <div className="features-right">
                                    <div className="row-my">
                                        {jobs}
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </section>

        );
    }
}
export default hot(JobListing);


class JobContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        return (
            <div className="col-md-4">
                <div className="featurer-item">
                    <div className="item-inner">
                        <div className="image">
                            <img src={this.props.data.icon.url} alt={this.props.data.icon.label} />
                        </div>
                        <div className="title">
                            <h4>{this.props.data.title}</h4>
                        </div>
                        <div dangerouslySetInnerHTML={{ __html: this.props.data.textBlob }} />
                        {this.props.data.bottomLink &&
                            <a className="arrow-button" href={this.props.data.bottomLink.href} target={this.props.data.bottomLink.target}><span>{this.props.data.bottomLink.text}</span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /></a>
                        }

                    </div>
                </div>
            </div>
        );
    }
}
