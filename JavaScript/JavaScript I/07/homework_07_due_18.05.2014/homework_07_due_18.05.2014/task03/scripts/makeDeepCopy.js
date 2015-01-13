///3. Write a function that makes a deep copy of an object. The function should work for both primitive and reference types

var integer = 5,
    float = 3.14,
    bool = true,
    string = "na baba ti hwurchiloto",
    char = '*',
    array = [1, 2, 3, 4, 5],
    nestedArray = [1, 2, 3, [1, 2, 3, [3, 4, 5]]],
    nullVar = null,
    undefinedVar = undefined;

var integerCopy,
    floatCopy,
    boolCopy,
    stringCopy,
    charCopy,
    arrayCopy,
    nestedArrayCopy,
    nullVarCopy,
    undefinedVarCopy;


function solve() {
    makeCopies();
    printResults();
}

function deepCopy(obj) {
    if (null == obj || "object" != typeof obj) return obj;
    var copy = obj.constructor();
    for (var attr in obj) {
        if (obj.hasOwnProperty(attr)) copy[attr] = obj[attr];
    }
    return copy;
}

function makeCopies() {
    integerCopy = deepCopy(integer);
    floatCopy = deepCopy(float);
    boolCopy = deepCopy(bool);
    stringCopy = deepCopy(string);
    charCopy = deepCopy(char);
    arrayCopy = deepCopy(array);
    nestedArrayCopy = deepCopy(nestedArray);
    nullVarCopy = deepCopy(nullVar);
    undefinedVarCopy = deepCopy(undefinedVar);
}

function printResults() {
    document.getElementById('result').innerHTML =
        'integerCopy = ' + integerCopy + '\n' +
        'floatCopy = ' + floatCopy + '\n' +
        'boolCopy = ' + boolCopy + '\n' +
        'stringCopy = ' + stringCopy + '\n' +
        'charCopy = ' + charCopy + '\n' +
        'arrayCopy = ' + arrayCopy + '\n' +
        'nestedArrayCopy = ' + nestedArrayCopy + '\n' +
        'nullVarCopy = ' + nullVarCopy + '\n' +
        'undefinedVarCopy = ' + undefinedVarCopy;
}