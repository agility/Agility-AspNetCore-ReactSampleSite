import React from 'react';
import { hot } from 'react-hot-loader/root'
import './feature-blocks.sass'

class FeatureBlocks extends React.Component {
    constructor() {
        super()
    }
    componentDidMount() {
        var sliderButtons = document.querySelectorAll('#slider-nav button');
        var sliderButton1 = document.querySelector('#slider-nav button:nth-child(1)');
        var sliderButton2 = document.querySelector('#slider-nav button:nth-child(2)');
        var sliderButton3 = document.querySelector('#slider-nav button:nth-child(3)');
        var slides = document.querySelectorAll('#slider .slide');
        for (var u = 0; u < sliderButtons.length; u++) {
            var button = sliderButtons[u];
            button.addEventListener('click', function(){
                for (var z = 0; z < sliderButtons.length; z++) {
                    sliderButtons[z].classList.remove('current');
                }
                this.classList.add('current');
                var buttonAttr = this.getAttribute('data-slide');
                if (2 == buttonAttr) {
                    for (var x = 0; x < slides.length; x++) {
                        slides[x].classList.remove('my-1');
                        slides[x].classList.add('my-2');
                    }
                } else if (1 == buttonAttr) {
                    for (var x = 0; x < slides.length; x++) {
                        slides[x].classList.remove('my-2');
                        slides[x].classList.add('my-1');
                    }
                } else {
                    for (var x = 0; x < slides.length; x++) {
                        slides[x].classList.remove('my-2');
                        slides[x].classList.remove('my-1');
                    }
                }
            });
        }
        var slider = document.getElementById('slider');
        var clientX;
        var deltaX;
        var b;
        slider.addEventListener('touchstart', function(e){
            clientX = e.touches[0].clientX;
        });
        slider.addEventListener('touchend', function(e) {
            deltaX = e.changedTouches[0].clientX - clientX;
            if (deltaX < 0) {
                for (var z = 0; z < slides.length; z++) {
                    if (slides[z].classList.contains('my-2')) {
                        return false;
                    } else if (slides[z].classList.contains('my-1')) {
                        slides[z].classList.remove('my-1');
                        slides[z].classList.add('my-2');
                        sliderButton2.classList.remove('current');
                        sliderButton3.classList.add('current');
                    } else {
                        slides[z].classList.add('my-1');
                        sliderButton1.classList.remove('current');
                        sliderButton2.classList.add('current');
                    }
                }
            } else {
                for (var z = 0; z < slides.length; z++) {
                    if (slides[z].classList.contains('my-2')) {
                        slides[z].classList.remove('my-2');
                        slides[z].classList.add('my-1');
                        sliderButton3.classList.remove('current');
                        sliderButton2.classList.add('current');
                    } else if (slides[z].classList.contains('my-1')) {
                        slides[z].classList.remove('my-1');
                        sliderButton2.classList.remove('current');
                        sliderButton1.classList.add('current');
                    } else {
                        return false;
                    }
                }
            }
        }, false);
    }
    rawMarkup(propName) {
        const rawMarkup = this.props[propName].toString();
        return { __html: rawMarkup };
    }
    render() {

        var features = this.props.features.map(function (f) {
            return <FeatureBlock data={f} key={f.key} />;
        })

        return (

            <section id="sec-2" className="benefits p-w">
                <div className="canvas" id="canvas-2">
                    <div className="img">
                        <div className="item item-tangle-top-2 twentyone w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentytwo w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentythree w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentyfour w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentyfive w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentysix w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentyseven w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentyeight w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 twentynine w58">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-2 thirty w58 rotate">
                            <img src="https://cdn.agilitycms.com/agility-cms-2019/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>

                <h2 className="title-conponent">Benefits</h2>

                <div className="ben-items container">
                    <div className="ben-items-forslider my-slider" id="slider">
                        {features}
                    </div>
                    <div id="slider-nav">
                        <button data-slide="0" className="current"></button>
                        <button data-slide="1"></button>
                        <button data-slide="2"></button>
                    </div>
                </div>

            </section>
            

        );
    }
}
export default hot(FeatureBlocks);


class FeatureBlock extends React.Component {
    render() {

        return (

            <div className="ben-item slide">
                <div className="img"><img src={this.props.data.icon.url} alt={this.props.data.icon.label} /></div>
                <h3 className="ben-title">{this.props.data.title}</h3>
                <div dangerouslySetInnerHTML={{ __html: this.props.data.textBlob }} />
            </div>
        );
    }
}

