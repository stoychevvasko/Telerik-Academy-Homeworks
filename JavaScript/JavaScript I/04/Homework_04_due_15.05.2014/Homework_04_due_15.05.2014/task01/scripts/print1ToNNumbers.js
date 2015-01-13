/// 1. Write a script that prints all the numbers from 1 to N.

var N;

function submitInteger() {
    N = document.getElementById('integer-N').value;

    function checkForInteger(value) {
        if ((parseFloat(value) == parseInt(value)) && !isNaN(value)) {

            //check for positive integer
            if (value > 0) {
                return true;
            } else {
                return false;
            }            
        } else {
            return false;
        }
    }

    if (checkForInteger(N)) {
        var numbersString = '';
        for (var i = 1; i <= N; i++) {
            numbersString += (i + ' ');
        }

        document.getElementById('result').innerHTML = numbersString;
    } else {
        document.getElementById('result').innerHTML = 'ERROR! Invalid data entered! Try again.';
    }
}


