/// 6. Write a script that enters the coefficients a, b and c of a quadratic equation ax^2 + bx + c = 0 and calculates and prints its real roots. 
/// Note that quadratic equations may have 0, 1 or 2 real roots.

var a,
    b,
    c,
    determinant;

function extractValues() {
    a = document.getElementById('num-first').value;
    b = document.getElementById('num-second').value;
    c = document.getElementById('num-third').value;
}

function validateSingleNumber(numericValue) {
    if (numericValue === '') {
        return false;
    }
    return !isNaN(numericValue);
}

function validateInput() {
    return (validateSingleNumber(a) && validateSingleNumber(b) && validateSingleNumber(c));
}

function calculateDeterminant() {
    determinant = b * b - 4 * a * c;
}

function calculateRoots() {
    calculateDeterminant();
    if (determinant < 0) {
        return 'no real roots';
    } else if (determinant === 0) {
        return 'twin roots: x1 = x2 = ' + (-b / (2 * a));
    } else if (determinant > 0) {
        return 'x1 = ' + ((-b + Math.sqrt(determinant)) / 2 * a) + '\nx2 = ' + ((-b - Math.sqrt(determinant)) / 2 * a);
    }
}

function getResult() {
    extractValues();
    if (validateInput()) {
        document.getElementById('result').innerHTML = calculateRoots();
    } else {
        document.getElementById('result').innerHTML = 'Invalid input! Try again!';
    }
}
