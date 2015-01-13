///2. Write a function that reverses the digits of given decimal number. Example: 256 -> 652

var input,
    result;

function getResult() {
    input = readString();
    result = parseInt(reverseString(input));
    printResult(result);
}

function readString() {
    return document.getElementById('number-entry').value;
}

function reverseString(string) {
    var result = "";

    var i;
    for (i = 0; i < string.length; i++) {
        result = string[i] + result;
    }

    result = result.toString();
    return result;
}

function printResult(item) {
    document.getElementById('result').innerHTML = item;
}