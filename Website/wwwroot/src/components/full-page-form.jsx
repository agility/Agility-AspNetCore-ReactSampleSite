import React from 'react';
import { hot } from 'react-hot-loader/root'
import './form.sass'
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

            <section className={"p-w form-container " + overallColour} style={styles}>
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
            </section>

        );
    }
}
export default hot(FullPageForm);