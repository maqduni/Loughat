import angular from 'angular';

export class LookupService {
    constructor(appConfigService, $http, $q) {
        this._appConfig = appConfigService;
        this._$http = $http;
        this._$q = $q;
    }

    abbreviations(returnData) {
        let data = [], 
            promise = this._$q((resolve, reject) => {
                this._$http.get(`/api/lookup/abbreviations`, {cache: true}).then((result) => {
                    resolve(result.data);
                    if (returnData) angular.copy(result.data, data);
                }, (error) => {
                    reject(error);
                });
            });
        
        return returnData === true ? data : promise;
    }

    languageAbbreviations(returnData) {
        let data = [], 
            promise = this._$q((resolve, reject) => {
                this._$http.get(`/api/lookup/language-abbreviations`, {cache: true}).then((result) => {
                    resolve(result.data);
                    if (returnData) angular.copy(result.data, data);
                }, (error) => {
                    reject(error);
                });
            });
        
        return returnData === true ? data : promise;
    }

    alphabet(returnData) {
        let data = [], 
            promise = this._$q((resolve, reject) => {
                this._$http.get(`/api/lookup/alphabet`, {cache: true}).then((result) => {
                    resolve(result.data);
                    if (returnData) angular.copy(result.data, data);
                }, (error) => {
                    reject(error);
                });
            });
        
        return returnData === true ? data : promise;
    }
}