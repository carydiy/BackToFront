(function () {
    "use strict";
    angular.module("common.service").factory("userAccount", ["$resource", "appSettings", userAccount])

    function userAccount($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/Account/Register",null,
            { 'registerUser': {method:'POST'}
            });
    }
}());