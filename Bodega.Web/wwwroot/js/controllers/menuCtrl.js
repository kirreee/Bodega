app.controller('menuCtrl', ['$scope', 'menuService', function ($scope, menuService) {

    $scope.addMenu = function () {

        let inputModel = {
            'Title': $scope.title,
            'Description': $scope.description,
            'Price': $scope.price
        };

        var validateResponse = $scope.validateInputModel();
        if (!validateResponse) {
            return;
        }

        menuService.addMenu(inputModel, function (responseMessage) {

            alert(responseMessage);

        });

    };


    $scope.validateInputModel = function () {

        let requiredArray = [];
        if (!$scope.title) {
            requiredArray.push(1);
            $scope.isTitleEmpty = true;
        }
        if (!$scope.description) {
            requiredArray.push(1);
            $scope.isDescriptionEmpty = true;
        }
        if (!$scope.price) {
            requiredArray.push(1);
            $scope.isPriceEmpty = true;
        }

        if (requiredArray.length > 0) {
            return false;
        }

        return true;
    };

}]);