/// 2. Write a script that compares two char arrays lexicographically (letter by letter).

var firstString,
    secondString;    

function submitArrays() {
    firstString = document.getElementById('first-char-array').value.toString();
    secondString = document.getElementById('second-char-array').value.toString();
    printResult();
}

function compareArrays(firstArray, secondArray) {
    var shorterArrayLength = (firstArray.length < secondArray.length) ? firstArray.length : secondArray.length;

    var result = 0; // will use -1 for (first < second), 0 for (first = second) and 1 for (first > second)

    for (var i = 0; i < shorterArrayLength; i++) {
        if (firstArray[i] === secondArray[i]) {
            if (i === shorterArrayLength - 1) {
                if (firstArray.length < secondArray.length) {
                    result = -1; // e.g. 'abc' < 'abcd'
                    break;
                } else if (firstArray.length < secondArray.length) {
                    result = 0; // identical arrays
                    break;
                } else if (firstArray.length > secondArray.length) {
                    result = 1; // e.g. 'abcd' > 'abc'
                    break;
                }
            }
            continue;
        } else if (firstArray[i] > secondArray[i]) {
            result = 1;
            break;
        } else if (firstArray[i] < secondArray[i]) {
            result = -1;
            break;
        }
    }

    return result;
}

function printResult() {
    var comparisonResult = (compareArrays(firstString, secondString));
    var sign;

    if (comparisonResult === -1) {
        sign = '<'
    } else if (comparisonResult === 0) {
        if (firstString.length === 0 || secondString.length === 0) {
            sign = 'error'; // defense
        } else {
            sign = '=';
        }        
    } else if (comparisonResult === 1) {
        sign = '>';
    }

    if (sign === '>' || sign === '=' || sign === '<') {
        document.getElementById('result').innerHTML = 'first array ' + sign + ' second array';        
    } else {
        document.getElementById('result').innerHTML = 'ERROR! Empty array entered.';
    }
    
}