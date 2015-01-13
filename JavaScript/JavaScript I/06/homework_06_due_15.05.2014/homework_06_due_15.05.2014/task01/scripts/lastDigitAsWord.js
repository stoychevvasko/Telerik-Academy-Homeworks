///1. Write a function that returns the last digit of given integer as an English word. 
///   Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine"

var lastDigit;
function getLastDigitAsWord() {
    lastDigit = readLastDigitOfInteger();
    displayResult(lastDigit);
}

function readLastDigitOfInteger() {
    var inputString = document.getElementById('integer-entry').value;    
    var integer = parseInt(inputString[inputString.length - 1], 10);
    return integer;
}

function displayResult(result) {
    switch (result) {
        case 0: document.getElementById('result').innerHTML = 'zero'; break;
        case 1: document.getElementById('result').innerHTML = 'one'; break;
        case 2: document.getElementById('result').innerHTML = 'two'; break;
        case 3: document.getElementById('result').innerHTML = 'three'; break;
        case 4: document.getElementById('result').innerHTML = 'four'; break;
        case 5: document.getElementById('result').innerHTML = 'five'; break;
        case 6: document.getElementById('result').innerHTML = 'six'; break;
        case 7: document.getElementById('result').innerHTML = 'seven'; break;
        case 8: document.getElementById('result').innerHTML = 'eight'; break;
        case 9: document.getElementById('result').innerHTML = 'nine'; break;
        default: document.getElementById('result').innerHTML = 'invalid digit'; break;
    }
}