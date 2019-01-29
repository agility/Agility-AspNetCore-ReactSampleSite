import React from 'react';
import { hot } from 'react-hot-loader/root'
import './products-staff.sass'

class ProductsStaff extends React.Component {
    constructor() {
        super()
    }
    rawMarkup(propName) {
        const rawMarkup = this.props[propName].toString();
        return { __html: rawMarkup };
    }
    render() {


        const productsStaff = this.props.items.map(function (staff) {
            return <ProductsStaffContent staff={staff}/>
        })

        return (

            <section id="sec-4" className="features p-w">
                <div className="canvas" id="canvas-4">
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
                <div className="rotated-bg"></div>

                <h2 className="title-conponent" dangerouslySetInnerHTML={this.rawMarkup('title')}></h2>

                <div className="products-staff">
                    <div className="row-my">
                        {productsStaff}
                    </div>
                    <div className="button-wrap">
                        <a className="btn" href="">Checkout Case Studies</a>
                    </div>
                </div>

            </section>


        );
    }
}
export default hot(ProductsStaff);

class ProductsStaffContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        return (

            <div className="staff-item">
                <div className="item-inner">
                    <div className="title">
                        <h3>{this.props.staff.title}</h3>
                        <span>{this.props.staff.position}</span>
                    </div>
                    <p>{this.props.staff.content}</p>
                </div>
            </div>
        );
    }
}