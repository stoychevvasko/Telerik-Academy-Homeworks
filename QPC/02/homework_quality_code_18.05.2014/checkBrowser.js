//03. Refactor the following examples to produce code with well-named identifiers in JavaScript

function onButtonClick(event, arguments) {
    var currentWindow = window;
    var browser = currentWindow.navigator.appCodeName;
    var isMozilla = browser == "Mozilla";
    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
