///5. Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. 
///Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the 
///smallest from the rest, move it at the second position, etc.Hint: Use a second array.

var array = [];

function getResult() {
    readInput();
    document.getElementById('result').innerHTML = selectionSort(array);
}

function readInput() {
    array = document.getElementById('input-field').value.split(' ');
}

function selectionSort(array) {
    var min,
        minIndex,
        swapNumber;

    for (var i = 0; i < array.length; i++) {
        min = array[i];
        minIndex = i;

        for (var j = i; j < array.length; j++) {
            if (parseFloat(min) > parseFloat(array[j])) {
                min = array[j];
                minIndex = j;
            }
        }
        swapNumber = array[minIndex];
        array[minIndex] = array[i];
        array[i] = swapNumber;
    }
    return array;
}
