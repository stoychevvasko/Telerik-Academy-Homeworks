$(document).ready(function () {
    var animals = [
      { 'name': 'Tom', 'species': 'cat', 'numberOfLegs': 4 },
      { 'name': 'Jerry', 'species': 'mouse', 'numberOfLegs': 4 },
      { 'name': 'Tweety', 'species': 'bird', 'numberOfLegs': 2 },
      { 'name': 'Sylvester', 'species': 'cat', 'numberOfLegs': 4 },
      { 'name': 'Wile E. Coyote', 'species': 'coyote', 'numberOfLegs': 4 },
      { 'name': 'Roadrunner', 'species': 'bird', 'numberOfLegs': 2 },
      { 'name': 'Three-legged chicken for argument`s sake', 'species': 'bird', 'numberOfLegs': 3 },
      { 'name': 'Bugs Bunny', 'species': 'rabbit', 'numberOfLegs': 2 },
      { 'name': 'Elmer Fudd', 'species': 'human', 'numberOfLegs': 2 },
      { 'name': 'Daffy Duck', 'species': 'bird', 'numberOfLegs': 2 },
      { 'name': 'Captain Hook', 'species': 'human', 'numberOfLegs': 1 },      
      { 'name': 'Courage the Cowardly Dog', 'species': 'dog', 'numberOfLegs': 4 },
      { 'name': 'Legs No Mo', 'species': 'bird', 'numberOfLegs': 0 },
    ];

    console.log('Original array of animals:');
    console.log(animals);

    console.log('Animals grouped by species and sorted by number of legs:');
    var groupedAndSortedAnimals = groupBySpeciesAndSortByNumberOfLegs(animals);
    console.log(groupedAndSortedAnimals);
}());

function groupBySpeciesAndSortByNumberOfLegs(animals) {
    var sortedAnimals = _.sortBy(animals, 'numberOfLegs');
    var groupedAnimals = _.groupBy(sortedAnimals, 'species');
    return groupedAnimals;
}