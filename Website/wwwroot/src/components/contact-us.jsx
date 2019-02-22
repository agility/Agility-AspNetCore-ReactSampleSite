import React from 'react';
import { hot } from 'react-hot-loader/root'
import FullPageForm from './full-page-form.jsx'
import FormField from './_form-field.jsx'
import Countries from '../static/data/countries.json'

class ContactUs extends React.Component {
    constructor() {
        super()
    }

    componentDidMount() {
        if (window != undefined && window) {
            var elem = document.getElementById("firstname");
            if (elem) elem.focus();
        }
    }

    render() {




        return (



            <FullPageForm
                colour={this.props.backgroundColour}
                title={this.props.leftColumnTitle}
                subTitle={null}
                text={this.props.leftColumnBody}
                formTitle={this.props.rightColumnTitle}
                thanksMessage={this.props.thanksMessage}
                conversionScript={this.props.conversionScript}
                redirectURL={this.props.redirectURL}
                postURL={this.props.submissionPOSTURL}
            >
                <FormField id="firstname" label="First Name">
                    <input id="firstname" className="changed" type="text" placeholder="First Name" required />
                </FormField>
                <FormField id="lastname" label="Last Name">
                    <input id="lastname" className="changed" type="text" placeholder="Last Name" required />
                </FormField>
                <FormField id="email" label="Email">
                    <input id="email" className="changed" type="email" placeholder="Email" required />
                </FormField>
                <FormField id="phonenumber" label="Phone">
                    <input id="phonenumber" className="changed" type="tel" placeholder="XXX-XXX-XXXX" minLength="9" maxLength="20" required />
                </FormField>

                <FormField id="company" label="Company">
                    <input id="company" className="changed" type="text" placeholder="Company" required />
                </FormField>

                <FormField id="comment" label="Comment">
                    <textarea id="comment" className="changed" ></textarea>
                </FormField>

                <input type="hidden" id="leadsourcedetail" name="leadsourcedetail" value="Contact Us" />
                <input type="hidden" name="_autopilot_session_id" />
            </FullPageForm>


        );
    }
}
export default hot(ContactUs);