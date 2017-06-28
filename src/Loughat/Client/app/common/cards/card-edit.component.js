import angular from 'angular';
import { CardType } from './../enums/card-type.enum';
import './card-edit.component.scss';

export const CardEditComponent = {
    templateUrl: './app/common/cards/card-edit.component.html',
    bindings: {
        card: '<',
        editMode: '<'
    },
    controller: class CardEditComponent {
        constructor(lookupService) {
            this._lookupService = lookupService;
        }

        $onInit() {
            this.types = CardType;
            this.languageAbbreviations = this._lookupService.languageAbbreviations(true);
            this.alphabet = this._lookupService.alphabet(true);

            this.current = angular.copy(this.card);
        }

        test() {
            
        }

        cancel() {
            this.current = angular.copy(this.card);
        }
    }
};