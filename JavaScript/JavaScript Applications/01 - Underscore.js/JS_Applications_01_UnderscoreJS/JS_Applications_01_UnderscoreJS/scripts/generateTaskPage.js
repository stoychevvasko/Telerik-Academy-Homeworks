$(document).ready(function () {
    $('#task-title').on('click', function () {
        resetDisplay('#task-title');
    });

    $('#back-button').on('click', function () {
        resetDisplay('#back-button');
    });

    $('#generate-animals').on('click', function () {
        resetDisplay('#generate-animals');
    });
    
    $('#generate-booklist').on('click', function () {
        resetDisplay('#generate-booklist');
    });

    $('#generate-people-list').on('click', function () {
        resetDisplay('#generate-people-list');
    });
});

function blinkSingleElement(elementSelector) {
    for (var i = 0; i < 3; i += 1) {
        $(elementSelector).fadeTo(0, Math.random(), function () { }).delay(66).fadeTo(Math.random() * 66, 1, function () { });
    }
    document.getElementById('buzz2').play();
};

function resetDisplay(selector) {
    blinkSingleElement(selector);
    //$('#wrapper').html('');
    document.getElementById('buzz2').play();
    $(selector).blur();
}