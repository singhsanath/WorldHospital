/// <reference path="../../angular.js" />
angular.module( 'whHeaderModule', [] ).directive( 'whHeader', function () {
    return {
        restrict: 'E',
        transclude:true,
        templateUrl: 'WHView/Header/HeaderView.html',
        link: function ( scope, element, attrs ) {
            return {

            }
        }
    }
} ).directive( 'whAuthAfter', function () {
    return {
        restrict: 'E',
        templateUrl: 'WHView/Header/WhAuthAfter.html',
        link: function ( scope, element, attrs ) {
            return {

            }
        }
    }
} )