import React from 'react';
import Agility from 'agility'
import { hot } from 'react-hot-loader/root'

/*
 * Global Startup or processing scripts that runs on EVERY PAGE of the site
 */
class GlobalScripts extends React.Component {
	constructor() {
		super()

		this.startup = this.startup.bind(this);
	}



	componentDidMount() {

		//don't do anything if we don't have a document
		if (document == undefined || !document) return;

		//if we are ready, run the startup stuff
		if (document.readyState == "complete") {
			this.startup();
		} else {
			document.onreadystatechange = (event => {
				//wait for startup to complete
				if (document.readyState == "complete") {
					this.startup();
				}
			});
		}
	}

	startup() {

		//detect lead source in the query string
		var leadSource = Agility.QueryString("source");

		if (leadSource && leadSource != "") {


			if (localStorage && localStorage.setItem) {
				localStorage.setItem("leadsourcedetail", leadSource);
			}
		} else {
			leadSource = localStorage.getItem("leadsourcedetail");
		}

		//pop the lead source into a field if we find it...
		if (leadSource && leadSource != "") {
			var elem = document.getElementById("leadsourcedetail");
			if (elem) elem.value = leadSource;
		}

	}

	render() {
		return null;
	}
}

export default hot(GlobalScripts);