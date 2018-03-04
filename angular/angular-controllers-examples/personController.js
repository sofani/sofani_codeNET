var app = angular.module('PersonApp', []);

app.controller('PersonController', function($scope){
	$scope.person = {
		firstname: 'Jack',
		lastname: 'Johnson'
	};
	
	$scope.edit = false;
});