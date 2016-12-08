//TODO: Configure scss bundling http://webpack.github.io/docs/stylesheets.html
//https://github.com/toddmotto/angular-styleguide#modular-architecture
//https://65535th.com/jquery-plugins-and-webpack/
//http://michalzalecki.com/lazy-load-angularjs-with-webpack/
//https://www.jonathan-petitcolas.com/2015/05/15/howto-setup-webpack-on-es6-react-application-with-sass.html

//TODO: Look at webpack-dev-server
//TODO: Look at strip-loader

// TODO: Create local namspaces for scss files
// http://csswizardry.com/2015/03/more-transparent-ui-code-with-namespaces/

// TODO: Copy assets to dedicated folders, not dump them all in public

var webpack = require('webpack'),
  path = require('path'),
  // Plugins
  ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = {
  entry: {
    app: './wwwroot/app/app.module.js',
    vendor: [
      'angular',
      'angular-ui-router',
      'angular-sanitize',
      'angular-mocks'
    ]
  },
  output: {
    path: './wwwroot/public',
    filename: 'bundle.js'
  },
  module: {
    loaders: [
      { test: /.js$/, loader: 'ng-annotate' },
      {
        test: /.js$/,
        exclude: /(node_modules|lib)/,
        loader: 'babel',
        query: {
          cacheDirectory: true, 
          presets: ['es2015']
        }
      },
      { test: /[\/]angular\.js$/, loader: 'exports?angular' },
      { test: /[\/]jquery\.js$/, loader: 'expose?$!expose?jQuery' },
      { test: /\.scss$/, loader: ExtractTextPlugin.extract('css!sass') },
      { test: /\.woff2?$|\.ttf$|\.eot$|\.svg$/, loader: 'file?name=assets/[name].[ext]?[hash]' },
      { test: /\.gif?$|\.png?$|\.jpg?$/, loader: 'file?name=assets/[name].[ext]?[hash]' },
    ]
  },
  resolve: {
    root: path.resolve('./wwwroot'),
    alias: {
        '~': path.resolve('./wwwroot')
    },
    extensions: ['', '.js'],
    modulesDirectories: ['./wwwroot/lib']
  },
  plugins: [
    new webpack.optimize.CommonsChunkPlugin(/* chunkName= */'vendor', /* filename= */'vendor.bundle.js'),
    new webpack.ResolverPlugin(
      new webpack.ResolverPlugin.DirectoryDescriptionFilePlugin('.bower.json', ['main'])
    ),
    new ExtractTextPlugin('app.css', {
      allChunks: true
    })
  ]
}