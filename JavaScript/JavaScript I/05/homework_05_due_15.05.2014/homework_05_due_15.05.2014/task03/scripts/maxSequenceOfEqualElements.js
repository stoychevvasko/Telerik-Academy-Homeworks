///3. Write a script that finds the maximal sequence of equal elements in an array. Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

var array = [];

function getResult() {
    readInput();
    document.getElementById('result').innerHTML = findSequence(array);
}

function readInput() {
    array = document.getElementById('input-field').value.split(' ');
}

function findSequence(array) {
    var repeatsArray = []; // repeatsArray[i] stores the number of equal elements starting from array[i] element
    var sequenceFound = [];


    // recursive method that returns the number of consecutive
    // equal elements from an array starting from a position "index"
    function lengthOfSequence(array, index, arrayLength) {
        if (index + 1 >= arrayLength) {
            return 1;
            //   array exhausted, last element - sequence of 1 element
        }
        else if (array[index] != array[index + 1]) {
            return 1;
            //     next element is not equal - sequence of 1 element
        }
        else {
            return (1 + lengthOfSequence(array, index + 1, arrayLength));
            //     next element is equal to current element - 1 is added to the next recursive instance            
        }
    }

    for (var i = 0; i < array.length; i++) {
        repeatsArray[i] = lengthOfSequence(array, i, array.length);
    }

    var maxSequenceIndex = 0;

    for (var i = 0; i < array.length; i++) {
        if (repeatsArray[i] >= repeatsArray[maxSequenceIndex]) {
            maxSequenceIndex = i;
        }

    }

    for (var i = maxSequenceIndex; i < maxSequenceIndex + repeatsArray[maxSequenceIndex]; i++) {
        sequenceFound.push(array[i]);
    }

    return sequenceFound;
}
