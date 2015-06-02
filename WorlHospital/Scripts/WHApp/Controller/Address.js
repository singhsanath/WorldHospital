/// <reference path="../../angular.js" />
angular.module( 'AddressModule', [] ).controller( "AddressController", function ( $scope, $http ) {
    $scope.countries = ["India", "USA"];

    $scope.getStates = function ( SCountry ) {
        $http.post( 'Location/states', angular.toJson(SCountry) ).success( function ( data ) {
            //$scope.states = JSON.stringify( data );
            console.log( data );
        } ).error(function(){
            alert("Server busy");
        })
    }




} ).directive( 'getStates', function () {
    return {
        restrict: 'A',
        required: '^ngModel',
        link: function ( scope, A ) {
        }
    }
} )