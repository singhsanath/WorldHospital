
/// <reference path="../../angular.js" />
angular.module( 'RegValidation', [] ).directive( 'dValidation', function ($parse) {
    var regex = "/^[a-zA-Z]+$/^";
    return {

        restrict:'A',
        require: 'ngModel',
        template: 'this is testing',
       
        link: function ( scope, element, attrs, ctrl ) {
            console.log( 'before watch' );
            var ngModelGet = $parse(attrs.ngModel);
            element.on( 'focus', function () {

                console.log( "Changed to " + ngModelGet( scope ) );
                scope.$watch( attrs.ngModel, function () {
                    console.log( 'after watch' );
                    console.log( "Changed to " + ngModelGet( scope ) );
                    console.log( ngModelGet( scope ) );

                    if ( !regex.match( ngModelGet( scope ) ) ) {
                        console.log( 'i m in else' );
                        element.css( 'border', 'green 2px solid' );
                    }
                    else {

                        console.log( 'i m in if' );
                        element.css( 'border', 'red 2px solid' );
                    }
                } )
            } );
            element.on( 'blur', function () {
                element.css('border','none')
            } )
}

    }
} )