$(document).ready(function () {
    //blinkTaskElements(66);

    $('#task-title').on('click', function () {
        blinkSingleElement('#task-title');
    });

    $('#back-button').on('click', function () {
        blinkSingleElement('#back-button');
    });

    $('#default-instructions').on('click', function () {
        blinkSingleElement('#default-instructions');
    });
});

function blinkTaskElements(interval) {
    for (var i = 0; i < Math.random() * 12 + 1; i += 1) {
        $('#task-title').fadeTo(0, Math.random(), function () { }).delay(interval).fadeTo(Math.random() * interval, 1, function () {
            $('#default-instructions').fadeTo(0, Math.random(), function () { }).fadeTo(Math.random() * interval, 1, function () {
                $('#back-button').fadeTo(0, Math.random(), function () { }).fadeTo(Math.random() * interval, 1, function () { });
            });
        });
    }
}
