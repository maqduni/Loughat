import angular from 'angular';
import defaultMember from 'angular-mocks';
import { AuthServiceMock } from './../common/auth/auth.service.mock';

export const MockModule = angular
    .module('app.mock', [
        'ngMockE2E'
    ])
    .service('authMock', AuthServiceMock)
    .run(($httpBackend, $injector) => {
        'ngInject'

        // TODO: Find more optimal way for instantiating mock services
        $injector.get('authMock');

        // For everything else, don't mock
        $httpBackend.whenGET(/.+/).passThrough();
        $httpBackend.whenPOST(/.+/).passThrough();
        $httpBackend.whenPUT(/.+/).passThrough();
    })
    .name;