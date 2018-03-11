var app = angular.module('UserApp', []);

app.factory('userService', function(){
	var user = {
		name: 'Adam',
		age: 20
	};
	
	this.getUser = function(){
		return user;
	};
	
	return this;
});

app.controller('UserController', function(userService, $scope){
	$scope.user = userService.getUser();
	
});