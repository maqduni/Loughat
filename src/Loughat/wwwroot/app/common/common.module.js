import angular from 'angular';
import uiRouter from 'angular-ui-router';
// import { NavModule } from './nav/nav.module';
// import { FooterModule } from './footer/footer.module';
import { AuthService } from './auth/auth.service';
import { LoginComponent } from './auth/login.component';
import { AppConfigService } from './app-config.service';

import { CardsModule } from './../common/cards/cards.module';


export const CommonModule = angular
  .module('app.common', [
    uiRouter,
    CardsModule,
    // FooterModule
  ])
  .service('authService', AuthService)
  .service('appConfigService', AppConfigService)
  .component('login', LoginComponent)
  .config(($stateProvider, $httpProvider) => {
    //TODO: Think of creating a separate file for this block

    // Register routes
    let states = [
      {
        name: 'login',
        url: '/login',
        component: 'login',
      }
    ];

    // Loop over the state definitions and register them
    states.forEach((state) => {
      $stateProvider.state(state);
    });

    // $httpProvider interceptors 
    $httpProvider.interceptors.push((appConfigService) => {
      'ngInject';

      return {
        'request': (config) => {
          appConfigService.load();
          if (appConfigService.authToken) {
            config.headers['Auth-Token'] = appConfigService.authToken;
          }
          return config;
        },
        'responseError': function (response) {
          switch (+response.status) {
            case 401:
              console.log(response);
              break;
            default:
              break;
          }

          return response;
        }
      };
    });
  })
  .name;