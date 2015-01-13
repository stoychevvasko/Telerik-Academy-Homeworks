///05. Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = 'these words are separated by the non-breaking white-space character';

function solve() {
    text = text.replace('\u00A0', '&nbsp');
    document.getElementById('result').innerHTML = text;
}