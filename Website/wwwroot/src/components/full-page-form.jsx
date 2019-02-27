import React from 'react';
import { hot } from 'react-hot-loader/root'
import './full-page-form.scss'
import FormColours from '../static/data/form-colours.json'
import Form from './_form.jsx'

class FullPageForm extends React.Component {
    constructor() {
        super()
    }

    render() {

        var overallColour = this.props.colour;
        var colourObj = FormColours[overallColour];

        var pageBg = colourObj.pageBg;
        var textColor = colourObj.textColor;
        var btnStyles = { backgroundColor: colourObj.btnBGColor, color: colourObj.btnTextColour }
        var styles = { backgroundColor: pageBg, color: textColor }


        var formBg = colourObj.formBg;
        var formColor = colourObj.formColor;
        var stylesForm = { backgroundColor: formBg, color: formColor }

        return (
            <div id="form-page">
                <section className={"p-w form-container " + overallColour} style={styles}>
                    <div className="canvas" id="canvas-1">
                        <div className="img">
                            <div className="item item-tangle-top one w58">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top two w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top three w58">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top four w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top five w58">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top six w58 rotate">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top seven w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top eight w84 rotate">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top nine w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top ten w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top eleven w58 rotate">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top twelve w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top thirteen w58">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top fourteen w84 rotate">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top fifteen w58 rotate">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top sixteen w58">
                                    <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top seventeen w84">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                                <div className="item item-tangle-top eighteen w84 rotate">
                                    <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                                </div>
                        </div>
                    </div>
                    <div className="container-my">
                        <div className="row-my">
                            <div className="col-md-6">
                                <div className="form-left">
                                    <h1 className="h1">{this.props.title}</h1>
                                    <h3 className="h3">{this.props.subTitle}</h3>
                                    <div className="content" dangerouslySetInnerHTML={{ __html: this.props.text }}></div>
                                </div>
                            </div>
                            <div className="col-md-6">
                                <div className="form-right" style={stylesForm}>

                                    <Form
                                        beforeSubmit={this.beforeSubmit}
                                        postURL={this.props.postURL}
                                        thanksMessage={this.props.thanksMessage}
                                        conversionScript={this.props.conversionScript}
                                        redirectURL={this.props.redirectURL}
                                        errorMessage={this.props.errorMessage}
                                        validationMessage={this.props.validationMessage}
                                        btnStyles={btnStyles}
                                    >
                                        <h3 className="form-title">{this.props.formTitle}</h3>
                                        {this.props.children}
                                    </Form>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>

        );
    }
}
export default hot(FullPageForm);