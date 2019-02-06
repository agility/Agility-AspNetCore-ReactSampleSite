import React from 'react';
import Particles from 'react-particles-js';
import { hot } from 'react-hot-loader/root'
import './animated-bg.sass'

class AnimatedBg extends React.Component {
	constructor() {
		super()
	}

	render() {
		if (document && document.body && document.body.clientWidth <= 768) {
			return null;
		}

		return <Particles
			className="animated-bg"
			canvasClassName="animated-bg-canvas"
			width="300px"
			params={{
				particles: {
					number: {
						value: 31,
						density: {
							enable: true,

						}
					},
					line_linked: {
						enable: false
					},
					move: {
						speed: .3,
						direction: "top",
						out_mode: "bounce",
						random: true,
					},
					shape: {
						type: "images",

						images: [
							{
								src: "/dist/img/1.png",
								height: 20,
								width: 20
							},
							{
								src: "/dist/img/2.png",
								height: 20,
								width: 20
							},
							{
								src: "/dist/img/3.png",
								height: 20,
								width: 20
							},
							{
								src: "/dist/img/4.png",
								height: 20,
								width: 20
							}
						]
					},

					size: {
						value: 20,
						random: true,
						anim: {
							enable: true,
							speed: 4,
							size_min: 15,
							sync: true
						}
					}
				},
				retina_detect: true
			}} />
	}

}

export default hot(AnimatedBg);