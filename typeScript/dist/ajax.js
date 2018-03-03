"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var index_1 = require("./index");
(function (a) {
    var success = function (res) {
        console.log('success');
        console.log(res);
    };
    var failure = function (res) {
        console.log('failure');
        console.log(res);
    };
    // a.ajax('get', 'https://swapi.co/api/people/1', null, success, failure);
})(index_1.APP);
//IIFE function
//it is gone call by itself 
//ananomes function 
//it is an expression
//to make sure we have scope
//RETURN THE TRUFY OR FALSY VALUE OF THAT CONDITIONAL
//THE TRUE VALUE OF THAT CONDITION
// var y = 10;
// 	Bar();
// 	function Foo (params) {
// 		var y;
// 		console.log(y);
// 		 y = 20;
// 	}
// 	console.log(y);
// 	Foo(); //undefined
// 	//foo(); //undefined foo has not happen yet the value.
//     //housting is for declaration 
// 	var foo = function() {
//         console.log("i am a foo");
// 	} //function expression
//      function Bar(params) { //Bar is available anywhere everywhere
//         console.log("i am a bar");
//        //foo();
//      } //function statement
