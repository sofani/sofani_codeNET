var app = angular.module('app',['ngRoute']);
app.config(function($routeProvider){
	$routeProvider
		.when('/',{
			templateUrl: '/partials/home.html'
		})
		.when('/history',{
			templateUrl: '/partials/history.html'
		})
		.otherwise({
		  redirectTo: '/'
		});
});