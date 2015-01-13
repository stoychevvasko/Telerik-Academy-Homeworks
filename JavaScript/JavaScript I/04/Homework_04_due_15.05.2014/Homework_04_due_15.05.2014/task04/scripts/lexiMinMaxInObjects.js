///4. Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects

var documentProperties = [],
    windowProperties = [],
    navigatorProperties = [];

function extractProperties() {
    for (var property in Document) {
        documentProperties.push(property);
    }

    for (var property in Window) {
        windowProperties.push(property);
    }

    for (var property in Navigator) {
        navigatorProperties.push(property);
    }
}


function findMin(array) {
    if (array.length === 0) {
        return '-';
    }

    var min = array[0];

    for (var i = 0; i < array.length; i++) {
        if (min > array[i]) {
            min = array[i];
        }
    }

    return min;
}

function findMax(array) {
    if (array.length === 0) {
        return '-';
    }

    var max = array[0];

    for (var i = 0; i < array.length; i++) {
        if (max < array[i]) {
            max = array[i];
        }
    }

    return max;
}

function getResult() {
    extractProperties();
    document.getElementById('result').innerHTML = 'document object:\nmin: ' + findMin(documentProperties) + '   max: ' + findMax(documentProperties) +
                                                  '\n\nwindow object:\nmin: ' + findMin(windowProperties) + '   max: ' + findMax(windowProperties) +
                                                  '\n\nnavigator object:\nmin: ' + findMin(navigatorProperties) + '   max: ' + findMax(navigatorProperties);
}