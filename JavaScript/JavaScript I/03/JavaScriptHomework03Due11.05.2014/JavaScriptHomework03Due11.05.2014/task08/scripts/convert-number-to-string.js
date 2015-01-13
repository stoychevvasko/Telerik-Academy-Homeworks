/// 8. Write a script that converts a number in the range [0..999] to a text corresponding to its English pronunciation.

var number;

function extractValues() {
    number = document.getElementById('num').value;
}

function checkForInteger(value) {
    if ((parseFloat(value) == parseInt(value)) && !isNaN(value)) {
        return true;
    } else {
        return false;
    }
}

function validateInput() {
    if (number === '' || number === null) {
        return false;
    } else if (checkForInteger(number)) {
        if (number >= 0 && number < 1000) {
            return true;
        } else {
            return false;
        }
    } else {
        return false;
    }
}

function announceNumber(num) {
    var numWords = ''; // string containing the result

    // for numbers with hundreds
    if ((num - (num % 100)) != 0) {
        switch (num - (num % 100)) {
            case 100: numWords = 'one hundred'; break;
            case 200: numWords = 'two hundred'; break;
            case 300: numWords = 'three hundred'; break;
            case 400: numWords = 'four hundred'; break;
            case 500: numWords = 'five hundred'; break;
            case 600: numWords = 'six hundred'; break;
            case 700: numWords = 'seven hundred'; break;
            case 800: numWords = 'eight hundred'; break;
            case 900: numWords = 'nine hundred'; break;
        }

        // for 101-119, 201-219, 301-319, etc.
        if (num % 100 < 20) {
            switch (num % 100) {
                case 1: numWords += ' and one'; break;
                case 2: numWords += ' and two'; break;
                case 3: numWords += ' and three'; break;
                case 4: numWords += ' and four'; break;
                case 5: numWords += ' and five'; break;
                case 6: numWords += ' and six'; break;
                case 7: numWords += ' and seven'; break;
                case 8: numWords += ' and eight'; break;
                case 9: numWords += ' and nine'; break;
                case 10: numWords += ' and ten'; break;
                case 11: numWords += ' and eleven'; break;
                case 12: numWords += ' and twelve'; break;
                case 13: numWords += ' and thirteen'; break;
                case 14: numWords += ' and fourteen'; break;
                case 15: numWords += ' and fifteen'; break;
                case 16: numWords += ' and sixteen'; break;
                case 17: numWords += ' and seventeen'; break;
                case 18: numWords += ' and eighteen'; break;
                case 19: numWords += ' and nineteen'; break;
            }
        } else { // for 120-199, 220-299, 320-399, etc.
            switch ((num % 100) - ((num % 100) % 10)) {
                case 20: numWords += ' and twenty'; break;
                case 30: numWords += ' and thirty'; break;
                case 40: numWords += ' and forty'; break;
                case 50: numWords += ' and fifty'; break;
                case 60: numWords += ' and sixty'; break;
                case 70: numWords += ' and seventy'; break;
                case 80: numWords += ' and eighty'; break;
                case 90: numWords += ' and ninety'; break;
            }

            switch (num % 10) {
                case 1: numWords += '-one'; break;
                case 2: numWords += '-two'; break;
                case 3: numWords += '-three'; break;
                case 4: numWords += '-four'; break;
                case 5: numWords += '-five'; break;
                case 6: numWords += '-six'; break;
                case 7: numWords += '-seven'; break;
                case 8: numWords += '-eight'; break;
                case 9: numWords += '-nine'; break;
            }
        }
    } else { // for numbers without hundreds
        if (num < 20) {// for 0-19
            switch (num) {
                case 0: numWords += 'zero'; break;
                case 1: numWords += 'one'; break;
                case 2: numWords += 'two'; break;
                case 3: numWords += 'three'; break;
                case 4: numWords += 'four'; break;
                case 5: numWords += 'five'; break;
                case 6: numWords += 'six'; break;
                case 7: numWords += 'seven'; break;
                case 8: numWords += 'eight'; break;
                case 9: numWords += 'nine'; break;
                case 10: numWords += 'ten'; break;
                case 11: numWords += 'eleven'; break;
                case 12: numWords += 'twelve'; break;
                case 13: numWords += 'thirteen'; break;
                case 14: numWords += 'fourteen'; break;
                case 15: numWords += 'fifteen'; break;
                case 16: numWords += 'sixteen'; break;
                case 17: numWords += 'seventeen'; break;
                case 18: numWords += 'eighteen'; break;
                case 19: numWords += 'nineteen'; break;
            }
        } else { // for 20-99
            switch (num - (num % 10)) {
                case 2: numWords = 'twenty'; break;
                case 3: numWords = 'thirty'; break;
                case 4: numWords = 'forty'; break;
                case 5: numWords = 'fifty'; break;
                case 6: numWords = 'sixty'; break;
                case 7: numWords = 'seventy'; break;
                case 8: numWords = 'eighty'; break;
                case 9: numWords = 'ninety'; break;
            }

            switch (num % 10) {
                case 1: numWords += '-one'; break;
                case 2: numWords += '-two'; break;
                case 3: numWords += '-three'; break;
                case 4: numWords += '-four'; break;
                case 5: numWords += '-five'; break;
                case 6: numWords += '-six'; break;
                case 7: numWords += '-seven'; break;
                case 8: numWords += '-eight'; break;
                case 9: numWords += '-nine'; break;
            }
        }
    }

    return numWords;
}

function getResult() {
    extractValues();
    if (validateInput()) {
        document.getElementById('result').innerHTML = announceNumber(parseInt(number));
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}

