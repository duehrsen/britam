'use strict';

var app = angular.module('DialectApp', []);

    app.controller('AppCtrl', ['$scope', 'PairService',
	function($scope, PairService){

        $scope.title="Is it British or American?";
        $scope.pairs = PairService.getPairs();
        $scope.completed = 0;
        $scope.currentIndex = 0;
        $scope.total= $scope.pairs.length;
        $scope.numCorrect = 0;
        $scope.goToNextCard = function() {
            $scope.currentIndex++;
            $scope.answered=false;
            $scope.correctlyAnsweredQuestion=false;
            $scope.wronglyAnsweredQuestion=false;
        };
        $scope.answered= false;
        $scope.correctlyAnsweredQuestion=false;
        $scope.wronglyAnsweredQuestion=false;
        $scope.rightMessage="Good Job! That was the right answer.";
        $scope.wrongMessage="Sorry, that was the wrong answer.";

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
    }]);

    app.filter('indexFilter', function(){
    return function(data, parameter){
        var filtered=[];
        for(var i=0;i<data.length;i++){
            if(i==parameter) {
                filtered.push(data[i]);
            }
        }
        return filtered;
    };

    });

    app.factory('PairService', ['$http', function($http){
        var pairs = [
            {
                "id": 1,
                "british": "trolley",
                "american": "cart",
                "imageurl": "img/cart.jpg",
                "correct": ""
            },
            {
                "id": 2,
                "british": "public toilet",
                "american": "restroom",
                "imageurl": "img/restroom.jpg",
                "correct": ""
            },
            {
                "id": 3,
                "british": "underground",
                "american": "subway",
                "imageurl": "img/subway.jpg",
                "correct": ""
            },
            {
                "id": 4,
                "british": "bonnet",
                "american": "hood",
                "imageurl": "img/hood.jpg",
                "correct": ""
            },
            {
                "id": 5,
                "british": "chemist",
                "american": "pharmacist",
                "imageurl": "img/pharmacist.jpg",
                "correct": ""
            },
            {
                "id": 6,
                "british": "city centre",
                "american": "downtown",
                "imageurl": "img/downtown.jpg",
                "correct": ""
            },
            {
                "id": 7,
                "british": "lift",
                "american": "elevator",
                "imageurl": "img/elevator.jpg",
                "correct": ""
            },
            {
                "id": 8,
                "british": "car park",
                "american": "parking lot",
                "imageurl": "img/parkinglot.jpg",
                "correct": ""
            },
            {
                "id": 9,
                "british": "petrol station",
                "american": "gas station",
                "imageurl": "img/gasstation.jpg",
                "correct": ""
            },
            {
                "id": 10,
                "british": "windscreen",
                "american": "windshield",
                "imageurl": "img/windshield.jpg",
                "correct": ""
            },
			{
				"id": 11,
				"british": "trousers",
				"american": "pants",
				"imageurl": "img/pants.jpg",
                "correct": ""
			}
        ];
        var randomizeAnswer = function(array) {

            angular.forEach(array, function(pair){
                pair.correct = Math.random() >= 0.5;
            });

        };

        var shuffle = function(array) {
            var copy = [], n = array.length, i;

            // While there remain elements to shuffle…
            while (n) {

                // Pick a remaining element…
                i = Math.floor(Math.random() * n--);

                // And move it to the new array.
                copy.push(array.splice(i, 1)[0]);
            }

            randomizeAnswer(copy);

            return copy;
        };

        var getPairs = function(){
            return shuffle(pairs);
        };

        return {
            getPairs : getPairs

        };

    }]);


