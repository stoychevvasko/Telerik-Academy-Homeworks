/// 2. Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of If statements

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
    return !isNaN(numericValue);
}

function validateInput() {
    return (validateSingleNumber(numFirst) && validateSingleNumber(numSecond) && validateSingleNumber(numThird));
}

function determineSign(firstValue, secondValue, thirdValue) {
    if (firstValue == 0 || secondValue == 0 || thirdValue == 0) {
        return 'unsigned (0)';
    }

    if (firstValue > 0) {
        if (secondValue > 0) {
            if (thirdValue > 0) {
                return '+';
            } else {
                return '-';
            }
        } else {
            if (thirdValue > 0) {
                return '-';
            } else {
                return '+';
            }
        }
    } else {
        if (secondValue > 0) {
            if (thirdValue > 0) {
                return '-';
            } else {
                return '+';
            }
        } else {
            if (thirdValue > 0) {
                return '+';
            } else {
                return '-';
            }
        }
    }
}

function getResult() {
    extractValues();
    if (validateInput()) {
        document.getElementById('result').innerHTML = determineSign(numFirst, numSecond, numThird);
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}

