$(document).ready(function () {
    $('#generate-people-list').on('click', function () {
        var collection = [];
        var count = Math.floor(Math.random() * 25 + 1);
        for (var i = 0; i < count; i += 1) {
            var newPersonEntry = generateRandomName();
            collection.push(newPersonEntry);
        };

        

        var groupedCollectionByFirstName = _.groupBy(collection, 'firstName');        
        

        var valuesFirstName = _.values(groupedCollectionByFirstName);
        var keysFirstName = _.keys(groupedCollectionByFirstName);

        var maxIndexFirstName = (function () {
            var result = 0;
            var max = 0;
            for (var i = 0, length = valuesFirstName.length; i < length; i += 1) {
                if (valuesFirstName[i].length > max) {
                    max = valuesFirstName[i].length;
                    result = i;
                }
            }

            return result;
        }());
        
        var groupedCollectionByLastName = _.groupBy(collection, 'lastName');
        
        var valuesLastName = _.values(groupedCollectionByLastName);
        var keysLastName = _.keys(groupedCollectionByLastName);

        var maxIndexLastName = (function () {
            var result = 0;
            var max = 0;
            for (var i = 0, length = valuesLastName.length; i < length; i += 1) {
                if (valuesLastName[i].length > max) {
                    max = valuesLastName[i].length;
                    result = i;
                }
            }

            return result;
        }());

        console.log('new original people collection:');
        console.log(collection);
        console.log(' ');
        console.log('grouped by first name:');
        console.log(groupedCollectionByFirstName);
        console.log('The most common name is ' + keysFirstName[maxIndexFirstName] + ' and it was found ' + valuesFirstName[maxIndexFirstName].length + ' times.');
        console.log(' ');
        console.log('grouped by last name:');
        console.log(groupedCollectionByLastName);
        console.log('The most common surname is ' + keysLastName[maxIndexLastName] + ' and it was found ' + valuesLastName[maxIndexLastName].length + ' times.');
        console.log(' ');
        console.log('------------------------------------------------------------------------------------------------------------------------');
        console.log(' ');
        
    });
}());



function generateRandomName() {
    var names = [
     'John',
     'Jane',
     'Jack',
     'Jean',
     'Jake',
     'Joffrey',
     'Joanna'
    ];

    var surnames = [
        'Smith',
        'Stone',
        'Steel',
        'Stephens',
        'Stuart'
    ];

    return {
        'firstName': names[Math.floor(Math.random() * names.length)],
        'lastName': surnames[Math.floor(Math.random() * surnames.length)]
    };
}