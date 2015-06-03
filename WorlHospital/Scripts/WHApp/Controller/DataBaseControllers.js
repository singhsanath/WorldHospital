/// <reference path="../../angular.js" />
angular.module( "PatientAuth", [] ).controller( "PatientAuthController", function ( $scope, $http ) {

    $scope.regSubmit = function ( regData ) {
        console.log(regData)
        $http.post('Auth/Registration',angular.toJson(regData)).success(function(data,status,headers,config){
            $scope.datain = data;
            console.log(data);
        }).error(function(){
            console.log("Unsuccessfull");
        })
    }

    $scope.loginSubmit = function ( loginData ) {
        console.debug( loginData );
        $http.post( 'Auth/Login', angular.toJson( loginData ) ).success( function ( data, status, header, config ) {


        } )

    }
    

} )