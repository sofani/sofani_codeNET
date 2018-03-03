/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, {
/******/ 				configurable: false,
/******/ 				enumerable: true,
/******/ 				get: getter
/******/ 			});
/******/ 		}
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = 0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var index_1 = __webpack_require__(1);
var finder = document.querySelector('#finder'); //querySelector return it return exactly 1 or nothing 
var pass = function (res, el) {
    if (res) {
        var r = JSON.parse(res);
        var ul = document.createElement('ul');
        for (var i in r.results[0].films) {
            var li = document.createElement('li');
            li.innerHTML = r.results[0].films[i];
            ul.appendChild(li);
        }
        el.appendChild(ul);
    }
};
finder.addEventListener('click', function (event) {
    var searchItem = document.querySelector('#character').value;
    var el = document.querySelector("#movielist");
    event.preventDefault();
    event.stopImmediatePropagation();
    index_1.APP.ajax('get', 'https://swapi.co/api/people/?search=' + searchItem, null, function (rs) {
        pass(rs, el);
    }, function (rs) {
        console.log(rs);
    });
});


/***/ }),
/* 1 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
//CallBacks using Ajax
var APP = (function () {
    //WHEN UPPER CASE YOU CAN USE IT AS IS.
    var ajax = function (verb, url, data, pass, fail) {
        var xhr = new XMLHttpRequest();
        xhr.open(verb, url);
        xhr.onreadystatechange = function () {
            if (xhr.readyState == 4 && xhr.status == 200) {
                pass(xhr.response);
            }
            else if (xhr.readyState == 4) {
                fail(xhr.response);
            }
        };
        xhr.send();
    };
    return {
        ajax: ajax
    };
})();
exports.APP = APP;


/***/ })
/******/ ]);