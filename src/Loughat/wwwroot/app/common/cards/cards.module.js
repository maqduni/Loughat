import angular from 'angular';
import uiRouter from 'angular-ui-router';
import defaultMember from 'angular-sanitize';

import { CardComponent } from './card.component';
import { CardEditComponent } from './card-edit.component';
import { CardListComponent } from './card-list.component';
import { CardService } from './card.service';
import { AbbrComponent } from './abbr.component';
import { AbbrEditComponent } from './abbr-edit.component';
import { LookupService } from './lookup.service';

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