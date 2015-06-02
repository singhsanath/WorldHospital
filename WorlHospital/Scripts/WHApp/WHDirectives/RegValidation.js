/// <reference path="../../angular.js" />
angular.module( 'RegValidation', [] ).directive( 'dValidation', function () {
    var regex = "[a-zA-Z]";
    return {

        restrict:'A',
        require: 'ngModel',
        template:'this is testing',
        link: function ( scope, element, attrs, ctrl ) {

            var inputs = angular.element.find( 'input' );
            console.log( inputs );
}

    }
} )