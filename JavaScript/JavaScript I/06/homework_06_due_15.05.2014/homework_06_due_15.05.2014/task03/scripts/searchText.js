///3. Write a function that finds all the occurrences of word in a text
///* The search can case sensitive or case insensitive
///* Use function overloading

var text,
    searchItem,
    foundNumberOfTimes;

function searchCaseInsensitive() {
    processValuesFromHTML();
    countFinds(searchItem, text, false);
}

function searchCaseSensitive() {
    processValuesFromHTML();
    countFinds(searchItem, text, true);
}

function processValuesFromHTML() {
    text = readText();
    text = text.split(' ');

    searchItem = readSearchItem();
}

function readText() {
    return document.getElementById('input-field').value;
}

function readSearchItem() {
    return document.getElementById('search-field').value;
}

function countFinds(item, array, isCaseSensitive) {
    foundNumberOfTimes = 0;

    switch (isCaseSensitive) {
        case true: {
            var i;
            for (i = 0; i < array.length; i++) {
                if ((item.toString()).localeCompare(array[i].toString()) === 0) {
                    foundNumberOfTimes++;
                }
            }

            document.getElementById('result').innerHTML = 'word "' + searchItem + '" was found ' + foundNumberOfTimes + ' times (case sensitive)';
            return;            
        }
        case false: {
            var i;
            for (i = 0; i < array.length; i++) {
                if ((item.toString().toLowerCase()).localeCompare(array[i].toString().toLowerCase()) === 0) {
                    foundNumberOfTimes++;
                }
            }

            document.getElementById('result').innerHTML = 'word "' + searchItem + '" was found ' + foundNumberOfTimes + ' times (case insensitive)';
            return;
        }
    }    
}