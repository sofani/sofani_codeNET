var app = angular.module('Logger', []);


app.controller('LoggingController', function($scope, $log){
	$log.log('Logging has started');
	
	$scope.message = function(name){
		if (name === undefined){
			$log.error('Name is undefined!');
		} else if (name == ''){
			$log.warn('Name is empty');
		} else {
			$log.debug(name);
		}
	};
});