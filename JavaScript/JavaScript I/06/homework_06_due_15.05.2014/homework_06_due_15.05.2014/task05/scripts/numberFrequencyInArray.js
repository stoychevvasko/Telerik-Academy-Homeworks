///5. Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.

var array,
    searchItem;

function getResult() {
    array = readArray();
    searchItem = readSearchItem();

    var count = countFrequency(searchItem, array);
    document.getElementById('result').innerHTML = 'The element ' + searchItem + ' was found ' + count +
                                                  ' times in the array.\n\n\nOpen console to see test function.';

    testCountFrequency();
}

function readArray() {
    var result = document.getElementById('input-array').value.split(' ');

    var i;
    for (i = 0; i < result.length; i++) {
        result[i] = parseFloat(result[i]);
    }

    return result;
}

function readSearchItem() {
    var result = parseFloat(document.getElementById('input-search-item').value);
    return result;
}

function countFrequency(element, sequence) {
    var result = 0;

    var i;
    for (i = 0; i < sequence.length; i++) {
        if (element === sequence[i]) {
            result++;
        }
    }

    return result;
}

function testCountFrequency() {
    var hardcodedArray = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4];
    console.log(hardcodedArray);

    console.log('1 -> ' + countFrequency(1, hardcodedArray) + ' times');
    console.log('2 -> ' + countFrequency(2, hardcodedArray) + ' times');
    console.log('3 -> ' + countFrequency(3, hardcodedArray) + ' times');
    console.log('4 -> ' + countFrequency(4, hardcodedArray) + ' times');
    console.log('5 -> ' + countFrequency(5, hardcodedArray) + ' times');
}