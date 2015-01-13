/// 7. Write a script that finds the greatest of 5 given variables.

var numFirst,
    numSecond,
    numThird,
    numFourth,
    numFifth;

function extractValues() {
    numFirst = document.getElementById('num-first').value;
    numSecond = document.getElementById('num-second').value;
    numThird = document.getElementById('num-third').value;
    numFourth = document.getElementById('num-fourth').value;
    numFifth = document.getElementById('num-fifth').value;
}

function validateSingleNumber(value) {
    if (value === '' || value === null) {
        return false;
    } else {
        return true;
    }
}

function validateInput() {
    return (validateSingleNumber(numFirst) && validateSingleNumber(numSecond) &&
            validateSingleNumber(numThird) && validateSingleNumber(numFourth) && validateSingleNumber(numFifth));
}

function findGreatestOfFive() {
    var array = [numFirst, numSecond, numThird, numFourth, numFifth];
    array.sort();
    return array[4];
}

function getResult() {
    extractValues();
    if (validateInput()) {
        document.getElementById('result').innerHTML = findGreatestOfFive();
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}

