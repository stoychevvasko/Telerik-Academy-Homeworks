///4. Write a script that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

var array = [];

function getResult() {
    readInput();
    document.getElementById('result').innerHTML = findSequence(array);
}

function readInput() {
    array = document.getElementById('input-field').value.split(' ');
}

function findSequence(array) {
    var increasingArray = []; // increasingArray[i] stores the number of equal elements starting from array[i] element
    var sequenceFound = [];


    // recursive method that returns the number of consecutive
    // rising elements from an array starting from a position "index"
    function lengthOfSequence(array, index, arrayLength) {
        if (index + 1 >= arrayLength) {
            return 1;
            //   array exhausted, last element - sequence of 1 element
        }
        else if (array[index] >= array[index + 1]) {
            return 1;
            //     next element is not greater - sequence of 1 element
        }
        else {
            return (1 + lengthOfSequence(array, index + 1, arrayLength));
            //     next element is greater than current element - 1 is added to the next recursive instance            
        }
    }

    for (var i = 0; i < array.length; i++) {
        increasingArray[i] = lengthOfSequence(array, i, array.length);
    }

    var maxSequenceIndex = 0;

    for (var i = 0; i < array.length; i++) {
        if (increasingArray[i] >= increasingArray[maxSequenceIndex]) {
            maxSequenceIndex = i;
        }

    }

    for (var i = maxSequenceIndex; i < maxSequenceIndex + increasingArray[maxSequenceIndex]; i++) {
        sequenceFound.push(array[i]);
    }

    return sequenceFound;
}
