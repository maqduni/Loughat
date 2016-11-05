export class AuthService {
    constructor(appConfig, $http, $q) {
        this.appConfig = appConfig;
        this.$http = $http;
        this.$q = $q;
    }

    isAuthenticated() {
        return !!this.appConfig.authToken;
    }

    authenticate(username, password) {
        //TODO: Review how apiUrl is being passed on, probably string interpolation is also not the best option, could be a constant

        return this.$q((resolve, reject) => {
            this.$http.post(`/api/account/login`, {
                username: username,
                password: password
            }).then((result) => {
                this.appConfig.authToken = result.data;
                this.appConfig.save();

                resolve(result);
            }, (error) => {
                this.appConfig.authToken = undefined;
                this.appConfig.save();

                reject(error);
            });
        });
    }

    logout() {
        return this.$q((resolve, reject) => {
            this.$http.post(`/api/account/logout`, null).then((result) => {
                this.appConfig.authToken = undefined;
                this.appConfig.save();

                resolve(result.data);
            }, (error) => {
                reject(error);
            });
        });
    }

    test() {
        return this.$q((resolve, reject) => {
            this.$http.post(`/api/account/test`, null).then((result) => {
                console.log(result.data);
                resolve(result.data);
            }, (error) => {
                console.log(error);
                reject(error);
            });
        });
    }
}