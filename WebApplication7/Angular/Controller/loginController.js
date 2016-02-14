'use strict';
app.controller('loginController', ['$scope', '$state', 'authService', function ($scope, $state, authService) {

    $scope.loginData = {
        Email: "",
        Password: ""
    };

    $scope.message = "";

    $scope.login = function () {
        authService.login($scope.loginData).then(function (response) {

            $state.go('home');

        },
         function (err) {
             $scope.message = err.error_description;
         });
    };

}]);