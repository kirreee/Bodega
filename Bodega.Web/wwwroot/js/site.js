var app = angular.module('app', ['ngRoute']).run(function () {
    console.log('Angular is running!');
});


// App Config
app.config(["$routeProvider",
    function ($routeProvider) {

        // Routing
        $routeProvider.
            when("/home", {
                templateUrl: "/Templates/Home.html",
                controller: "homeCtrl"
            }).
            otherwise({
                redirectTo: "/home",
                controller: "homeCtrl"
            });
    }
]);