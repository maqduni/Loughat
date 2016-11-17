export class LookupService {
    constructor(appConfigService, $http, $q) {
        this.appConfig = appConfigService;
        this.$http = $http;
        this.$q = $q;
    }

    abbreviations(returnData) {
        let data = [], 
            promise = this.$q((resolve, reject) => {
                this.$http.get(`/api/lookup/abbreviations`, {cache: true}).then((result) => {
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
            promise = this.$q((resolve, reject) => {
                this.$http.get(`/api/lookup/language-abbreviations`, {cache: true}).then((result) => {
                    resolve(result.data);
                    if (returnData) angular.copy(result.data, data);
                }, (error) => {
                    reject(error);
                });
            });
        
        return returnData === true ? data : promise;
    }
}