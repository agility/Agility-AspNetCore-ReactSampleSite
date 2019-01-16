import React from 'react';
import { hot } from 'react-hot-loader/root'
import { Button, Image } from 'semantic-ui-react'



class Test extends React.Component {
    render() {
        return (
            <div className="panelSlider">
                <h1>Hey Joel?</h1>
                <p>hello world</p>
                <Button content="My Button" primary />
                <Button content="Other Button" secondary />
                <Image src={this.props.panels[0].image.url} size="small" circular/>
            </div>
        );
    }
}
export default hot(Test);

