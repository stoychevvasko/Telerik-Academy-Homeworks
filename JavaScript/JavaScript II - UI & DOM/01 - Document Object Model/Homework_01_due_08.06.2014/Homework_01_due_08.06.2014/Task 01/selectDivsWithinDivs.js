/// 01. Write a script that selects all div nodes that are directly inside other div elements.
/// * Create a function using querySelectorAll()
/// * Create a function using getElementsByTagName()

function solve() {
    var divsGetElementsBytagName = selectAllDivsWithinDivs();
    console.log('gotten via getElementsByTagName()');
    console.dir(divsGetElementsBytagName);

    var divsQuerySelectAllDivsWithinDivs = querySelectAllDivsWithinDivs();
    console.log('gotten via querySelectorAll()');
    console.dir(divsQuerySelectAllDivsWithinDivs);

    document.getElementById('result').innerHTML = 'Check browser console for results!';
}

function selectAllDivsWithinDivs() {
    var allDivs = document.getElementsByTagName('div');
    var divsWithinDivs = [];
    
    for (var i = 0; i < allDivs.length; i += 1) {
        var div = allDivs[i];
        if (div.parentNode.nodeName == "DIV") {
            divsWithinDivs.push(div);            
        }
    }
    return divsWithinDivs;
}

function querySelectAllDivsWithinDivs() {
    var divsWithinDivs = document.querySelectorAll('div > div');    
    return divsWithinDivs;
}