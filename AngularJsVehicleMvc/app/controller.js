/// <reference path="c:\users\m\documents\visual studio 2015\Projects\AngularJsVehicleMvc\AngularJsVehicleMvc\scripts/angular.js" />
var app = angular.module("Crud.controllers", []).
controller("MainController", function ($scope, VehicleService) {
    $scope.message = "Administracija";

    VehicleService.GetMakesFromDb().then(function (d) {
        $scope.listMakes = d.data.list;
    })
    $scope.DeleteMake = function (id, index) {

        $scope.listMakes.splice(index, 1);
        VehicleService.DeleteMake(id);
    }

}).
	controller("AddMakeController", function ($scope, VehicleService) {
	    $scope.message = "Add make details";
	    $scope.AddMake = function () {

	        VehicleService.AddMake($scope.make);
	    }

	}).
	controller("EditMakeController", function ($scope, VehicleService, $routeParams) {
	    $scope.message = "Update Make Details";

	    var id = $routeParams.id;
	    VehicleService.GetMakeById(id).then(function (d) {
	        $scope.make = d.data.make;

	    })
	    $scope.UpdateMake = function () {
	        VehicleService.UpdateMake($scope.make);

	    }

	})

controller("MainModelController", function ($scope, VehicleService) {
    $scope.message = "Administracija Model";

    VehicleService.GetModelFromDb().then(function (d) {
        $scope.listModel = d.data.list;
    })
    $scope.DeleteModel = function (id, index) {

        $scope.listModels.splice(index, 1);
        VehicleService.DeleteModel(id);
    }

}).
controller("AddModelController", function ($scope, VehicleService) {
    $scope.message = "Add Model details";
    $scope.AddModel = function () {

        VehicleService.AddModel($scope.model);
    }

}).
    controller("EditModelController", function ($scope, VehicleService, $routeParams) {
        $scope.message = "Update Model Details";

        var id = $routeParams.id;
        VehicleService.GetModelById(id).then(function (d) {
            $scope.model = d.data.model;

        })
        $scope.UpdateModel = function () {
            VehicleService.UpdateModel($scope.model);

        }

    }).
factory("VehicleService", ["$http", function ($http) {

    var fac = {};
    fac.GetMakesFromDb = function () {
        return $http.get("/Make/GetMakes")

    }
  

    fac.GetMakeById = function (id) {
        return $http.get("/Make/GetMakeById", { params: { id: id } })

    }

  
    fac.AddMake = function (make) {

        $http.post("/Make/AddMake", make).success(function (response) {

            alert(response.status);
        })

 }

    fac.UpdateMake = function (make) {
        $http.post("/Make/UpdateMake", make).success(function (response) {
            alert(response.status);

        })

    }


    fac.DeleteMake = function (id) {
        return $http.post("/Make/DeletMake", { id: id }).success(function (response) {
            alert(response.status);

        })

    }

      fac.AddModel = function (model) {

        $http.post("/Model/AddModel", model).success(function (response) {

            alert(response.status);
        })

      }

      fac.UpdateModel = function (model) {
          $http.post("/Model/UpdateModel", model).success(function (response) {
              alert(response.status);

          })

      }

      fac.DeleteModl = function (id) {
          return $http.post("/Model/DeletModel", { id: id }).success(function (response) {
              alert(response.status);

          })

      }

    fac.GetModelsFromDb = function () {
        return $http.get("/Model/GetModels")
    }
    fac.GetMakeById = function (id) {
        return $http.get("/Model/GetModelById", { params: { id: id } })

    }

    return fac;

}])