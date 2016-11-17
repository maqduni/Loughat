export const CardEditComponent = {
    templateUrl: './app/common/cards/card-edit.component.html',
    bindings: {
        card: '<',
        editMode: '<'
    },
    controller: class CardEditComponent {
        constructor(lookupService) {
            this.lookupService = lookupService;
        }

        $onInit() {
            this.cardType = {
                0: 'Letter',
                1: 'Word'
            };

            this.languageAbbreviations = this.lookupService.languageAbbreviations(true);
            this.currentCard = angular.copy(this.card);
        }

        cancel() {
            this.currentCard = angular.copy(this.card);
        }
    }
};