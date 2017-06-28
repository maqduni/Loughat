export class AuthService {
    constructor(appConfigService, $http, $q) {
        this._appConfigService = appConfigService;
        this._$http = $http;
        this._$q = $q;
    }

    isAuthenticated() {
        return !!this._appConfigService.authToken;
    }

    authenticate(username, password) {
        //TODO: Review how apiUrl is being passed on, probably string interpolation is also not the best option, could be a constant

        return this._$q((resolve, reject) => {
            this._$http.post(`/api/account/login`, {
                username: username,
                password: password
            }).then((result) => {
                this._appConfigService.authToken = result.data;
                this._appConfigService.save();

                resolve(result);
            }, (error) => {
                this._appConfigService.authToken = undefined;
                this._appConfigService.save();

                reject(error);
            });
        });
    }

    logout() {
        return this._$q((resolve, reject) => {
            this._$http.post(`/api/account/logout`, null).then((result) => {
                this._appConfigService.authToken = undefined;
                this._appConfigService.save();

                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    test() {
        return this._$q((resolve, reject) => {
            this._$http.post(`/api/account/test`, null).then((result) => {
                console.log(result.data);
                resolve(result.data);
            }, (error) => {
                console.log(error);
                reject(error);
            });
        });
    }
}