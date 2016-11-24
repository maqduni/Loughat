import './card.component.scss';

export const CardComponent = {
    templateUrl: './app/common/cards/card.component.html',
    bindings: {
        card: '<'
    },
    controller: class CardController {
        constructor(lookupService) {
            this.lookupService = lookupService;
        }

        $onInit() {

        }
    }
};