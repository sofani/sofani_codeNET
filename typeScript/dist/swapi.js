"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var index_1 = require("./index");
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
