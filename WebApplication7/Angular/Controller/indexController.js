'use strict';
app.controller('indexController', ['$scope', '$state', 'authService', function ($scope, $state, authService) {

    $scope.logOut = function () {
        console.log('index logout');
        authService.logOut();
        $state.go('home');
    };

    $scope.authentication = authService.authentication;

}]);