var app = angular.module('ScopeInheritance', []);

app.controller('InheritanceController', function($scope){
	$scope.arr = [1,2,3];
	
	$scope.arr2 = [4,5,6];
});