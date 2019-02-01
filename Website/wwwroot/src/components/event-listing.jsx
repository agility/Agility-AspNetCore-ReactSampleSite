import React from 'react';
import { hot } from 'react-hot-loader/root'
import './event-listing.sass'

class ComunityEvents extends React.Component {

    render() {

        const comunityEvents = this.props.items.map(function (item) {
            return <ComunityEventsContent item={item}/>
        })

        return (

            <section className="features p-w comunity-events">
                <div className="canvas" id="canvas-2">
                    <div className="img">
                        <div className="item item-tangle-top-3 twentyone w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentytwo w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentythree w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfour w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyfive w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentysix w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyseven w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentyeight w58">
                            <img src="https://static.agilitycms.com/layout/img/yellow_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 twentynine w58">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                        <div className="item item-tangle-top-3 thirty w58 rotate">
                            <img src="https://static.agilitycms.com/layout/img/green_treangle.svg" alt="" />
                        </div>
                    </div>
                </div>
                <h2 className="title-conponent">{this.props.title}</h2>
                <p className="intro">{this.props.titleBold}</p>
                <div className="events-content">
                    <div className="row-my">
                        {comunityEvents}
                    </div>
                </div>
            </section>


        );
    }
}
export default hot(ComunityEvents);

class ComunityEventsContent extends React.Component {

    render() {

        function rotateEvents(e) {
            e.preventDefault();
            var curElem = e.target;
            var parentElem = curElem.parentElement;
            var parentElem = parentElem.parentElement;
            var parentElem = parentElem.parentElement;
            var parentElem = parentElem.parentElement;
            parentElem.classList.toggle('active');
        }

        var dateText = this.props.item.event.date;
        dateText = dateText.split(' ');
        var day = dateText[0];
        var month = dateText[1];

        var eventContent = this.props.item.event.content;
        eventContent = eventContent.substr(0, 80);
        eventContent = eventContent+'...';

        return (
            <div className="col-md-4">
                <div className="events-item" onClick={rotateEvents}>
                    <div className="item-front">
                        <div className="image">
                            <img src={this.props.item.image.url} alt=""/>
                        </div>
                        <div className="front-date"><p><span>{day}</span>{month}</p></div>
                        <div className="inner-content">
                            <h4>{this.props.item.title}</h4>
                            <p className="front-content">{eventContent}</p>
                            <div className="adres">
                                <img src="/dist/img/location.svg" alt=""/><span>{this.props.item.event.adres}</span>
                            </div>
                            <a href="" className="arrow-button"><span>View Details</span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt=""/></a>
                        </div>
                    </div>
                    <div className="item-back">
                        <div className="title">
                            <div className="title-img">
                                <img src={this.props.item.event.foto.url} alt=""/>
                            </div>
                            <h5>{this.props.item.event.name}</h5>
                        </div>
                        <div className="inner-content">
                            <div className="date-back">
                                <img src="/dist/img/calendar.svg" alt=""/><span>{this.props.item.event.date}</span>
                            </div>
                            <div className="adres">
                                <img src="/dist/img/location.svg" alt=""/><span>{this.props.item.event.adres}</span>
                            </div>
                            <p>{this.props.item.event.content}</p>
                            <a href="" className="arrow-button"><span>Back</span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt=""/></a>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}