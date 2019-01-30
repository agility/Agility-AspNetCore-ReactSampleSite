
import React from 'react';
import { hot } from 'react-hot-loader/root'
import FeatureBlock from './feature-block.jsx'
import './feature-blocks-w-text.sass'

class FeatureBlocksWithText extends React.Component {
    constructor() {
        super()
    }
    componentDidMount() {

    }

    render() {

        var features = this.props.features.map(function (f) {
            return <FeatureBlock data={f} key={f.key} />;
        })

        return (
            <section>
                <h2 >{this.props.title}</h2>
                <h3>
                    {this.props.sideTitle}
                </h3>
                <div dangerouslySetInnerHTML={{ __html: this.props.sideBody }} />
                <div>
                    {features}
                </div>
            </section>


        );
    }
}
export default hot(FeatureBlocksWithText);

