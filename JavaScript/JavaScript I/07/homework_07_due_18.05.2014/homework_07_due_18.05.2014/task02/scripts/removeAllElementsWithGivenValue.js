///2. Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.

var array = [],
    elementToRemove;

function solve() {
    readInput();
    array = array.remove(elementToRemove);
    printResults();
}

function readInput() {
    array = document.getElementById('array-entry').value.split(' ');
    elementToRemove = document.getElementById('element-entry').value;
}

Array.prototype.remove = function (elementToRemove) {
    var resultingArray = [];
    for (var i in this) {
        if (this[i] !== elementToRemove) {
            resultingArray.push(this[i]);
        }
    }
    resultingArray.pop(this[this.length - 1]); //otherwise this function itself becomes an element
    return resultingArray;
}

function printResults() {
    document.getElementById('result').innerHTML = array;
}