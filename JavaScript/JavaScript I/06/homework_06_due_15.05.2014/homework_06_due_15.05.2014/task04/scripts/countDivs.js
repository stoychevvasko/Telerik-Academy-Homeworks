///4. Write a function to count the number of divs on the web page

function getResult() {
    var allDivs = document.getElementsByTagName('div');
    document.getElementById('result').innerHTML = 'This document has ' + allDivs.length + ' <div> tags.';
}