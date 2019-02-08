import React from 'react';
import { hot } from 'react-hot-loader/root'


class ResponsiveImage extends React.Component {

	constructor(props) {
		super(props)
	}

	render() {

		let url = this.props.url;
		let alt = this.props.alt;

		const sources = this.props.breaks.map(res => {
			return (
				<source srcSet={url + "?w=" + res.w} media={"(min-width: " + res.m + "px)"} />
			)
		});

		return (
			<picture>
				{sources}
				<img src={url} alt={alt} />
			</picture>
		)
	}

}

export default hot(ResponsiveImage);