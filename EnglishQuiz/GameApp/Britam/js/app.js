"use strict";var app = angular.module("DialectApp", []);
app.controller("AppCtrl", [
    "$scope", "$http", "PairService",
    function($scope, $http, PairService) {
        $scope.isBusy = true;
        var tempPairs = [];
        $scope.pairs = [];

        $http.get("/api/gameApi/1/")
            .then(function(result) {
                    //success
                    angular.copy(result.data, tempPairs);
                    console.log("The initial data is" + result.data);
                    var shuffledPairs = PairService.getPairs(tempPairs);
                    angular.copy(shuffledPairs, $scope.pairs);
                    console.log("The shuffled data is" + $scope.pairs);
                    initScopeValues($scope);
                },
                function() {
                    // error
                    alert("couldn't load data");

                })
            .then(function () {
                $scope.isBusy = false;
            });
        

	    var initScopeValues = function ($scope) {
	        $scope.title = "Is it British or American?";	        $scope.completed = 0;	        $scope.currentIndex = 0;	        $scope.total = $scope.pairs.length;	        $scope.numCorrect = 0;	        $scope.answered = false;	        $scope.correctlyAnsweredQuestion = false;	        $scope.wronglyAnsweredQuestion = false;	        $scope.rightMessage = "Good Job! That was the right answer.";
	        $scope.wrongMessage = "Sorry, that was the wrong answer.";
	    };

        $scope.goToNextCard = function() {
            $scope.currentIndex++;
            $scope.answered=false;
            $scope.correctlyAnsweredQuestion=false;
            $scope.wronglyAnsweredQuestion=false;
        };
        $scope.gameChoice = function(answerBool, correctAnswer){
            $scope.completed++;
            if (answerBool===correctAnswer)
          {
              $scope.numCorrect++;
              $scope.correctlyAnsweredQuestion=true;
          }
            else{
              $scope.wronglyAnsweredQuestion=true;
          }
            $scope.answered=true;
        };
    }]);    app.filter("indexFilter", function(){
    return function(data, parameter){
        var filtered=[];
        for(var i=0;i<data.length;i++){
            if(i===parameter) {
                filtered.push(data[i]);
            }
        }
        return filtered;
    };

    });    app.factory("PairService", function(){        var randomizeAnswer = function(array) {            angular.forEach(array, function(pair){                pair.correct = Math.random() >= 0.5;            });        };        var shuffle = function(array) {            var copy = [], n = array.length, i;            // While there remain elements to shuffle…            while (n) {                // Pick a remaining element…                i = Math.floor(Math.random() * n--);                // And move it to the new array.                copy.push(array.splice(i, 1)[0]);            }            randomizeAnswer(copy);            return copy;        };        var getPairs = function(pairs){            return shuffle(pairs);        };        return {            getPairs : getPairs
        };    });