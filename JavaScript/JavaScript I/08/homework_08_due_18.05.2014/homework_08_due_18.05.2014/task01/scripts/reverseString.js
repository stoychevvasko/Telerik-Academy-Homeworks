///01. Write a JavaScript function reverses string and returns it.
///Example: "sample" -> "elpmas".

var string;

function solve() {
    string = readStringFromHtml();
    printToHtml(reverseString(string));
}

function readStringFromHtml() {
    var value = document.getElementById('string-entry').value;
    return value;
}

function reverseString(string) {
    var result = [];
    for (var i = string.length - 1; i >= 0; i -= 1) {
        result.push(string[i]);
    }

    return String(result.join(''));
}

function printToHtml(string) {
    document.getElementById('result').innerHTML = string;
}

