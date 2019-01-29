import React, { Component } from 'react'
import { hot } from 'react-hot-loader/root'

import ContentPanel from '../../components/content-panel.jsx'
import ContentPanelProps from '../data/content-panel.json'



import TabPanelsProducts from '../../components/tab-panels-products.jsx'
import TabPanelsPropsProducts from '../data/tab-panels-products.json'

import ProductsStaff from '../../components/products-staff.jsx'
import ProductsStaffProps from '../data/products-staff.json'

import ProductsFeatures from '../../components/products-features.jsx'
import ProductsFeaturesProps from '../data/products-features.json'


class Product extends Component {
  render() {

    return (
      <div id="product-page">        
        <ContentPanel {...ContentPanelProps } />
        <TabPanelsProducts {...TabPanelsPropsProducts} />
        <ProductsStaff {...ProductsStaffProps} />
        <ProductsFeatures {...ProductsFeaturesProps} />
      </div>
    );
  }
}

export default hot(Product);