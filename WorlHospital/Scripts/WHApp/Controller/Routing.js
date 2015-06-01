/// <reference path="../../angular.js" />
/// <reference path="../../angular-route.js" />
angular.module( 'WHRoute', ['ngRoute'] ).config( function ( $routeProvider ) {
    $routeProvider.when( '/login', {
        templateUrl: 'Auth/Login'
    } );
    $routeProvider.when( '/register', {
        templateUrl: 'Auth/Registration'
    } );
} )