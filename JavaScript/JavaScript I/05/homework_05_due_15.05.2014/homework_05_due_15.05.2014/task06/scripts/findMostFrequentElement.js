///6. Write a program that finds the most frequent number in an array. Example:
///{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

var array = [];

function getResult() {
    readInput();
    document.getElementById('result').innerHTML = findMostFrequentElement(array);
}

function readInput() {
    array = document.getElementById('input-field').value.split(' ');
}

function findMostFrequentElement(array) {
    var frequency = [],
        count,
        value;

    for (var i = 0; i < array.length; i++) {
        count = 0;
        value = array[i];

        for (var j = i; j < array.length; j++) {
            if (value === array[j]) {
                count++;
            }
        }

        frequency[i] = count;
    }

    var maxFrequency = frequency[0];
    var maxIndex = 0;

    for (var i = 0; i < array.length; i++) {
        if (frequency[i] > maxFrequency) {
            maxFrequency = frequency[i];
            maxIndex = i;
        }
    }
    return ('The most frequent element is ' + array[maxIndex] + ' (' + maxFrequency + ' times)');
}



