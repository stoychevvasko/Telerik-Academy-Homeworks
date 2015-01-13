///02. Write a JavaScript function to check if in a given expression the brackets are put correctly.
///    Example of correct expression: ((a+b)/5-d).
///    Example of incorrect expression: )(a+b)).

var expression;

function solve() {
    expression = readStringFromHtml();
    printToHtml('The expression uses brackets correctly?\n\n' + isExpressionCorrect(expression));
}

function readStringFromHtml() {
    var value = document.getElementById('expression-entry').value;
    return value;
}

function printToHtml(string) {
    document.getElementById('result').innerHTML = string;
}

function isExpressionCorrect(expression) {
    var openBrackets = 0,
        closeBrackets = 0,
        result = true;

    for (var i = 0; i < expression.length; i += 1) {
        if (expression[i] === '(') {
            openBrackets += 1;
        } else if (expression[i] === ')') {
            closeBrackets += 1;
        }
    }

    if (expression[0] === ')' || expression[expression.length - 1] === '(') {
        result = false;
    } else if (openBrackets !== closeBrackets) {
        result = false;
    }

    return result;
}