/// 1. Write an If statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

var integerFirst,
    integerSecond,
    integerSwapHelper;

function submitIntegers() {
    integerFirst = document.getElementById('integer-first').value;
    integerSecond = document.getElementById('integer-second').value;

    if (integerFirst > integerSecond) {
        integerSwapHelper = integerSecond;
        integerSecond = integerFirst;
        integerFirst = integerSwapHelper;
    }

    function checkForInteger(value) {
        if ((parseFloat(value) == parseInt(value)) && !isNaN(value)) {
            return true;
        } else {
            return false;
        }
    }

    if (checkForInteger(integerFirst) && checkForInteger(integerSecond)) {
        document.getElementById('result').innerHTML = 'integer1: ' + integerFirst + '\ninteger2: ' + integerSecond;
    } else {
        document.getElementById('result').innerHTML = 'ERROR! Invalid data entered! Try again.';
    }
}