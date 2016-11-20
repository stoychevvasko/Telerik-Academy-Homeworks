$(document).ready(function () {
    $('section').css({ 'border-color': '#000' });
    //$(elementSelector).fadeTo(0, Math.random(), function () { }).delay(66).fadeTo(Math.random() * 66, 1, function () { });

    var tasksNavigationTemplateNode = document.getElementById('task-navigation-template'),
        tasksNavigationTemplateHtml = tasksNavigationTemplateNode.innerHTML,
        tasksNavigationTemplate = Handlebars.compile(tasksNavigationTemplateHtml);

    document.getElementById('task-navigation-entries').innerHTML = tasksNavigationTemplate({ allHomeworkTasks: allHomeworkTasks });    

    $('#homework-title').on('click', function () {
        blinkSingleElement('#homework-title');
    });

    $('#dashboard-pic').on('click', function () {
        var randomImageSource = allBoxImages[getRandomIntegerInRange(0, allBoxImages.length - 1)];

        while ($('#dashboard-pic').attr('src') === randomImageSource) {
            randomImageSource = allBoxImages[getRandomIntegerInRange(0, allBoxImages.length - 1)];
        }
        blinkSingleElement('#dashboard-pic');
        $('#dashboard-pic').attr('src', randomImageSource);
    });

    $('#additional-info').on('click', function () {
        blinkSingleElement('#additional-info');
    });

    $('#navigation').on('click', function () {
        blinkSingleElement('#navigation');
    });

    $('#footer').on('click', function () {
        blinkSingleElement('#footer');
    });


    for (var j = 1; j <= allHomeworkTasks.length; j += 1) {
        var i = j;
        var p = i;
        $('div#task-navigation-entries>span:nth-of-type(' + i + ')').on('mouseenter', function () {
            $('section article p').html(allHomeworkTasks[parseInt(this.id) - 1].description);
            //console.log(allHomeworkTasks[parseInt(this.id) - 1].description);
            $('section').css({ 'border-color': '#a2e0ff' });
            document.getElementById('buzz').play();
        });

        $('div#task-navigation-entries>span:nth-of-type(' + i + ')').on('mouseout', function () {
            $('section article p').html('');
            $('section').css({ 'border-color': '#000' });
        });
    }
});

function blinkSingleElement(elementSelector) {
    for (var i = 0; i < 3; i += 1) {
        $(elementSelector).fadeTo(0, Math.random(), function () { }).delay(66).fadeTo(Math.random() * 66, 1, function () { });
    }
    document.getElementById('buzz').play();
};

function getRandomIntegerInRange(min, max) {
    return Math.floor(Math.random() * (max + 1 - min) + min);
}