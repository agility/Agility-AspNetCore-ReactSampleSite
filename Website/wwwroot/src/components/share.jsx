import React from 'react';
import { hot } from 'react-hot-loader/root'
import './share.scss'
import { FacebookShareButton, FacebookIcon, TwitterShareButton, TwitterIcon, LinkedinShareButton, LinkedinIcon } from 'react-share'

class Share extends React.Component {
	constructor() {
		super()
	}

    componentDidMount() {
        window.addEventListener('scroll', function() {
            let supportPageOffset = window.pageXOffset !== undefined;
            let isCSS1Compat = ((document.compatMode || '') === 'CSS1Compat');
            let scroll = {
               x: supportPageOffset ? window.pageXOffset : isCSS1Compat ? document.documentElement.scrollLeft : document.body.scrollLeft,
               y: supportPageOffset ? window.pageYOffset : isCSS1Compat ? document.documentElement.scrollTop : document.body.scrollTop
            };
        
            if(scroll.y > 1000){ 
                let element = document.getElementsByClassName('share')[0]; // target element to change attribute
                element.classList.add('show');//change the attribute.
            } else {
                let element = document.getElementsByClassName('share')[0]; // target element to change attribute
                element.classList.remove('show');
            }
        }, 300);//ms
    }

	render() {

		return (
            <div className="share">
                <label>{this.props.shareLabel}</label>
                {this.props.facebook &&
                <FacebookShareButton quote={document.title} url={window.location.href}>
                    <FacebookIcon size={36} round />
                </FacebookShareButton>
                }
                {this.props.twitter &&
                <TwitterShareButton quote={document.title}  url={window.location.href}>
                    <TwitterIcon size={36} round />
                </TwitterShareButton>
                }
                {this.props.linkedIn &&
                <LinkedinShareButton quote={document.title}  url={window.location.href}>
                    <LinkedinIcon size={36} round />
                </LinkedinShareButton>
                }
            </div>

        );
	}

}

export default hot(Share);