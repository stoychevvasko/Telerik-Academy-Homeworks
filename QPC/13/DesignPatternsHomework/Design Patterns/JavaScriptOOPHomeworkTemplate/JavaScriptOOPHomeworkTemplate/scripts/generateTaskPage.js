﻿$(document).ready(function () {
    //blinkTaskElements(66);

    $('#task-title').on('click', function () {        
        resetDisplay('#task-title');
    });

    $('#back-button').on('click', function () {                
        resetDisplay('#back-button');
    });

    $('#observer').on('click', function () {        
        resetDisplay('#observer');
        $('#wrapper').html(observerDescription);
    });

    $('#builder').on('click', function () {        
        resetDisplay('#builder');
        $('#wrapper').html(builderDescription);
    });

    $('#parcer').on('click', function () {        
        resetDisplay('#parcer');
        $('#wrapper').html(parcerDescription);
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

function blinkSingleElement(elementSelector) {
    for (var i = 0; i < Math.random() * 2 + 1; i += 1) {
        $(elementSelector).fadeTo(0, Math.random(), function () { }).delay(66).fadeTo(Math.random() * 66, 1, function () { });
    }
    document.getElementById('buzz2').play();
};

function resetDisplay(selector) {
    blinkSingleElement(selector);
    $('#wrapper').html('');
}