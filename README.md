# Agility React Isomorphic Web App 
This is the source code for the new **Agility** website. It is a work in progress. It demonstrates how you can use .NET Core, [Agility](https://agilitycms.com), and [ReactJS.NET](https://reactjs.net) to create an isomorphic web app that is high performant, SEO friendly, supports modern frontend tooling - along with a static web app option, easy to manage content, and showcases content architecture best-practices.

## Getting Started
There are two way to run this project. You can either run this as an isomorphic application with the .NET Core website and the Webpack Dev Server or you can run a static instance of the site through the Webpack Dev Server only. 

If you are a full stack developer who is comfortable working in .NET and React, then we recommend running the full isomporphic web application as that integrates with Agility and is how the full application will function. You will need the Agility *websiteName* and *securityKey* in order to run the application locally.

If you are primarily a frontend developer and prefer to seperate concerns, then you can run a static version of the site which has no dependancy on Agility or .NET. Instead, you can build out your own static pages using React components and .sass styles and then pass that off to a .NET developer who will integrte your React component with a .NET ViewComponent and supply dynamic props to your component.

-----

## Isomorphic Web App - Full Stack
Running this site as an isomorphic web app means you'll be running a .NET Core website alongside a webpack dev server. Requests to the webpack dev server will be proxied through to your .NET Core website, serving dynamic content from the CMS.

### Start
1.  Run Locally
    - Clone the repo
    - Copy the **Website/appsettings.json.sample** and rename it to **appsettings.json**
    - Enter the *websiteName*, *securityKey*, *UGC Key** and *UGC Password* in the **appsettings.json** file
    - Copy the **Website/appsettings.Development.json.sample** and rename it to **appsettings.Development.json**
    - Verify the paths set for  *contentCacheFilePath* and *logFilePath* resolve to valid locations on your drive

2.  Software dependencies
    - Compatible with Windows, Linux and Mac OS
    - Ensure at least .NET core 2.2 runtime is installed


3.  Start .NET Core site
    ```
    Website> dotnet run
    ```

4.  Start Webpack Dev Server to use things like hot module replacement
    ```
    Website\wwwroot> npm install
    Website\wwwroot> npm run dev
    ```


### Build
1.  Build Frontend - also builds the server.js file used for Server-Side-Rendering
    ```
    Website\wwwroot> npm run build
    ```

2.  Build .NET Core site
    ```
    Website> dotnet build
    ```
---

## Static Web App - Frontend Only
Running the web app like this means that all requests will be processed by the Webpack Dev Server. There is no dependancy on the .NET Core website or Agility. You also don't need to know the Agility *websiteName* or *securityKey*. This makes it ideal to work with external frontend developers and minimize the time it takes to take their work and integrate it into the project. It also lowers the barrier of entry to contribute to your website.

The goal of this is to have the static site use the exact same styles and react components as the isomorphic app, thus increasing speed of development and increasing collaboration across teams. Generally speaking, an Agility module will correspond directly to a React component.

That being said, you do need to maintain static pages (made up of React Components that mimic your .NET Core Website). It will be impossible to keep this in sync, but is valuable for frontend developers to quickly prototype and build new templates with mixes of different components and even re-arrange orders of components on the page so they can mimic a content editor's action of re-ordering modules.

### Start

```
Website\wwwroot> npm install
Website\wwwroot> npm run static
```

### Development Workflow
1. Frontend developer creates a new static page to the project.
2. Frontend developer then adds any existing components they want to reuse to on the page.
3. Frontend developer adds a new static component to the page based on a design.
4. Each frontend component should have its own .sass file.
5. When done, frontend developer commits their code to their branch and submits a pull request into the UAT branch.
6. Code reviewer reviews the pull request for code quality and approves it if ok.
7. Backend/JS developer then integrates this component with the CMS and updates the static component to accept dynamic properties (i.e. "props").
8. Backend developer makes a copy of the server-rendered dynamic properties as JSON, saves it as a file and updates the static page that uses it to utilize the new "props". It's important to note that there may be small changes to HTML and SASS/CSS during this process.
9. Backend developer checks their code back into the UAT branch so that the frontend developers get the update as well.

### Creating a new Static Page
When implementing static html, you'll need to create a new .jsx file, .sass file and register it as a route within our static React App.
1. Create a new static page by navigating to the **Website/wwwroot/src/static/pages** directory.
2. Create a new file and name it **sample.jsx** (where 'sample' is your page name).
3. Copy and paste this boilerplate code in the file to get started:
``` javascript
import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'
import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel.json'

class Sample extends Component {
  render() {
    return (
      <div id="product-page">        
        <ContentPanel {...ContentPanelProps } />
        <section className="sample-page p-w">
          My new HTML goes here!
        </section>
      </div>
    );
  }
}
export default hot(Sample);
```
4. Update the name of the component "Sample" to a name that represents your new page. You need to do this in the "class" declaration and the "export" statement.
5. Register your new page in the Router, by opening the file **Website/wwwroot/src/static/index.js** and adding the following:
``` javascript
import Sample from './pages/sample.jsx'
...
<Route path="/sample" component={Sample} />
```
6. Determine which components you should have on the page based on the design. Likely there are already some existing components that you can simply add to get started. For example, you may want to remove the "ContentPanel" component and/or add others.
7. For your new code you need to add, simply add the HTML within the "return" method of the React component. Where possible, it is best to encapsulate this in a new React component. However, if your React skills aren't quite there yet you can just add it directly within the markup. Best practice would be to wrap it in a *section* html tag.
8. For each new React component, or *section* element, add a new .sass file to the **Website/wwwroot/src/components** folder.
9. Add an **imports** statement for your new .sass file at the top of your new component file or in the top of the file representing your page if you are just doing this inline as a **section**. This will register it as a dependancy for webpack, include it in your bundles and allow for hot module reloading :)
``` javascript
import '/.sample.sass'
```

