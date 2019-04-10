const path = require('path')
const webpack = require('webpack')
const MiniCssExtractPlugin = require('mini-css-extract-plugin')
const devMode = process.env.NODE_ENV !== 'production';
const isStatic = process.env.NODE_ENV === 'static';

module.exports = {
  entry: {
    server: './src/_server.js',
    client: './src/_client.js'
  },
  output: {
    path: path.resolve(__dirname, './dist'),
    publicPath: '/dist/',
    filename: '[name].js'
  },
  module: {
    rules: [{
      test: /\.css$/,
      loader: 'style-loader!css-loader'
    },
    {
      test: /\.scss$/,
      use: [
        devMode ? 'style-loader' : MiniCssExtractPlugin.loader,
        'css-loader',
        'sass-loader'
      ]
    },
    {
      test: /\.jsx?$/,
      loader: 'babel-loader',
      exclude: /node_modules/
    },
    {
      test: /\.(png|jpg|gif|svg)$/,
      loader: 'file-loader',
      options: {
        name: '[name].[ext]?[hash]'
      }
    },
    {
      test: /\.txt$/,
      use: 'raw-loader'
    }
    ]
  },
  resolve: {

  },
  performance: {
    hints: false
  },
  devtool: '#eval-source-map'
}

if (isStatic) {
  module.exports.entry = {
    static: './src/static/index.js'
  }
  module.exports.devServer = {
    historyApiFallback: {
      index: 'index.html'
    }
  }
} else {
  //running with backend
  module.exports.devServer = {
    historyApiFallback: true,
    noInfo: true,
    overlay: true,
    proxy: {
      '*': {
        target: 'https://localhost:5001',
        changeOrigin: true,
        secure: false
      }
    }
  }
}


if (!devMode) {

  module.exports.devtool = '#source-map'
  // http://vue-loader.vuejs.org/en/workflow/production.html
  module.exports.plugins = (module.exports.plugins || []).concat([
    new MiniCssExtractPlugin({
      // Options similar to the same options in webpackOptions.output
      // both options are optional
      filename: "[name].css",
    }),
    new webpack.LoaderOptionsPlugin({
      minimize: true
    })
  ])
} else {
  //dev or other...
  module.exports.plugins = (module.exports.plugins || []).concat([
    new webpack.NamedModulesPlugin()
  ]);
}
