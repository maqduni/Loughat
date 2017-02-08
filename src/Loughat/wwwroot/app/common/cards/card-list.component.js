export const CardListComponent = {
    templateUrl: './app/common/cards/card-list.component.html',
    // bindings: {
    //     card: '<'
    // },
    controller: class CardListController {
        constructor(cardService) {
            this._cardService = cardService;
        }

        $onInit() {
            this.term = '';
            this.search();
        }

        search() {
            this._cardService.search(this.term).then((data) => {
                // console.log(data);
                // this.cards = [data[2]];
                this.cards = data;
            });
        }
    }
};