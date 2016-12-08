/**
 * jQuery dependencies
 */
import 'jquery';
import 'jquery.browser'
// import './../../../../../VirtualKeyboard/dist/virtkeys';
import 'virtkeys';
import 'virtkeys/dist/layouts/FA_IR';
import 'virtkeys/dist/layouts/TG';
import 'jwysiwyg/jquery.wysiwyg';

/**
 * AngularJs and application dependencies
 */
import angular from 'angular';
import uiRouter from 'angular-ui-router';
// import { visualizer } from "ui-router-visualizer";
import { AppComponent } from './app.component';
import { ComponentsModule } from './components/components.module';
import { CommonModule } from './common/common.module';
import { MockModule } from './mock/mock.module';
import { FiltersModule } from './common/filters/filters.module';

export const AppModule = angular
    .module('app', [
        ComponentsModule,
        CommonModule,
        uiRouter,
        MockModule,
        FiltersModule
    ])
    .component('app', AppComponent)
    .config(($stateProvider, $urlRouterProvider) => {
        'ngInject';
        
        let states = [
            {
                name: 'app',
                url: '/',
                component: 'app', // The component's name
                // resolve: {
                //     fooData: function (FooService, $stateParams) {
                //         return FooService.getFoo($stateParams.fooId)
                //     }
                // }
            },
            // {
            //     name: 'hello',
            //     url: '/hello',
            //     template: '<h3>hello world!</h3>'
            // },
            // {
            //     name: 'about',
            //     url: '/about',
            //     template: '<h3>Its the UI-Router hello world app!</h3>'
            // },
        ];

        // Loop over the state definitions and register them
        states.forEach((state) => {
            $stateProvider.state(state);
        });
        $urlRouterProvider.otherwise('/');
    })
    // .run((ng1UIRouter) => {
    //     // Show ui-router-visualizer
    //     visualizer(ng1UIRouter);
    // })
    .name;