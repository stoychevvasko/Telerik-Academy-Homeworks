///06. Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags

var text;

function solve() {
    text = document.getElementById('string-entry').value;
    text = extractText(text);
    document.getElementById('result').innerHTML = text;
}

function extractText(text) {

    var result = [];

    for (var i = 0; i < text.length; i+=1) {
        if (text[i] === '<'){
            while (text[i] !== '>' && i < text.length) {
                i += 1;
            }
        } else {
            result.push(text[i]);
        }
    }

    result = result.join('');
    return result;
}

