import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'
import SamplePageCode from './_boilerplate-page.txt'
import SamplePageRoute from './_boilerplate-route.txt'
import SomeComponentRefCode from './_boilerplate-component-ref.txt'
import './help.sass'

class Help extends Component {
  render() {

    return (
      <div id="help-page" className="p-w">        
        <h1>Help</h1>
        <p>This page is a guide for frontend developers on how to create new pages, components, and their styles in this project and collaborate with backend/js/react developers.</p>
        <h2>Table of Contents</h2>
        <ul>
            <li><a href="#Workflow">Workflow</a></li>
            <li><a href="#CreatePage">How to Create a new Page</a></li>
            <li><a href="#UseExistingComponents">How to use Existing Components</a></li>
        </ul>
        <div>
            <h2><a name="Workflow">Workflow</a></h2>
            <hr />
            <ol>
              <li>Frontend developer creates a new static page to the project.</li>
              <li>Frontend developer then adds any existing components they want to reuse to on the page.</li>
              <li>Frontend developer adds a new static component to the page based on a design.</li>
              <li>Each frontend component should have its own .sass file.</li>
              <li>When done, frontend developer commits their code to their branch and submits a pull request into the UAT branch.</li>
              <li>Code reviewer reviews the pull request for code quality and approves it if ok.</li>
              <li>Backend/JS developer then integrates this component with the CMS and updates the static component to accept dynamic properties (i.e. "props").</li>
              <li>Backend developer makes a copy of the server-rendered dynamic properties as JSON, saves it as a file and updates the static page that uses it to utilize the new "props". It's important to note that there may be small changes to HTML and SASS/CSS during this process.</li>
              <li>Backend developer checks their code back into the UAT branch so that the frontend developers get the update as well.</li>
            </ol>
        </div>

        <div>
            <h2><a name="CreatePage">How to Create a new Page</a></h2>
            <hr />
            <p>When implementing static html, you'll need to create a new .jsx file, .sass file and register it as a route within our static React App.</p>
            <ol>
              <li>Create a new static page by navigating to the <b>Website/wwwroot/src/static/pages</b> directory.</li>
              <li>Create a new file and name it <b>xxx.jsx</b> (where 'xxx' is your page name).</li>
              <li>Copy and paste this boilerplate code in the file to get started:
                  <br/>
                  <br/>
                  <pre>
                    {SamplePageCode}
                  </pre>
              </li>
              <li>Update the name of the component "Sample" to a name that represents your new page.</li>
              <li>Register your new page in the Router, by opening the file <b>Website/wwwroot/src/static/index.js</b> and adding the following:
                  <br/>
                  <br/>
                  <pre>
                    {SamplePageRoute}
                  </pre>
              </li>
              <li>Determine which components should have on the page based on the design. Likely there are already some existing components that you can simply add to get started. For example, you may want to remove the "ContentPanel" component or add others.</li>
              <li></li>
              <li>For your new code you need to add, simply add the HTML within the "return" method. Please ensure your new components are seperated by "section" elements.</li>
              <li>For each new "section" element, add a new .sass file to the <b>Website/wwwroot/src/components</b> folder.</li>
              <li>Add an "imports" statement for your new .sass file at the top of the file representing your page. This will register it as a dependancy for webpack and allow for hot module reloading :)
                <br/>
                <br/>
                <pre>
                  import '/.sample.sass'
                </pre>
              </li>
            </ol>
        </div>

        <div>
          <h2><a name="UseExistingComponents">Using Existing Components</a></h2>
          <hr />
          <p>When creating new pages, you'll likely be re-using existing frontend components.</p>
          <p>For components that have already been integrated with the CMS, you'll notice that they will now rely on "props" being passed into them. These components are no longer static and are now dynamic in nature. The content will change depending on the content from the CMS. In order to maintain consistency between the full web application powered by the CMS and this static app, the backend developers will provide a static JSON file representing sample content from the CMS. This means that when referencing existing components in a page, you'll need to pass-in some sample content in order for it to render correctly.</p>
          <p>For the complete list of availble components, please see the <b>Website/wwwroot/src/components</b> folder. Each component ends in an .jsx extension.</p>
          <ol>
            <li>Find the component you want to use from <b>Website/wwwroot/src/components</b>.</li>
            <li>Register a dependancy for the component on your current page
              <br />
              <br />
              <pre>
                import SomeComponent from '../../components/some-component.jsx'
              </pre>
            </li>
            <li>
              Next, if this component requires 'props' to be passed-in to function, you'll need to pass these in by using the conten from the static JSON files in <b>Website/wwwroot/src/static/data</b>
              <br />
              <br />
              <pre>
                import SomeComponentProps from '../data/some-component.json'
              </pre>
            </li>
            <li>Lastly, you add the component to your HTML markup:
              <br/>
              <br/>
              <pre>
                {SomeComponentRefCode}
              </pre>
            </li>
          </ol>
        </div>

      </div>
    );
  }
}

export default hot(Help);