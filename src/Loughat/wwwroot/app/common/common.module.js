import angular from 'angular';
// import { NavModule } from './nav/nav.module';
// import { FooterModule } from './footer/footer.module';
import { AuthService } from './auth/auth.service';
import { LoginComponent } from './auth/login.component';
import { AppConfigService } from './app-config.service';

export const CommonModule = angular
  .module('app.common', [
    // NavModule,
    // FooterModule
  ])
  .service('auth', AuthService)
  .service('appConfig', AppConfigService)
  .component('login', LoginComponent)
  .config(($httpProvider) => {
    // $httpProvider interceptors 
    $httpProvider.interceptors.push((appConfig) =>  {
      'ngInject';

      return {
        'request': (config) => {
          let aconf = appConfig.load();
          if (aconf.authToken) {
            config.headers['Auth-Token'] = aconf.authToken;
          }
          return config;
        },

        // 'response': function (response) {
        //   // same as above
        // }
      };
    });
  })
  .name;