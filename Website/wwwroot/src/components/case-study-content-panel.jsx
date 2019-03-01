import React from 'react';
import { hot } from 'react-hot-loader/root'
import './case-study-content-panel.scss'

class CaseStudyContentPanel extends React.Component {

    render() {

        var bgColor = this.props.bgColor;
        var fgColor = this.props.fgColor;

        return (

            <section className="p-w case-study-content-panel" style={{backgroundColor: bgColor}}>
                
                
                <div className="container-my">
                    <div className="row-my">

                        {this.props.imagePosition === 'left' &&
                        <div className="col-md-6 left d-flex">
                            <div className="start-image">
                                { this.props.image &&  this.props.image != null ? <img src={this.props.image.url + '?w=500&h=500'} alt={this.props.image.label} /> : null }
                            </div>
                        </div>
                        }
                        <div className="col-md-6 ai-center d-flex">
                            <div className="start-content">
                                <div className="sc-inner">
                                    <div className="image">
                                        { this.props.studyImage &&  this.props.studyImage != null ? <img src={this.props.studyImage.url} alt=""/> : null }
                                    </div>
                                    <h1 className="h1" style={{color: fgColor}}>{this.props.title}</h1>
                                    <div style={{color: fgColor}} dangerouslySetInnerHTML={{ __html: this.props.contentPanelCopy }} />
                                </div>
                            </div>
                        </div>


                        {this.props.imagePosition === 'right' &&
                        <div className="col-md-6 right d-flex">
                            <div className="start-image">
                                <div className="image-inner">
                                    { this.props.image &&  this.props.image != null ? <img src={this.props.image.url + '?w=500&h=500'} alt={this.props.image.label} /> : null }
                                </div>
                            </div>
                        </div>
                        }
                    </div>
                </div>
            </section>
        );
    }
}
export default hot(CaseStudyContentPanel);