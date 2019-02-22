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
                            <img src="dist/img/down-gray.svg" alt="" />
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
                            <img src="dist/img/down-gray.svg" alt="" />
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



            //     <section className="p-w form-container" style={styles}>
            //     <div className="row-my">
            //         <div className="col-md-6">
            //             <div className="form-left">
            //                 <h1 className="h1">{this.props.title}</h1>
            //                 <h3 className="h3">{this.props.subTitle}</h3>
            //                 <div className="content" dangerouslySetInnerHTML={{ __html: this.props.text }}></div>
            //             </div>
            //         </div>
            //         <div className="col-md-6">
            //             <div className="form-right" style={stylesForm}>
            //                 <h3 className="form-title">{this.props.formTitle}</h3>
            //                 <form action="">
            //                     <div className="form-item">
            //                         <label htmlFor="first-name">First Name</label>
            //                         <input id="first-name" className="changed" type="text" placeholder="First Name" />
            //                     </div>
            //                     <div className="form-item">
            //                         <label htmlFor="last-name">Last Name</label>
            //                         <input id="last-name" className="changed" type="text" placeholder="Last Name" />
            //                     </div>
            //                     <div className="form-item">
            //                         <label htmlFor="phone-number">Phone Number</label>
            //                         <input id="phone-number" className="changed" type="tel" placeholder="XXX-XXX-XXXX" pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}" />
            //                     </div>
            //                     <div className="form-item">
            //                         <label htmlFor="country">Country</label>
            // <div className="select" id="select">
            //     <button className="d-flex jc-sb ai-center" onClick={showDropdown}>
            //         <span id="select-value">Country</span>
            //         <img src="dist/img/down-gray.svg" alt="" />
            //     </button>
            //     <div className="dropdown-list">
            //         <div className="option"><button onClick={getValue}>USA</button></div>
            //         <div className="option"><button onClick={getValue}>Canada</button></div>
            //     </div>
            // </div>
            //                         <select name="" id="country">
            //                             <option value="USA">USA</option>
            //                             <option value="Canada">Canada</option>
            //                         </select>
            //                     </div>
            //                     <div className="form-item">
            //                         <label>Select</label>
            //                         <div className="inputs d-flex">
            //                             <div className="input-item">
            //                                 <input id="radio-1" type="radio" name="radio" /><label htmlFor="radio-1">Some Title</label>
            //                             </div>
            //                             <div className="input-item">
            //                                 <input id="radio-2" type="radio" name="radio" /><label htmlFor="radio-2">Some Title</label>
            //                             </div>
            //                             <div className="input-item">
            //                                 <input id="radio-3" type="radio" name="radio" /><label htmlFor="radio-3">Some Title</label>
            //                             </div>
            //                         </div>
            //                     </div>
            //                     <div className="form-item">
            //                         <label>Select</label>
            //                         <div className="inputs d-flex checkbox">
            //                             <div className="input-item">
            //                                 <input id="check-1" type="checkbox" onChange={inputCheck} /><label htmlFor="check-1">Some Title</label>
            //                                 <div className="after">
            //                                     <svg width="24" height="24" xmlns="http://www.w3.org/2000/svg">
            //                                         <title>ic/check</title>
            //                                         <desc>Created with Sketch.</desc>

            //                                         <g>
            //                                             <title>background</title>
            //                                             <rect fill="none" id="canvas_background" height="26" width="26" y="-1" x="-1" />
            //                                         </g>
            //                                         <g>
            //                                             <title>Layer 1</title>
            //                                             <g fill-rule="evenodd" fill="none" id="ic/check">
            //                                                 <path fill="#FFCB28" stroke-width="0.6" stroke="#FFCB28" id="Shape" d="m19.873148,5.827038c-0.186239,-0.20175 -0.488216,-0.201922 -0.674456,0l-10.465777,11.051319l-3.905888,-5.056023c-0.186241,-0.201836 -0.488296,-0.201836 -0.674457,0c-0.186241,0.201751 -0.186241,0.528873 0,0.730537l4.243156,5.421375c0.093081,0.10092 0.215175,0.151379 0.337268,0.151379c0.122094,0 0.244108,-0.050459 0.337269,-0.151379l10.802885,-11.416585c0.186321,-0.201751 0.186321,-0.528873 0,-0.730624z" />
            //                                             </g>
            //                                         </g>
            //                                     </svg>
            //                                 </div>
            //                             </div>
            //                             <div className="input-item">
            //                                 <input id="check-2" type="checkbox" onChange={inputCheck} /><label htmlFor="check-2">Some Title</label>
            //                                 <div className="after">
            //                                     <svg width="24" height="24" xmlns="http://www.w3.org/2000/svg">
            //                                         <title>ic/check</title>
            //                                         <desc>Created with Sketch.</desc>

            //                                         <g>
            //                                             <title>background</title>
            //                                             <rect fill="none" id="canvas_background" height="26" width="26" y="-1" x="-1" />
            //                                         </g>
            //                                         <g>
            //                                             <title>Layer 1</title>
            //                                             <g fill-rule="evenodd" fill="none" id="ic/check">
            //                                                 <path fill="#FFCB28" stroke-width="0.6" stroke="#FFCB28" id="Shape" d="m19.873148,5.827038c-0.186239,-0.20175 -0.488216,-0.201922 -0.674456,0l-10.465777,11.051319l-3.905888,-5.056023c-0.186241,-0.201836 -0.488296,-0.201836 -0.674457,0c-0.186241,0.201751 -0.186241,0.528873 0,0.730537l4.243156,5.421375c0.093081,0.10092 0.215175,0.151379 0.337268,0.151379c0.122094,0 0.244108,-0.050459 0.337269,-0.151379l10.802885,-11.416585c0.186321,-0.201751 0.186321,-0.528873 0,-0.730624z" />
            //                                             </g>
            //                                         </g>
            //                                     </svg>
            //                                 </div>
            //                             </div>
            //                         </div>
            //                     </div>
            //                     <div className="form-item">
            //                         <label htmlFor="message">Message</label>
            //                         <textarea name="" id="message" className="changed" placeholder="Message"></textarea>
            //                     </div>
            //                     <div className="form-item submit">
            //                         <button className="btn">Submit</button>
            //                     </div>
            //                 </form>
            //             </div>
            //         </div>
            //     </div>

            // </section>


        );
    }
}
export default hot(RequestADemo);