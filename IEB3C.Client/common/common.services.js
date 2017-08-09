(function () {
    "use strict";
    angular.module("common.service",
        ["ngResource"]).constant("appSettings",
        { serverPath: "http://localhost:51596/" });
}());