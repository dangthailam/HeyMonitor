
app.config(["$stateProvider", "$urlRouterProvider", "$locationProvider",
    function ($stateProvider, $urlRouterProvider, $locationProvider) {
        $urlRouterProvider.otherwise("/");
        
        var base_url_template = app.root + "AngularTemplate/";
        // Now set up the states
        $stateProvider
          .state('home', {
              url: "/",
              templateUrl: base_url_template + "HomeTemplate"
          })
          .state('register', {
              url: "/register",
              templateUrl: base_url_template + "RegisterTemplate",
              controller: "registerController"
          })
          .state('login', {
              url: "/login",
              templateUrl: base_url_template + "LoginTemplate",
              controller: "loginController"
          });

        //$locationProvider.html5Mode({
        //    enabled: true,
        //    requireBase: true
        //}).hashPrefix("!");

        
    }
]);

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});