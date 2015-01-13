///10. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var text,
    finalArray;

function solve() {
    text = (clearPunctuation(document.getElementById('string-entry').value)).split(' ');
    finalArray = extractPalindromes(text);
    document.getElementById('result').innerHTML = finalArray.join('\n');
}

function reverseString(string) {
    var result = [];
    for (var i = string.length - 1; i >= 0; i -= 1) {
        result.push(string[i]);
    }

    return String(result.join(''));
}

function isPalindrome(string) {
    if (string === reverseString(string)) {
        return true;
    } else {
        return false;
    }
}

function clearPunctuation(string) {
    var result = string;
    result = result.replace(/[^\w\s]|_/g, "").replace(/\s+/g, " ");
    return result;
}

function extractPalindromes(array) {
    var resultsArray = [];
    for (var i = 0; i < array.length; i += 1) {
        if (isPalindrome(array[i])) {
            resultsArray.push(array[i]);
        }
    }
    return resultsArray;
}