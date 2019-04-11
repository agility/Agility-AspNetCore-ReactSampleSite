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

        var isPrimaryTheme = overallColour == 'yellow';
        var btnStyles = 'btn' + (isPrimaryTheme ? ' btn-secondary' : '');
        var styles = { backgroundColor: pageBg, color: textColor }


        var formBg = colourObj.formBg;
        var formColor = colourObj.formColor;
        var stylesForm = { backgroundColor: formBg, color: formColor }

        return (
            <div id="form-page">
                <section className={"p-w form-container " + overallColour} style={styles}>

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