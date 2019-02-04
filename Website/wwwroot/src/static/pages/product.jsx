import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel.json'



import TabPanels from '../../components/tab-panels.jsx'
import TabPanelsPropsProducts from '../data/tab-panels-products.json'

import TestimonialsListing from '../../components/testimonials-listing.jsx'
import ProductsStaffProps from '../data/testimonials-listing.json'

import ProductsFeatures from '../../components/feature-block-w-text.jsx'
import ProductsFeaturesProps from '../data/feature-block-w-text.json'


class Product extends Component {
    render() {

        return (
            <div id="product-page">
                <ContentPanel {...ContentPanelProps } />
                <TabPanels {...TabPanelsPropsProducts} />
                <TestimonialsListing {...ProductsStaffProps} />
                <ProductsFeatures {...ProductsFeaturesProps} />
            </div>
        );
    }
}

export default hot(Product);