### Using Existing Components
When creating new pages, you'll likely be re-using existing frontend components.

For components that have already been integrated with the CMS, you'll notice that they will now rely on *props* being passed into them. These components are no longer static and are now dynamic in nature. The content will change depending on the content from the CMS. In order to maintain consistency between the full web application powered by the CMS and this static web app, the backend developers should provide a static JSON file representing sample content from the CMS. This means that when referencing existing components in a page, you'll need to pass-in some sample content in order for it to render correctly.

For the complete list of availble components, please see the **Website/wwwroot/src/components** folder. Each component ends in an .jsx extension.

1. Find the component you want to use from **Website/wwwroot/src/components**.
2. Register a dependancy for the component on your current page:
``` javascript
import SomeComponent from '../../components/some-component.jsx'
```
3. Next, if this component requires *props* to be passed-in to function, you'll need to pass these in by using the content from the static JSON files in **Website/wwwroot/src/static/data**.
``` javascript
import SomeComponentProps from '../data/some-component.json'
```
4. Lastly, you add the component to your HTML markup:
``` javascript
import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'
import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel.json'
import SomeComponentProps from '../data/some-component.json'
import SomeComponent from '../../components/some-component.jsx'

class Sample extends Component {
  render() {
    return (
      <div id="product-page">        
        <ContentPanel {...ContentPanelProps } />
        <section className="sample-page p-w">
          My new HTML goes here!
        </section>
        {/* another existing component below */}
        <SomeComponent {...SomeComponentProps} /> 
      </div>
    );
  }
}
export default hot(Sample);
```
---

## How JS Bundling Works
Webpack is used as the module bundler. Since this supports Server-Side-Rendering (SSR), the server must be able to render react components. In order to handle seperate dependancies for the server/client, there are 2 entry points, client and server. Where the server entry point is for the dependancies for SSR, the client entry point is for dependancies on react components that will be handled on the client-side in the browser.
``` javascript
module.exports = {
  entry: {
      server: './src/_server.js',
      client: './src/_client.js'       
  },
  output: {
    path: path.resolve(__dirname, './dist'),
    publicPath: '/dist/',
    filename: '[name].js'
  }
  ...
}
```

## How CSS Bundling Works
This project is using the css and sass loader. When webpack sees dependancies on css/sass files within the react components, the styles will be bundled into the /dist/client.css file bundle.
``` javascript
import style from './styles.sass';
class HeadingH2 extends React.Component {
    render() {
        return (
            <div className="container">
                <h2 className="some-class-from-styles}">{this.props.title}</h2>
            </div>
        );
    }
}
export default HeadingH2;
```

## How to: Add a new Module with a ViewComponent using .NET Core and React
1. Create a module just like you normally would, and set the Output Template to a ViewComponent.
2. Update your C# Agility API classes by refreshing your C# models by clicking the **Download API** button from the Content Manager.
3. Write your ViewComponent code, returning a ReactActionResult to the name of your corresponding React component (which will be created in the next steps).

