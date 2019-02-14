import React from 'react';
import { hot } from 'react-hot-loader/root'
import './form.scss'

class FormPage extends React.Component {
    constructor() {
        super()
    }

    render() {

        var pageBg = this.props.pageBg;
        var textColor = this.props.textColor;
        var styles = {backgroundColor: pageBg, color: textColor}

        var formBg = this.props.formBg;
        var formColor = this.props.formColor;
        var stylesForm = {backgroundColor: formBg, color: formColor}

        function showDropdown(e) {
            e.preventDefault();
            var select = document.getElementById('select');
            select.classList.toggle('open');
        }

        function getValue(event) {
            event.preventDefault();
            var buttonValue = event.target.innerHTML;
            var select = document.getElementById('select');
            select.classList.toggle('open');
            var selectValue = document.getElementById('select-value');
            selectValue.innerHTML = buttonValue;
            var trueSelect = document.getElementById('country');
            trueSelect.value = buttonValue;
        }

        function inputCheck(a) {
            var inputParent = a.target.parentElement;
            inputParent.classList.toggle('checked');
        }

        return (

            <section className="p-w form-container" style={styles}>
                <div className="canvas" id="canvas-1">
                    <div className="img">
                        <div className="item item-tangle-top one w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top two w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top three w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top four w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top five w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top six w58 rotate">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top seven w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top eight w84 rotate">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top nine w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top ten w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top eleven w58 rotate">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top twelve w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top thirteen w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top fourteen w84 rotate">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top fifteen w58 rotate">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top sixteen w58">
                                <img src="https://static.agilitycms.com/layout/img/orange_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top seventeen w84">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                            <div className="item item-tangle-top eighteen w84 rotate">
                                <img src="https://static.agilitycms.com/layout/img/white_treangle.svg" alt="" />
                            </div>
                    </div>
                </div>
                <div className="row-my">
                    <div className="col-md-6">
                        <div className="form-left">
                            <h1 className="h1">{this.props.title}</h1>
                            <h3 className="h3">{this.props.subTitle}</h3>
                            <div className="content" dangerouslySetInnerHTML={{__html: this.props.text}}></div>
                        </div>
                    </div>
                    <div className="col-md-6">
                        <div className="form-right" style={stylesForm}>
                            <h3 className="form-title">{this.props.formTitle}</h3>
                            <form action="">
                                <div className="form-item">
                                    <label htmlFor="first-name">First Name</label>
                                    <input id="first-name" className="changed" type="text" placeholder="First Name"/>
                                </div>
                                <div className="form-item">
                                    <label htmlFor="last-name">Last Name</label>
                                    <input id="last-name" className="changed" type="text" placeholder="Last Name"/>
                                </div>
                                <div className="form-item">
                                    <label htmlFor="phone-number">Phone Number</label>
                                    <input id="phone-number" className="changed" type="tel" placeholder="XXX-XXX-XXXX" pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}"/>
                                </div>
                                <div className="form-item">
                                    <label htmlFor="country">Country</label>
                                    <div className="select" id="select">
                                        <button className="d-flex jc-sb ai-center" onClick={showDropdown}>
                                            <span id="select-value">Country</span>
                                            <img src="dist/img/down-gray.svg" alt=""/>
                                        </button>
                                        <div className="dropdown-list">
                                            <div className="option"><button onClick={getValue}>USA</button></div>
                                            <div className="option"><button onClick={getValue}>Canada</button></div>
                                        </div>
                                    </div>
                                    <select name="" id="country">
                                        <option value="USA">USA</option>
                                        <option value="Canada">Canada</option>
                                    </select>
                                </div>
                                <div className="form-item">
                                    <label>Select</label>
                                    <div className="inputs d-flex">
                                        <div className="input-item">
                                            <input id="radio-1" type="radio" name="radio"/><label htmlFor="radio-1">Some Title</label>
                                        </div>
                                        <div className="input-item">
                                            <input id="radio-2" type="radio" name="radio"/><label htmlFor="radio-2">Some Title</label>
                                        </div>
                                        <div className="input-item">
                                            <input id="radio-3" type="radio" name="radio"/><label htmlFor="radio-3">Some Title</label>
                                        </div>
                                    </div>
                                </div>
                                <div className="form-item">
                                    <label>Select</label>
                                    <div className="inputs d-flex checkbox">
                                        <div className="input-item">
                                            <input id="check-1" type="checkbox" onChange={inputCheck}/><label htmlFor="check-1">Some Title</label>
                                            <div className="after">
                                                <svg width="24" height="24" xmlns="http://www.w3.org/2000/svg">
                                                    <title>ic/check</title>
                                                    <desc>Created with Sketch.</desc>

                                                    <g>
                                                        <title>background</title>
                                                        <rect fill="none" id="canvas_background" height="26" width="26" y="-1" x="-1"/>
                                                    </g>
                                                    <g>
                                                        <title>Layer 1</title>
                                                        <g fill-rule="evenodd" fill="none" id="ic/check">
                                                            <path fill="#FFCB28" stroke-width="0.6" stroke="#FFCB28" id="Shape" d="m19.873148,5.827038c-0.186239,-0.20175 -0.488216,-0.201922 -0.674456,0l-10.465777,11.051319l-3.905888,-5.056023c-0.186241,-0.201836 -0.488296,-0.201836 -0.674457,0c-0.186241,0.201751 -0.186241,0.528873 0,0.730537l4.243156,5.421375c0.093081,0.10092 0.215175,0.151379 0.337268,0.151379c0.122094,0 0.244108,-0.050459 0.337269,-0.151379l10.802885,-11.416585c0.186321,-0.201751 0.186321,-0.528873 0,-0.730624z"/>
                                                        </g>
                                                    </g>
                                                </svg>
                                            </div>
                                        </div>
                                        <div className="input-item">
                                            <input id="check-2" type="checkbox" onChange={inputCheck}/><label htmlFor="check-2">Some Title</label>
                                            <div className="after">
                                                <svg width="24" height="24" xmlns="http://www.w3.org/2000/svg">
                                                    <title>ic/check</title>
                                                    <desc>Created with Sketch.</desc>

                                                    <g>
                                                        <title>background</title>
                                                        <rect fill="none" id="canvas_background" height="26" width="26" y="-1" x="-1"/>
                                                    </g>
                                                    <g>
                                                        <title>Layer 1</title>
                                                        <g fill-rule="evenodd" fill="none" id="ic/check">
                                                            <path fill="#FFCB28" stroke-width="0.6" stroke="#FFCB28" id="Shape" d="m19.873148,5.827038c-0.186239,-0.20175 -0.488216,-0.201922 -0.674456,0l-10.465777,11.051319l-3.905888,-5.056023c-0.186241,-0.201836 -0.488296,-0.201836 -0.674457,0c-0.186241,0.201751 -0.186241,0.528873 0,0.730537l4.243156,5.421375c0.093081,0.10092 0.215175,0.151379 0.337268,0.151379c0.122094,0 0.244108,-0.050459 0.337269,-0.151379l10.802885,-11.416585c0.186321,-0.201751 0.186321,-0.528873 0,-0.730624z"/>
                                                        </g>
                                                    </g>
                                                </svg>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div className="form-item">
                                    <label htmlFor="message">Message</label>
                                    <textarea name="" id="message" className="changed" placeholder="Message"></textarea>
                                </div>
                                <div className="form-item submit">
                                    <button className="btn">Submit</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>

            </section>


        );
    }
}
export default hot(FormPage);