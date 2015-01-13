/// 3. Write a script that finds the biggest of three integers using nested If statements.

var numFirst,
    numSecond,
    numThird;

document.getElementById('submit-button').onclick = function () {
    getResult();
}

function extractValues() {
    numFirst = document.getElementById('num-first').value;
    numSecond = document.getElementById('num-second').value;
    numThird = document.getElementById('num-third').value;
}

function validateSingleNumber(numericValue) {
    if (numericValue === '') {
        return false;
    }

    if ((parseFloat(numericValue) == parseInt(numericValue)) && !isNaN(numericValue)) {
        return true;
    } else {
        return false;
    }
}

function validateInput() {
    return (validateSingleNumber(numFirst) && validateSingleNumber(numSecond) && validateSingleNumber(numThird));
}

function findBiggestNumber(firstValue, secondValue, thirdValue) {
    var first = parseFloat(firstValue),
        second = parseFloat(secondValue),
        third = parseFloat(thirdValue);

    if (first >= second) {
        if (first >= third) {
            return first;
        } else {
            return third;
        }
    } else if (second >= third) {
        return second;
    } else {
        return third;
    }
}

function getResult() {
    extractValues();
    if (validateInput()) {
        document.getElementById('result').innerHTML = findBiggestNumber(numFirst, numSecond, numThird);
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}

