var app = angular.module('PersonApp', []);

app.controller('PersonController', function($scope){
	$scope.person = {
		firstname: 'Jack',
		lastname: 'Johnson'
	};
	
	$scope.edit = false;
});

app.controller('PasswordController', function($scope){
	$scope.checkPassword = function(password, confirm){
		if (password === undefined || confirm === undefined) return false;

		
		if (password === confirm && password.length >= 8) { return true; }
		else {return false;}
	}
	
	//$scope.edit = false;
});
