import angular from 'angular';

export class AppConfigService {
    constructor() {
        // this.sort = '+date';
        // this.emailAddress = undefined;
        this.authToken = undefined;
        this.apiUrl = 'http://localhost:8080/api';
        this.load();
    }

    load() {
        try {
            return angular.extend(this, angular.fromJson(sessionStorage.getItem('appConfig')))
        } catch (Error) { }

        return this;
    }

    save() {
        sessionStorage.setItem('appConfig', angular.toJson(angular.extend({}, this)));
    }
}