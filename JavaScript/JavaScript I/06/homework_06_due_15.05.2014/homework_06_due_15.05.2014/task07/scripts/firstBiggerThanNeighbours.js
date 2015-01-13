///7. Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
/// *Use the function from the previous exercise.

var array,
    index;

function getResult() {
    readArray();    
    index = findFirstBiggerThanNeighbours();

    var finalString = 'The first element bigger than its neighbours is ' + array[index] + ' at position ' + index;
    document.getElementById('result').innerHTML = finalString;
}

function readArray() {
    array = document.getElementById('array-input').value.split(' ');

    var i;
    for (i = 0; i < array.length; i++) {
        array[i] = parseInt(array[i]);
    }
}

function compareToNeighbours(index) {
    if ((index <= 0) || (index >= (array.length - 1))) {
        return false;
    } else {
        if ((array[index] > array[index + 1]) && (array[index] > array[index - 1])) {
            return true;
        } else {
            return false;
        }
    }
}

function findFirstBiggerThanNeighbours() {
    var i;
    for (i = 0; i < array.length; i++) {
        if (compareToNeighbours(i)) {
            return i;
        }
    }

    return -1;
}
