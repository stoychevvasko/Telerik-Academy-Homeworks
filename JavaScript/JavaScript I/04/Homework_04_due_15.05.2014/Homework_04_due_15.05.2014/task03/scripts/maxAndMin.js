/// 3. Write a script that finds the max and min number from a sequence of numbers.

var inputString,
    numberArray;

function extractValues() {
    inputString = document.getElementById('input-field').value;
    numberArray = inputString.split(' ');

    // converting array to numeric values
    for (var i = 0; i < numberArray.length; i++) {
        numberArray[i] = parseFloat(numberArray[i]);
        if (isNaN(numberArray[i])) {
            numberArray.splice(i, 1); // removing NaN from array
            i--;
        }
    }
}

function findMin() {
    var minValue = Number.MAX_VALUE;
    for (var i = 0; i < numberArray.length; i++) {
        if (minValue > numberArray[i]) {
            minValue = numberArray[i];
        }
    }

    if (numberArray.length === 0) {
        return '-';
    }

    return minValue;
}

function findMax() {
    var maxValue = Number.MIN_VALUE;
    for (var i = 0; i < numberArray.length; i++) {
        if (maxValue < numberArray[i]) {
            maxValue = numberArray[i];
        }
    }

    if (numberArray.length === 0) {
        return '-';
    }

    return maxValue;
}

function getResult() {
    extractValues();
    document.getElementById('result').innerHTML = 'min: ' + findMin() + '   max: ' + findMax();
}

