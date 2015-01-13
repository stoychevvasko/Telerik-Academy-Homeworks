///4. Write a function that checks if a given object contains a given property. 

var property,
    testObject = {
        property1: 'value1',
        property2: 'value2',
        //property3: 'non-existent property'
}

function solve() {    
    readInput();
    printResult();
}

function readInput() {
    property = document.getElementById('property-entry').value;    
}

function hasProperty(object, property) {
    for (var i in object) {

        if (i == property) {
            return true;
            break;
        }
    }
    return false;
}

function printResult() {
    document.getElementById('result').innerHTML = hasProperty(testObject, property);
}