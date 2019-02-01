import React from 'react';
import Particles from 'react-particles-js';
import { hot } from 'react-hot-loader/root'
import './animated-bg.sass'

class AnimatedBg extends React.Component {
	constructor() {
		super()
	}

	render() {
		return <Particles
			className="animated-bg"
			canvasClassName="animated-bg-canvas"
			width="300px"
			params={{
				particles: {
					"number": {
						"value": 31,
						"density": {
							"enable": true,
							"value_area": 800
						}
					},
					"line_linked": {
						"enable": false
					},
					"move": {
						"speed": .3,
						"direction": "top",
						"out_mode": "out"
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

					"size": {
						"value": 20,
						"random": false,
						"anim": {
							"enable": true,
							"speed": 4,
							"size_min": 10,
							"sync": false
						}
					}
				},
				"retina_detect": false
			}} />
	}

}

export default hot(AnimatedBg);