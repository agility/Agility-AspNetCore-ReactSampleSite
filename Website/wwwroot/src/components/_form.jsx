import React from 'react';
import { hot } from 'react-hot-loader/root'

class Form extends React.Component {

	constructor(props) {
		super(props)

		this.state = {
			isValidated: false,
			isInvalid: false,
			isSuccess: false,
			isError: false,
			isSubmitting: false
		};

		this.validate = this.validate.bind(this);
		this.submitHandler = this.submitHandler.bind(this);
		this.submit = this.submit.bind(this);
		this.postData = this.postData.bind(this);

		this._renderErrorMessage = this._renderErrorMessage.bind(this);
		this._renderForm = this._renderForm.bind(this);
		this._renderInvalidMessage = this._renderInvalidMessage.bind(this);
		this._renderSuccessMessage = this._renderSuccessMessage.bind(this);

		if (!this.props.beforeSubmit) this.props.beforeSubmit = () => { return true; }

	}


	/**
	 * Them main function that validates the form and fills in the error messages.
	 * @returns bool Returns a boolean showing if the form is valid for submission or not.
	 **/
	validate() {
		//this.formEl is a reference in the component to the form DOM element.
		const formEl = this.formEl;
		const formLength = formEl.length;

		/*
		* The checkValidity() method on a form runs the 
		* html5 form validation of its elements and returns the result as a boolean.
		* It returns 'false' if at least one of the form elements does not qualify,
		* and 'true', if all form elements are filled with valid values.
		*/
		if (formEl.checkValidity() === false) {

			for (let i = 0; i < formLength; i++) {
				//the i-th child of the form corresponds to the forms i-th input element
				const elem = formEl[i];
				/*
				* errorLabel placed next to an element is the container we want to use 
				* for validation error message for that element
				*/
				const errorLabel = elem.parentNode.querySelector(".invalid-feedback");

				/*
				* A form element contains also any buttuns contained in the form.
				* There is no need to validate a button, so, we'll skip that nodes.
				*/
				if (errorLabel && elem.nodeName.toLowerCase() !== "button") {
					/*
					* Each note in html5 form has a validity property. 
					* It contains the validation state of that element.
					* The elem.validity.valid property indicates whether the element qualifies its validation rules or no.
					* If it does not qualify, the elem.validationMessage property will contain the localized validation error message.
					* We will show that message in our error container if the element is invalid, and clear the previous message, if it is valid.
					*/
					if (!elem.validity.valid) {
						errorLabel.textContent = elem.validationMessage;
					} else {
						errorLabel.textContent = "";
					}
				}
			}

			//Return 'false', as the formEl.checkValidity() method said there are some invalid form inputs.
			return false;
		} else {
			//The form is valid, so we clear all the error messages
			for (let i = 0; i < formLength; i++) {
				const elem = formEl[i];
				const errorLabel = elem.parentNode.querySelector(".invalid-feedback");
				if (errorLabel && elem.nodeName.toLowerCase() !== "button") {
					errorLabel.textContent = "";
				}
			}

			//Return 'true', as the form is valid for submission
			return true;
		}
	};

	/**
	* This is the method that is called on form submit.
	* It stops the default form submission process and proceeds with custom validation.
	**/
	submitHandler(event) {

		event.preventDefault();

		//If the call of the validate method was successful, we can proceed with form submission. Otherwise we do nothing.
		if (this.validate()) {

			const form = event.target;
			let data = {};

			//grab all the name/value pairs for the inputs in this form
			[...form.elements].forEach((input) => {
				if (!input.value || input.value == "") return;
				if (!input.name) return;
				data[input.name] = input.value;
			});

			//hit the callback beforeSubmit
			if (this.props.beforeSubmit(data)) {
				//actually do the submission
				this.submit(data);
			}

		} else {
			this.setState({ isSuccess: false, isValidated: true, isInvalid: true, isError: false });

		}

	};

	submit(data) {

		this.setState({ isSubmitting: true });

		this.postData(
			this.props.url,
			data
		).then(response => {

			if (response.status !== 200) {
				this.setState({ isError: true, isSubmitting: false, isSuccess: false, isInvalid: false });
				return;
			}

			this.setState({ isError: false, isSubmitting: false, isSuccess: true, isInvalid: false });

		}).catch(err => {
			this.setState({ isError: true, isSubmitting: false, isSuccess: false, isInvalid: false });
		});

	}

	postData(url = '', data = {}) {
		// Default options are marked with *
		return fetch(url, {
			method: "POST", // *GET, POST, PUT, DELETE, etc.
			mode: "cors", // no-cors, cors, *same-origin
			cache: "no-cache", // *default, no-cache, reload, force-cache, only-if-cached
			credentials: "same-origin", // include, *same-origin, omit
			headers: {
				"Content-Type": "application/json",
				// "Content-Type": "application/x-www-form-urlencoded",
			},
			redirect: "follow", // manual, *follow, error
			referrer: "no-referrer", // no-referrer, *client
			body: JSON.stringify(data), // body data type must match "Content-Type" header
		});
	}

	_renderSuccessMessage() {
		return (
			<div className={"alert alert-success mt-4"} role="alert">
				<div dangerouslySetInnerHTML={{ __html: this.props.thanksMessage }} />
			</div>
		);
	}

	_renderInvalidMessage() {
		return (
			<div className={"alert alert-success mt-4"} role="alert">
				<div dangerouslySetInnerHTML={{ __html: this.props.validationMessage }} />
			</div>
		);
	}

	_renderErrorMessage() {
		return (
			<div className={"alert alert-error mt-4"} role="alert">
				<div dangerouslySetInnerHTML={{ __html: this.props.errorMessage }} />
			</div>
		);
	}

	_renderForm(props) {

		//Add bootstrap's 'was-validated' class to the forms classes to support its styling
		let classNames = [];

		if (props.className) {
			classNames = [props.className];
			delete props.className;
		}

		if (this.state.isValidated) {
			classNames.push("was-validated");
		}

		var invalidMessage = null;
		var errorMessage = null;

		if (this.state.isInvalid) {
			classNames.push("is-invalid");
			invalidMessage = this._renderInvalidMessage();

		}

		if (this.state.isError) {
			errorMessage = this._renderErrorMessage();
		}

		const btnClass = "btn " + this.state.isSubmitting ? "submitting" : "";

		return (
			<form
				// {...props}
				className={classNames.join(" ")}
				noValidate
				ref={form => (this.formEl = form)}
				onSubmit={this.submitHandler}

			>
				{invalidMessage}
				{errorMessage}

				{this.props.children}

				<div>
					<button type="submit" className={btnClass} disabled={this.state.isSubmitting}>Submit</button>
				</div>

			</form >
		);
	}

	/**
	* Render the component as a regular form element with appended children from props.
	**/
	render() {
		const props = [this.props];

		//ensure we have what we need
		if (!this.props.url || this.props.url == "") {
			return (
				<p>Please ensure a submission URL has been specified.</p>
			);
		}



		if (this.state.isSuccess) {
			return this._renderSuccessMessage();
		} else {
			return this._renderForm(props);
		}
	}
}

export default hot(Form);