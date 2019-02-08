import React from 'react';
import { hot } from 'react-hot-loader/root'


class ResponsiveImage extends React.Component {

	constructor(props) {
		super(props)
	}

	render() {
		let image = this.props.img;
		if (!image) return null;

		let url = image.url;
		let alt = image.label;

		const sources = this.props.breaks.map(res => {

			let media = "";
			if (res.max) {
				media = "(max-width: " + res.max + "px)";
			} else if (res.min) {
				media = "(max-width: " + res.min + "px)";
			}

			return (
				<source srcSet={url + "?w=" + res.w} media={media} />
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