//TODO: Configure scss bundling http://webpack.github.io/docs/stylesheets.html
//https://github.com/toddmotto/angular-styleguide#modular-architecture
//https://65535th.com/jquery-plugins-and-webpack/
//http://michalzalecki.com/lazy-load-angularjs-with-webpack/
//https://www.jonathan-petitcolas.com/2015/05/15/howto-setup-webpack-on-es6-react-application-with-sass.html

// TODO: Look at webpack-dev-server
// TODO: Look at strip-loader
// TODO: Create local namspaces for scss files http://csswizardry.com/2015/03/more-transparent-ui-code-with-namespaces/
// TODO: Copy assets to dedicated folders, not dump them all in public
// TODO: Reconfigure the setup for webpack2 http://javascriptplayground.com/blog/2016/10/moving-to-webpack-2/

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
      'angular-mocks',

      'jquery',
      'jquery.browser',
      'virtkeys',
      'virtkeys/dist/layouts/FA_IR',
      'virtkeys/dist/layouts/TG',
      'jwysiwyg/jquery.wysiwyg'
    ]
  },
  output: {
    path: './wwwroot/public',
    filename: '[name].bundle.js'
  },
  node: {
    __dirname: true
  },
  module: {
    rules: [
      { test: /.js$/, use: 'ng-annotate-loader' },
      {
        test: /.js$/,
        exclude: /(node_modules|lib)/,
        use: {
          loader: 'babel-loader',
          query: {
            cacheDirectory: true,
            presets: ['es2015']
          }
        }
      },
      { test: /[\/]angular\.js$/, use: 'exports-loader?angular' },
      { test: /[\/]jquery\.js$/, use: 'expose-loader?$!expose?jQuery' },

      { test: /\.woff2?$|\.ttf$|\.eot$|\.svg$/, use: 'url-loader?limit=10000&name=assets/[name].[ext]?[hash]' },
      { test: /\.gif?$|\.png?$|\.jpg?$/, use: 'url-loader?limit=10000&name=assets/[name].[ext]?[hash]' },

      // 'css?modules!resolve-url!sass?includePaths[]=' + path.resolve(__dirname, 'node_modules', 'wwwroot/lib')
      // { test: /\.css$/, use: 'raw' },
      // { test: /\.scss$/, use: ExtractTextPlugin.extract('css!sass') },
      {
        test: /\.scss$/,
        use: ExtractTextPlugin.extract({
          use: ['css-loader', 'sass-loader']
        })
      },
    ]
  },
  resolve: {
    alias: {
      '~': path.resolve('./wwwroot')
    },
    extensions: ['.js'],
    modules: [
      './wwwroot',
      './wwwroot/lib',
    ],
    descriptionFiles: ['package.json', 'bower.json'],
    mainFields: ['module', 'main']
  },
  plugins: [
    new webpack.optimize.CommonsChunkPlugin({
      name: 'vendor',
      fileName: 'vendor.bundle.js'
    }),
    new ExtractTextPlugin({
      filename: 'app.css',
      allChunks: true
    })
  ]
}