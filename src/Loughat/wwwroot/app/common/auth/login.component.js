export const LoginComponent = {
    templateUrl: './app/common/auth/login.component.html',
    controller: class LoginController {
        constructor(auth) {
            this.auth = auth;
        }

        $onInit() {
            
        }

        login() {
            this.auth.authenticate(this.username, this.password)
            .then((result) => {
                this.statusMessage = 'Logged in successfully';
            }, (error) => {
                this.statusMessage = 'Authentication failed';
            });
        }

        testAuthHeader() {
            
        }
    }
};