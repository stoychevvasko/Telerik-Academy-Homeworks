/// 5. Write a script that asks for a digit and depending on the input shows the name of that digit (in English) using a Switch statement.

var number;

function extractValues() {
    number = document.getElementById('num-first').value;
    
}

function checkForInteger(value) {
    if ((parseFloat(value) == parseInt(value)) && !isNaN(value)) {
        return true;
    } else {
        return false;
    }
}

function announceNumber(value) {
    switch (parseInt(value)) {
        case 1: return 'one'; break;
        case 2: return 'two'; break;
        case 3: return 'three'; break;
        case 4: return 'four'; break;
        case 5: return 'five'; break;
        case 6: return 'six'; break;
        case 7: return 'seven'; break;
        case 8: return 'eight'; break;
        case 9: return 'nine'; break;
        case 0: return 'zero'; break;
        default: return 'invalid digit'; break;
    }
}


function getResult() {
    extractValues();
    if (checkForInteger(number) && number >= 0 && number < 10) {
        document.getElementById('result').innerHTML = announceNumber(number);
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}

