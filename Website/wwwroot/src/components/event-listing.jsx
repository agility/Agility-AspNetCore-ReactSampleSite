import React from 'react';
import { hot } from 'react-hot-loader/root'
import './event-listing.scss'
import moment from 'moment'

class ComunityEvents extends React.Component {

    render() {

        var currentDate = new Date();
        var currentMonth = currentDate.getMonth() + 1;
        var currentDay = currentDate.getDate();

        const registerLabel = this.props.registerLabel;
        const viewDetailsLabel = this.props.viewDetailsLabel;
        const backLabel = this.props.backLabel;

        const comunityEvents = this.props.items.map(function (item) {
            return <ComunityEventsContent item={item} key={item.key} registerLabel={registerLabel} viewDetailsLabel={viewDetailsLabel} backLabel={backLabel} curMonth={currentMonth} curDay={currentDay} />
        })

        return (

            <section className="p-w event-listing">
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
                <p className="intro">{this.props.subTitle}</p>
                <div className="events-content">
                    <div className="container-my">
                        <div className="row-my">
                            {comunityEvents}
                        </div>
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

        var dateMoment = new moment(this.props.item.date);
        var day = dateMoment.format("DD");
        var month = dateMoment.format("MMM");
        var monthNum = dateMoment.format("MM");
        var dateText = dateMoment.format("MMMM Do YYYY, h:mm a");

        var dayCurrent = this.props.curDay;
        var monthCurrent = this.props.curMonth;
        var itemClass;

        if (monthCurrent < monthNum) {
            itemClass = 'events-item future';
        } else {
            if (dayCurrent <= day) {
                itemClass = 'events-item future';
            } else {
                itemClass = 'events-item passed';
            }
        }


        return (
            <div className="col-md-4">
                <div className={itemClass} onClick={rotateEvents}>
                    <div className="item-front">
                        <div className="image">
                            <img src={this.props.item.thumbnail.url} alt="" />
                            <div className="passed-label"><span>passed</span></div>
                        </div>
                        <div className="front-date"><p><span>{day}</span>{month}</p></div>
                        <div className="inner-content">
                            <h4 className="h4">{this.props.item.title}</h4>
                            <p className="front-content">{this.props.item.subTitle}</p>
                            <div className="adres">
                                <img src="https://static.agilitycms.com/layout/img/location.svg" alt="" /><span>{this.props.item.address}</span>
                            </div>
                            <a href="" className="arrow-button"><span>{this.props.viewDetailsLabel}</span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /></a>
                        </div>
                    </div>
                    <div className="item-back">
                        <div className="title">
                            <div className="title-img">
                                <img src={this.props.item.organizer.image.url} alt="" />
                            </div>
                            <h5 className="h5">{this.props.item.organizer.title}</h5>
                        </div>
                        <div className="inner-content">
                            <div className="date-back">
                                <img src="https://static.agilitycms.com/layout/img/calendar.svg" alt="" /><span>{dateText}</span>
                            </div>
                            <div className="adres">
                                <img src="https://static.agilitycms.com/layout/img/location.svg" alt="" /><span>{this.props.item.address}</span>
                            </div>
                            <p>{this.props.item.description}</p>
                            <a className="btn" href={this.props.item.externalLink.href} target={this.props.item.externalLink.target} title={this.props.item.externalLink.title}>{this.props.registerLabel}</a>
                            <br />
                            <a href="" className="arrow-button"><span>{this.props.backLabel}</span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /></a>

                        </div>
                    </div>
                </div>
            </div>
        );
    }
}