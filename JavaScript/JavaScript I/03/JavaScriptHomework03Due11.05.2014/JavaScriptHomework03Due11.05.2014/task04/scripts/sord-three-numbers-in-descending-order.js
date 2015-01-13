/// 4. Sort three real values in descending order using nested If statements.

var numFirst,
    numSecond,
    numThird,
    swapHelperNum;

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

// this does not work in JS as it forces passing of parameters by value. 
// What do you think should be done here? Masquarede everything as "object" in order
// to cheat JS into passing parameters by reference? Any ideas?

//function swapNums(numOne, numTwo) {
//    swapHelperNum = numTwo;
//    numTwo = numOne;
//    numOne = swapHelperNum;
//}

function sortThreeNumbersInDescendingOrder() {
    if (numFirst >= numSecond) {
        if (numSecond >= numThird) {
            return;
        } else {
            //swapNums(numSecond, numThird);
            swapHelperNum = numThird;
            numThird = numSecond;
            numSecond = swapHelperNum;
            sortThreeNumbersInDescendingOrder();
        }
    } else {
        //swapNums(numFirst, numSecond);
        swapHelperNum = numFirst;
        numFirst = numSecond;
        numSecond = swapHelperNum;
        if (numSecond >= numThird) {
            sortThreeNumbersInDescendingOrder();
        } else {
            //swapNums(numSecond, numThird);
            swapHelperNum = numSecond;
            numSecond = numThird;
            numThird = swapHelperNum;
            sortThreeNumbersInDescendingOrder();
        }
    }
}

function getResult() {
    extractValues();
    if (validateInput()) {
        sortThreeNumbersInDescendingOrder(numFirst, numSecond, numThird);
        document.getElementById('result').innerHTML = numFirst + ' >= ' + numSecond + ' >= ' + numThird;
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}

