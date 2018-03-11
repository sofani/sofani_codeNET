var app = angular.module('UserApp', []);

app.factory('userService', ['$log', function($log){
	var user = {
		name: 'Adam',
		age: 20
	};
	
	this.getUser = function(){
		return user;
	};
	
	this.saveUser = function(){
		$log.info("Saving user: " + JSON.stringify(user));
		localStorage.setItem("user-app", JSON.stringify(user));
	};
	
	return this;
}]);

app.controller('UserController', function(userService, $scope){
	$scope.user = userService.getUser();
	console.log("user is: " + $scope.user);
});

app.controller('SaveController', function(userService, $scope){
	$scope.user = userService.getUser();
	$scope.saveUser = userService.saveUser;
});