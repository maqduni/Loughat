import angular from 'angular';
import defaultMember from 'angular-mocks';
import { AuthServiceMock } from './../common/auth/auth.service.mock';
import { CardServiceMock } from './../common/cards/card.service.mock';
import { LookupServiceMock } from './../common/cards/lookup.service.mock';

export const MockModule = angular
    .module('app.mock', [
        'ngMockE2E'
    ])
    .service('authServiceMock', AuthServiceMock)
    .service('cardServiceMock', CardServiceMock)
    .service('lookupServiceMock', LookupServiceMock)
    .run(($httpBackend, $injector) => {
        'ngInject'

        // TODO: Find more optimal way for instantiating mock services
        $injector.get('authServiceMock');
        $injector.get('cardServiceMock');
        $injector.get('lookupServiceMock');

        // For everything else, don't mock
        $httpBackend.whenGET(/.+/).passThrough();
        $httpBackend.whenPOST(/.+/).passThrough();
        $httpBackend.whenPUT(/.+/).passThrough();
    })
    .name;