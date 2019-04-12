import React from 'react';
import { hot } from 'react-hot-loader/root'
import FullPageForm from './full-page-form.jsx'
import FormField from './_form-field.jsx'
import Countries from '../static/data/countries.json'

class RequestADemo extends React.Component {
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

        var countryOptions = Countries.map(country => {
            return <div key={country.country} className="option"><button onClick={getCountryValue}>{country.country}</button></div>

        });


        function showDropdown(e) {
            e.preventDefault();
            var select = document.getElementById('select');
            select.classList.toggle('open');
        };

        function showJobTitleDropdown(e) {
            e.preventDefault();
            var select = document.getElementById('select-jobtitle');
            select.classList.toggle('open');
        };

        function getCountryValue(event) {
            event.preventDefault();
            var buttonValue = event.target.innerHTML;
            var select = document.getElementById('select');
            select.classList.toggle('open');
            var selectValue = document.getElementById('select-value');
            selectValue.innerHTML = buttonValue;
            var trueSelect = document.getElementById('country');
            trueSelect.value = buttonValue;
        };

        function getJobTitleValue(event) {
            event.preventDefault();
            var buttonValue = event.target.innerHTML;
            var select = document.getElementById('select-jobtitle');
            select.classList.toggle('open');
            var selectValue = document.getElementById('select-value-jobtitle');
            selectValue.innerHTML = buttonValue;
            var trueSelect = document.getElementById('jobtitle');
            trueSelect.value = buttonValue;
        }

        function inputCheck(a) {
            var inputParent = a.target.parentElement;
            inputParent.classList.toggle('checked');
        }
        console.log(this.props)
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
                submissionCopy={this.props.submissionCopy}
            >
                <FormField id="firstname" label="First Name">
                    <input id="firstname" className="changed" type="text" placeholder="First Name" required />
                </FormField>
                <FormField id="lastname" label="Last Name">
                    <input id="lastname" className="changed" type="text" placeholder="Last Name" required />
                </FormField>
                <FormField id="phonenumber" label="Phone">
                    <input id="phonenumber" className="changed" type="tel" placeholder="XXX-XXX-XXXX" minLength="9" maxLength="20" required />
                </FormField>
                <FormField id="email" label="Email">
                    <input id="email" className="changed" type="email" placeholder="Email" required />
                </FormField>
                <FormField id="company" label="Company">
                    <input id="company" className="changed" type="text" placeholder="Company" required />
                </FormField>
                <FormField id="country" label="Country">

                    <div className="select" id="select">
                        <button className="d-flex jc-sb ai-center" onClick={showDropdown}>
                            <span id="select-value">Country</span>
                            <img src="/dist/img/down-gray.svg" alt="" />
                        </button>
                        <div className="dropdown-list">
                            {countryOptions}
                        </div>
                        <input id="country" required type="hidden" />

                    </div>

                </FormField>
                <FormField id="jobtitle" label="Job Title">

                    <div className="select" id="select-jobtitle">
                        <button className="d-flex jc-sb ai-center" onClick={showJobTitleDropdown}>
                            <span id="select-value-jobtitle">Job Title</span>
                            <img src="/dist/img/down-gray.svg" alt="" />
                        </button>
                        <div className="dropdown-list">
                            <div className="option"><button onClick={getJobTitleValue}>C-Suite</button></div>
                            <div className="option"><button onClick={getJobTitleValue}>Other</button></div>
                            <div className="option"><button onClick={getJobTitleValue}>Marketer</button></div>
                            <div className="option"><button onClick={getJobTitleValue}>Procurement</button></div>
                            <div className="option"><button onClick={getJobTitleValue}>Developer</button></div>
                            <div className="option"><button onClick={getJobTitleValue}>IT</button></div>
                            <div className="option"><button onClick={getJobTitleValue}>Partner</button></div>
                        </div>
                        <input id="jobtitle" required type="hidden" />

                    </div>

                </FormField>
                <input type="hidden" id="leadsourcedetail" name="leadsourcedetail" value="Request for Demo" />
                <input type="hidden" name="_autopilot_session_id" />
            </FullPageForm>

        );
    }
}
export default hot(RequestADemo);