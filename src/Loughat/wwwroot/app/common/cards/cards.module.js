import angular from 'angular';
import uiRouter from 'angular-ui-router';
import 'angular-sanitize';

import { CardComponent } from './card.component';
import { CardEditComponent } from './card-edit.component';
import { CardListComponent } from './card-list.component';
import { CardService } from './card.service';
import { AbbrComponent } from './abbr.component';
import { AbbrEditComponent } from './abbr-edit.component';
import { LookupService } from './lookup.service';

import { VirtkeysDirective } from './virtkeys.directive';

export const CardsModule = angular
    .module('app.cards', [
        uiRouter,
        'ngSanitize'
    ])
    .component('card', CardComponent)
    .component('cardEdit', CardEditComponent)
    .component('cardList', CardListComponent)
    .component('abbr', AbbrComponent)
    .component('abbrEdit', AbbrEditComponent)
    .service('cardService', CardService)
    .service('lookupService', LookupService)
    
    // Read this post. http://stackoverflow.com/questions/28620479/using-es6-classes-as-angular-1-x-directives
    //http://www.michaelbromley.co.uk/blog/350/exploring-es6-classes-in-angularjs-1-x#_section-factories
    .directive('virtkeys', () => new VirtkeysDirective())
    .config(($stateProvider) => {
        'ngInject';

        let states = [
            {
                name: 'cards',
                url: '/cards',
                component: 'cardList'
            }
        ];

        // Loop over the state definitions and register them
        states.forEach((state) => {
            $stateProvider.state(state);
        });
    })
    .name;