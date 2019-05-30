app.service('menuService', function ($http) {

    var baseUrl = "/api/Menus/";

    this.addMenu = function (inputModel, responseMessage) {
        $http({
            method: 'POST',
            url: baseUrl + "AddMenu",
            data: inputModel
        }).then(function successCallback(response) {
            responseMessage(response.data);
        }, function errorCallback(response) {
            responseMessage(response.data);
        });
    };


});