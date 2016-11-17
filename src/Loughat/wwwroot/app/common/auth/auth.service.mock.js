import angular from 'angular'

export class AuthServiceMock {
    constructor($httpBackend) {
        'ngInject'

        this.usernames = ['irafiev@mail.ru', 'myself@angular.dev', 'devgal@angular.dev', 'devguy@angular.dev'];
        this.authToken = 'a76adc05-f23e-4309-b7e5-cdf0caef7dde';

        this.configure($httpBackend);
    }

    configure($httpBackend) {
        $httpBackend.whenPOST(`/api/account/login`).respond((method, url, data, headers, params) => {
            var dobj = angular.fromJson(data);
            if (~this.usernames.indexOf(dobj.username.trim()) && dobj.password.trim() === 'P@ssw0rd1') {
                return [200, this.authToken];
            }
            return [401, null, {}, 'Authentication failed'];
        });

        this.authorize($httpBackend.whenPOST(`/api/account/test`), (method, url, data, headers, params) => {
            return [200, 'Auth header and token test passed'];
        });
    }

    authorize(requestHandler, respondWith) {
        requestHandler.respond((method, url, data, headers, params) => {
            return headers['Auth-Token'] === this.authToken ? 
            respondWith(method, url, data, headers, params) : [401, null, {}, 'Unathorized request'];
        });
    }
    // authenticate(username, password) {
    //     //TODO: Review how apiUrl is being passed on, probably string interpolation is also not the best option, could be a constant

    //     return this.$q((resolve, reject) => {
    //         this.$http.post(`api/account/login`, {
    //             username: username,
    //             password: password
    //         }).then((result) => {
    //             this.appConfig.emailAddress = authenticatedUser;
    //             this.appConfig.save();

    //             resolve(result);
    //         }, (error) => {
    //             reject(error);
    //         });
    //     });
    // }

    // logout() {
    //     return this.$q((resolve, reject) => {
    //         this.$http.post(`${this.appConfig.apiUrl}/account/logout`, null).then((result) => {
    //             this.appConfig.emailAddress = undefined;
    //             this.appConfig.save();

    //             resolve(result);
    //         }, (error) => {
    //             reject(error);
    //         });
    //     });
    // }
}