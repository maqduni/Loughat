export class CardService {
    constructor(appConfigService, $http, $q) {
        this.appConfig = appConfigService;
        this.$http = $http;
        this.$q = $q;
    }

    // TODO: Add paging ability
    searchDict(dictId, term) {
        // TODO: Make it compliant with RESTful specification, possibly replace with GET request
        return this.$q((resolve, reject) => {
            this.$http.post(`/api/dicts/${dictId}/cards`, {
                search: term
            }).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    search(term) {
        return this.$q((resolve, reject) => {
            this.$http.get(`/api/search?term=${term}&start=&pageSize=`).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    updateCard(cardId, card) {
        return this.$q((resolve, reject) => {
            this.$http.put(`/api/cards/${cardId}`, card).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    createCard(card) {
        return this.$q((resolve, reject) => {
            this.$http.post(`/api/cards`, card).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }
}