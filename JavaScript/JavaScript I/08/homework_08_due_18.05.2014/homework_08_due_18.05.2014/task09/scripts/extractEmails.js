///09. Write a function for extracting all email addresses from given text. All substrings that match the format 
///    <identifier>@<host>…<domain> should be recognized as emails. Return the emails as array of strings.

var text,
    emailArray;

function solve() {
    text = document.getElementById('string-entry').value.split(' ');
    
    emailArray = [];
    for (var i = 0; i < text.length; i++) {
        if (looksLikeMail(text[i])) {
            emailArray.push(text[i]);
        }
    }

    document.getElementById('result').innerHTML = emailArray.join('\n');
}

function looksLikeMail(str) {
    var lastAtPos = str.lastIndexOf('@');
    var lastDotPos = str.lastIndexOf('.');
    return (lastAtPos < lastDotPos && lastAtPos > 0 && str.indexOf('@@') == -1 && lastDotPos > 2 && (str.length - lastDotPos) > 2);
}