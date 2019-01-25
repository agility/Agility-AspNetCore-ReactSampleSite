import React from 'react';
import { hot } from 'react-hot-loader/root'
import './contact-us.sass'
import Form from './_form.jsx'
import FormField from './_form-field.jsx'

class ContactUs extends React.Component {
    constructor(props) {
        super(props)


        this.state = {
            showFormSuccess: false,
            showFormError: false
        };

        this.beforeSubmit = this.beforeSubmit.bind(this);

    }

    /**
     * The pre-submit validation message.
     * @param {the post data} data 
     */
    beforeSubmit(data) {

        //TODO: do some validation here
        return true;

    }



    /**
     * Renders the page UI. Uses the Form component defined above
     * instead of the usual html form.
     * Uses Bootstrap layout classes.
     **/
    render() {
        return (
            <div className="contactUs" >
                <h3>{this.props.heading}</h3>
                <p>{this.props.subheading} </p>
                <div className="card-body">
                    <Form
                        beforeSubmit={this.beforeSubmit}
                        url={'https://prod-05.northcentralus.logic.azure.com:443/workflows/a11e381b67824552973ad4db9c210844/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=wR-EihFnszOvoD5XTK9X9xDasvAL1dUobjzBi-_zIa0'}
                        thanksMessage={this.props.thanksMessage}
                        errorMessage={this.props.errorMessage}
                        validationMessage={this.props.validationMessage}
                    >

                        <FormField id="firstName" label="First Name">
                            <input id={"firstName"} className={"form-control"} required={true} name="firstName" type="text" />
                        </FormField>

                        <FormField id="lastName" label="Last Name">
                            <input id="lastName" className={"form-control"} required={true} name="lastName" type="text" />
                        </FormField>

                        <FormField id="email" label="Email Address">
                            <input id="email" className={"form-control"} required={true} name="email" type="email" />
                        </FormField>

                        {/* <div className={"form-group"}>
                            <label htmlFor={"password"} > Password </label>
                            <input id={"password"} className={"form-control"} required={true} name={"password"} type={"password"}
                                minLength={6} pattern="(?=.*\d)(?=.*[a-z]).{6,}" />
                            <small className="form-text text-muted">Must be at least 6 characters long, contain letters and numbers</small>
                            <div className="invalid-feedback" />
                        </div> */}
                    </Form>
                </div>
            </div>

        );
    }
}
export default hot(ContactUs);

