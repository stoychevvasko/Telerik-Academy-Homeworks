$(document).ready(function () {
    var animalTypes = [
        { 'species': 'centipede', 'legs': 100 },
        { 'species': 'biped', 'legs': 2 },
        { 'species': 'quadruped', 'legs': 4 },
        { 'species': 'insect', 'legs': 6 },
        { 'species': 'arthropod', 'legs': 8 },
    ];

    $('#generate-animals').on('click', function () {
        var collection = [];
        var count = Math.floor(Math.random() * 10 + 1);        
        for (var i = 0; i < count; i += 1) {
            var animalType = animalTypes[Math.floor(Math.random() * 5)];
            var newAnimalEntry = {
                'name': 'animal ' + (i + 1),
                'species': animalType.species,
                'numberOfLegs': animalType.legs
            };
            collection.push(newAnimalEntry);
        };
                
        console.log('new animal collection:');
        console.log(collection);
        console.log('total number of legs: ' + countLegs(collection));
        console.log('--------------------------------------------------');
    });    
}());

function countLegs(animals) {
    var result = 0;
    for (var i = 0, length = animals.length; i < length; i+=1) {
        result += animals[i].numberOfLegs;
    }

    return result;
}