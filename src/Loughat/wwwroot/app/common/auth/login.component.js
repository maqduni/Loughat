export const LoginComponent = {
    templateUrl: './app/common/auth/login.component.html',
    controller: class LoginController {
        constructor(authService) {
            this.authService = authService;
        }

        $onInit() {
            
        }

        login() {
            this.authService.authenticate(this.username, this.password)
            .then((result) => {
                this.statusMessage = 'Logged in successfully';
            }, (error) => {
                this.statusMessage = 'Authentication failed';
            });
        }
    }
};