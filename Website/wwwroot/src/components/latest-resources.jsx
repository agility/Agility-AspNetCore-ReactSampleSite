import React from 'react';
import { hot } from 'react-hot-loader/root'
import './latest-resources.sass'

class LatestResources extends React.Component {

    constructor(props) {
        super(props)

        this.fetchItems = this.fetchItems.bind(this);
        this.labelClick = this.labelClick.bind(this);

        //init state from props
        this.state = {
            items: this.props.items,
            skip: 0,
            take: 0,
            ids: "",
            loadingMore: false,
            noMoreData: false
        };

    }

    componentDidMount() {

    }

    fetchItems(ids) {

        var self = this;

        var url = self.props.fetchUrl + "?ids=" + ids + "&skip=" + (this.state.skip + this.state.take) + "&take=" + this.state.take;

        var timeout = setTimeout(function () {
            self.setState(prevState => ({
                loadingMore: true
            }));
        }, 300);

        fetch(url)
            .then(response => response.json())
            .then(data => {

                clearTimeout(timeout);

                this.setState(prevState => ({
                    items: data.items,
                    loadingMore: false,
                    skip: data.skip,
                    take: data.take,
                    ids: data.ids
                }));

            }).catch(err => {
                clearTimeout(timeout);
                console.warn("An error occurred while loading data...", err);
                this.setState(prevState => ({
                    loadingMore: false
                }));
            });

        return false;
    }

    labelClick(elem) {

        var target = elem.target;

        target.classList.toggle('active');

        var parent = target.parentNode;

        var selectedNodes = parent.getElementsByClassName("active");
        var selectedIDs = [];

        for (var i = 0; i < selectedNodes.length; i++) {
            selectedIDs.push(selectedNodes[i].getAttribute('data-key'));
        }

        let ids = selectedIDs.join(",");

        this.fetchItems(ids);


    }


    render() {

        let resources = this.state.items.map(function (item) {
            return <LatestResContent item={item} key={item.key} />
        });

        var self = this;

        let labels = this.props.types.map(function (t) {
            return (<button key={t.key} data-key={t.key} className="latest-filter" onClick={self.labelClick}>{t.title}</button>);
        });

        return (

            <section className="features p-w latest-resources">

                <h2 className="title-component">{this.props.title}</h2>
                <p className="intro">{this.props.subTitle}</p>
                <div className="latest-wrapper">
                    <div className="row-my">
                        <div className="col-md-4">
                            <div className="latest-left">
                                <h3 className="h3">{this.props.leftTopTitle}</h3>
                                <div className="assets">{labels}</div>
                                <h3 className="h3">{this.props.leftBottomTitle}</h3>
                                <a className="btn" href={this.props.leftButton.href} target={this.props.leftButton.target}>{this.props.leftButton.text}</a>
                            </div>
                        </div>
                        <div className="col-md-8">
                            <div className="row-my">
                                {this.state.loadingMore &&
                                    <div>Loading... </div>
                                }
                                {!this.state.loadingMore &&
                                    resources
                                }
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        );
    }
}
export default hot(LatestResources);

class LatestResContent extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {

        return (
            <div className="col-md-6">
                <div className="latest-item">
                    <div className="image">
                        <img src={this.props.item.image.url} alt="" />
                        <span>{this.props.item.label}</span>
                    </div>
                    <div className="content">
                        <h4 className="h4">{this.props.item.title}</h4>
                        <p>{this.props.item.text}</p>
                        <a href={this.props.item.url}>Read More</a>
                    </div>
                </div>
            </div>
        );
    }
}