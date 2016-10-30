//TODO: Configure scss bundling
var webpack = require('webpack');
module.exports = {
  entry: {
    app: './wwwroot/app/app.module.js',
    vendor: [
      'angular',
      'angular-ui-router'
    ]
  },
  output: {
    path: './wwwroot/public',
    filename: 'bundle.js'
  },
  module: {
    loaders: [
      { test: /.js$/, loader: 'ng-annotate-loader' },
      {
        test: /.js$/,
        exclude: /(node_modules|lib)/,
        loader: 'babel-loader',
        query: {
          cacheDirectory: true, 
          presets: ['es2015']
        }
      },
      { test: /[\/]angular\.js$/, loader: 'exports-loader?angular' }
    ]
  },
  resolve: {
    extensions: ['', '.js'],
    modulesDirectories: ['./wwwroot/lib']
  },
  plugins: [
    new webpack.optimize.CommonsChunkPlugin(/* chunkName= */'vendor', /* filename= */'vendor.bundle.js'),
    new webpack.ResolverPlugin(
      new webpack.ResolverPlugin.DirectoryDescriptionFilePlugin('.bower.json', ['main'])
    )
  ]
}