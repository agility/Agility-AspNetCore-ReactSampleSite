import React from 'react';
import { hot } from 'react-hot-loader/root'

class FormField extends React.Component {

	constructor(props) {
		super(props)

		this.state = {

		};
	}

	render() {




		return (

			<div className="form-group">
				<label htmlFor={this.props.id} >{this.props.label}</label>
				{this.props.children}

				{/* <input id={this.props.id} className="form-control" required={this.props.required} name={this.props.label} type={type} />
				 */}
				<div className="invalid-feedback"></div>
			</div>
		);
	}
}

export default hot(FormField);