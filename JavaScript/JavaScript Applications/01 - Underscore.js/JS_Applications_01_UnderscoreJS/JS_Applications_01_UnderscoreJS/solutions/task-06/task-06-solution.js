$(document).ready(function () {
    $('#generate-booklist').on('click', function () {
        var collection = [];
        var count = Math.floor(Math.random() * 25 + 1);
        for (var i = 0; i < count; i += 1) {
            var newBookEntry = generateRandomBook();
            collection.push(newBookEntry);
        };

        var groupedCollection = _.groupBy(collection, 'author');

        console.log('new book collection:');
        console.log(groupedCollection);

        var values = _.values(groupedCollection);
        var keys = _.keys(groupedCollection);
        var maxIndex = (function () {
            var result = 0;
            var max = 0;

            for (var i = 0, length = values.length; i < length; i += 1) {
                if (values[i].length > max) {
                    max = values[i].length;
                    result = i;
                }
            }
            return result;

        }());
        console.log('The most popular author is ' + keys[maxIndex] + ' with ' + values[maxIndex].length + ' books in this collection.');
        console.log(' ');
        console.log('------------------------------------------------------------------------------------------------------------------------');
        console.log(' ');
    });
}());

function generateRandomBook() {
    var authors = [
     'Arthur Clarke',
     'Stephen King',
     'Shakespeare',
     'Ivan Vazov',
     'Plato'
    ];

    var titles = [
        'Heart of Darkness',
        'Frankenstein',
        'Dracula',
        'Day of the Triffids',
        'I, robot'
    ];

    return {
        'author': authors[Math.floor(Math.random() * authors.length)],
        'title': titles[Math.floor(Math.random() * titles.length)]
    };
}