``` csharp
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions; 
namespace Website.ViewComponents.Modules
{
	public class ContentPanel : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_ContentPanel module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var panel = module.Panel.GetByID(module.PanelID).ToFrontendProps();
				return new ReactViewComponentResult("Components.ContentPanel", panel);
			});
		}
	}
}
```
4. Build and run the .NET site
```
Website> dotnet run
```
5. In the **Website/wwwroot/src/components** folder add a new *.jsx/js* file and a .sass/css for your component
``` javascript
import React from 'react';
import { hot } from 'react-hot-loader/root'
import './content-panel.sass'
class ContentPanel extends React.Component {
    render() {
        return (
            <section id="sec-1" className="front-start p-w">
                <div className="start-content">
                    <h1>{this.props.title}</h1>
                    <div dangerouslySetInnerHTML={{ __html: this.props.textBlob }} />
                    <div className="start-buttons">
                        <button href={this.props.primaryButton.href} target={this.props.primaryButton.target} className="btn">{this.props.primaryButton.text}</button>
                        <a href={this.props.secondaryButton.href} target={this.props.secondaryButton.target} className="btn-link">{this.props.secondaryButton.text} <span><img src="https://static.agilitycms.com/layout/img/ico/gray.svg" alt="" /></span></a>
                    </div>
                </div>
                <div className="start-image">
                    <img src="https://static.agilitycms.com/layout/img/content/img1.png" alt="" />
                </div>
            </section>
        );
    }
}
export default hot(ContentPanel);
```
6. You need to tell webpack about the dependancy on your React component so that your SSR is aware of it. Do this by opening to the *shared.js* file in the **Website/wwwroot/src/** directory and add an import statement and add the object to the global JS variable *Components*. This *Components* variable is accessed by the ReactJS.NET js engine to grab a hold of the component it needs to render.
``` javascript
import ContentPanel from './components/content-panel.jsx'
...
global['Components'] = {
  FeatureBlocks,
  ContentPanel, //our new module
  TabPanels,
  LogoCloud,
  LogoListing,
  PostDetails,
  PostListing,
  SectionHeading,
  Header,
  Footer
}
```
7. Build the frontend so that the server.js bundle it updated with the new dependancy.
``` 
Website/wwwroot> npm run build
```

## How to: Add a new Module without ANY updates to the .NET Core Site
This site is equipped with a ReactViewComponent that will simply pass any Module's properties as a *props* to a React component of the same name as the module. This allows for frontend developers to easily add new modules in Agility and write the corresponding React component without modifying anything within the .NET Core website. This is recommended for simple modules that do not interact with linked content.

1. Create a new *Module Definition* in the Agility Content Manager
2. Add your fields in the Form Builder tab as usual.
3. In the *Output Template*, for ViewCompoent enter '*React*'.
4. Save the definition.
5. Register a new dependancy for your isomorphic app by adding your import statement in the *shared.js* file and add it to the global JS variable *Components*.
6. Build the frontend so that the server.js bundle it updated with the new dependancy.
``` 
Website/wwwroot> npm run build
```

## Helpful Extensions
**ToFrontendProps** (C#): Will remove Agility specific properties from an object that do not need to be passed to the client. This is done for performance and efficiency.
``` csharp
    viewModel.GlobalHeader = header.ToFrontendProps(); //Removes things like 'CreatedDate', 'ModifiedDate' etc...
```


## Contribution - Rules of Engagement
The following instructions are only applicable to developers contributing to this source code in the private Azure DevOps repo.
1. Under no circumstances can any PID, passwords, or access tokens be checked into source control.
2. Create your own feature branch for any changes, and publish the branch.
3. Commit your changes to your remote branch as you go so you don't lose anything.
4. When you are done and ready to merge, create a *Pull Request* to merge into the **uat** branch.
5. Your pull request will be reviewed and approved only if it meets the appropriate criteria.
5. A successful commit/merge to the **uat** branch will kick off an automated deployment to the *uat environment*

---
**Note**: This repository has a one-way sync between a private Azure DevOps git repository and a public [Agility-AspNetCore-ReactSampleSite GitHub repo](https://github.com/agility/Agility-AspNetCore-ReactSampleSite)