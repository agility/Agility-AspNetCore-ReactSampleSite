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
import Partners from './pages/partners.jsx'
import Resources from './pages/resources.jsx'
import RichText from './pages/rich-text.jsx'
import BlogListing from './pages/blog-listing.jsx'



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
                        <Route path="/partners" component={Partners} />
                        <Route path="/resources" component={Resources} />
                        <Route path="/rich-text" component={RichText} />
                        <Route path="/blog-listing" component={BlogListing} />

                        <Route component={NotFound} />
                    </Switch>
                </div>
            </Router>
        <Footer  {...FooterProps} />
    </div>
), document.getElementById('root'))


  