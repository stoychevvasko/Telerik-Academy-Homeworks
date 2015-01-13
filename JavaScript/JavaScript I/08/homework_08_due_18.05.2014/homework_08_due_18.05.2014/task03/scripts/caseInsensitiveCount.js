///03. Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
///    Example: The target substring is "in". The text is as follows:
///    "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
///    The result is: 9.

var text,
    searchItem;

function solve() {
    readDataFromHtml();
    printToHtml('The item ' + searchItem + ' was found ' + countSensitiveSearch(text, searchItem) +
        ' times in the text.');
}

function readDataFromHtml() {
    text = document.getElementById('string-entry').value;
    searchItem = document.getElementById('search-entry').value;
}

function printToHtml(string) {
    document.getElementById('result').innerHTML = string;
}

function countSensitiveSearch(source, searchItem) {
    var result = 0;
    source = source.toLowerCase();
    searchItem = searchItem.toLowerCase();
    for (var i = 0; i < source.length - searchItem.length; i += 1) {
        if (source.substr(i, searchItem.length) === searchItem) {
            result += 1;
            i += searchItem.length;
        }
    }
    return result;
}
