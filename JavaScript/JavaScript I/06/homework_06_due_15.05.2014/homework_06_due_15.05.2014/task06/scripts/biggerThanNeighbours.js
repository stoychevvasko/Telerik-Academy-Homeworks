///6. Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

var array,
    index;

function getResult() {
    readArray();
    readIndex();

    var finalString = 'The element ' + array[index] + ' at index ' + index + ' is larger than its two neighbours?\n' + compareToNeighbours();
    document.getElementById('result').innerHTML = finalString;
}

function readArray() {
    array = document.getElementById('input-field').value.split(' ');

    var i;
    for (i = 0; i < array.length; i++) {
        array[i] = parseInt(array[i]);
    }
}

function readIndex() {
    index = parseInt(document.getElementById('input-index').value);
}

function compareToNeighbours() {
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
