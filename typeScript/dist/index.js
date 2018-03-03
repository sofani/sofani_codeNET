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
