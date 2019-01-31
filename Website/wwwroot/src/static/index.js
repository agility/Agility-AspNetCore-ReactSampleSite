//dependancies
import '../_client.js'
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom'

//404
import NotFound from './help/not-found.jsx'

//global elements
import Header from '../components/header.jsx' //the header HTML 
import HeaderProps from './data/header.json' //the header data
import Footer from '../components/footer.jsx' //the footer HTML
import FooterProps from './data/footer.json' //the footer data

//static pages for frontend development
import Home from './pages/home.jsx'
import Product from './pages/product.jsx'
import Community from './pages/community.jsx'



ReactDOM.render((
    <div id="static">
        <Header {...HeaderProps} />
            <Router>
                <div id="inner-page-template">
                    <Switch>
                        {/* Register the static pages below */}
                        <Route path="/" exact component={Home} />
                        <Route path="/home" component={Home} />
                        <Route path="/product" component={Product} />
                        <Route path="/community" component={Community} />

                        <Route component={NotFound} />
                    </Switch>
                </div>
            </Router>
        <Footer  {...FooterProps} />
    </div>
), document.getElementById('root'))


  