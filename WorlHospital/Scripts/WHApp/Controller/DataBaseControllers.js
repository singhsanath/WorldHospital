/// <reference path="../../angular.js" />
angular.module( "PatientAuth", [] ).controller( "PatientAuthController", function ( $scope, $http ) {

    $scope.regSubmit = function ( regData ) {
        $http.post( "Auth/Registration", regData ).success( function ( data, status, header, config ) {
            if ( angular.isDefined( data.PID ) ) {
                $scope.patientRegData = angular.fromJson( data );
                console.log( data );
            }
        } ).error( function () {
            alert( "sorry Data is Not Registered" );
        } )
    }

} )