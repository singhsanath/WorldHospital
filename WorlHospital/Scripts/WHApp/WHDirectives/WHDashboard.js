/// <reference path="../../angular.js" />
angular.module( 'WHDashboardModule',[] ).directive( 'whDashboard', function () {
    return {
        restrict: 'E',
        templateUrl: 'WHView/Dashboard/DashBoard.html',
        link: function ( scope, elements, attrs ) {

        }
    }
} )