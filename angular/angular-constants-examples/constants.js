var app = angular.module('ConstantsApp', []);

app.constant('version', '2.1');
app.constant('minorRelease', 3); //do not use - or _

app.controller('ConstantController', function($scope, version, minorRelease){
	console.log("version: " + version);
	
	//version = 2;
	$scope.info = {
		version: version,
		minorRelease: minorRelease,
	};
});

app.controller('InnerController', function($scope, version){
	console.log("version: " + version);
	$scope.version = version;
});