export class CardService {
    constructor(appConfigService, $http, $q) {
        this._appConfig = appConfigService;
        this._$http = $http;
        this._$q = $q;
    }

    // TODO: Add paging ability
    searchDict(dictId, term) {
        // TODO: Make it compliant with RESTful specification, possibly replace with GET request
        return this._$q((resolve, reject) => {
            this._$http.post(`/api/dicts/${dictId}/cards`, {
                search: term
            }).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    search(term) {
        return this._$q((resolve, reject) => {
            this._$http.get(`/api/search?term=${term}&start=&pageSize=`).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    updateCard(cardId, card) {
        return this._$q((resolve, reject) => {
            this._$http.put(`/api/cards/${cardId}`, card).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    createCard(card) {
        return this._$q((resolve, reject) => {
            this._$http.post(`/api/cards`, card).then((result) => {
                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }
}