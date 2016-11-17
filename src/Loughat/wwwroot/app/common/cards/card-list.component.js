export const CardListComponent = {
    templateUrl: './app/common/cards/card-list.component.html',
    // bindings: {
    //     card: '<'
    // },
    controller: class CardListController {
        constructor(cardService) {
            this.cardService = cardService;
        }

        $onInit() {
            this.term = '';
            this.search();
        }

        search() {
            this.cardService.search(this.term).then((data) => {
                // console.log(data);
                this.cards = data;
            });
        }
    }
};