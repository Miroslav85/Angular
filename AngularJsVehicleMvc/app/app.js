/// <reference path="c:\users\m\documents\visual studio 2015\Projects\AngularJsVehicleMvc\AngularJsVehicleMvc\scripts/angular.js" />
var app = angular.module("CrudDemoApp", ["Crud.controllers", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
	when("/", {
	    templateUrl: "/Views/Make/MakeList.html",
	    controller: "MainController"
	})
	.
	when("/AddMake", {
	    templateUrl: "/Views/Make/AddMake.html",
	    controller: "AddMakeController"
	}).

	when("/EditMake/:id",
	{
	    templateUrl: "/Views/Make/EditMake.html",
	    controller: "EditMakeController"
	}).

        when("/ModelList", {
            templateUrl: "/Views/Model/ModelList.html",
            controller: "MainModelController"
        }).

        when("/EditModel", {
            templateUrl: "/Views/Model/EditModel.html",
            controller: "EditModelController"
        }).
          when("/AddModel", {
              templateUrl: "/Views/Model/AddModel.html",
              controller: "AddModelController"
          })
	otherwise({ redirectTo: "/" });
}]);