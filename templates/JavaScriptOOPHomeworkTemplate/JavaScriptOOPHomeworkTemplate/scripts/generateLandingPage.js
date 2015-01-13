var allHomeworkTasks = [
    {
        'number': 1,
        'description': '<strong>Lorem ipsum dolor sit amet,</strong> consectetur adipisicing <em>elit</em>, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
        'link': 'solutions/task-01/task-01.html'
    },
    {
        'number': 2,
        'description': '<strong>Ut enim ad minim veniam,</strong> quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.',
        'link': 'solutions/task-01/task-01.html'
    },
    {
        'number': 3,
        'description': '<strong>Duis aute irure dolor</strong> in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.',
        'link': 'solutions/task-01/task-01.html'
    },
    {
        'number': 4,
        'description': '<strong>Excepteur sint occaecat</strong> cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
        'link': 'solutions/task-01/task-01.html'
    },
    {
        'number': 5,
        'description': '<strong>Lorem ipsum dolor sit amet,</strong> consectetur adipisicing <em>elit</em>, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
        'link': 'solutions/task-01/task-01.html'
    },
];

$(document).ready(function () {
    var tasksNavigationTemplateNode = document.getElementById('task-navigation-template'),
        tasksNavigationTemplateHtml = tasksNavigationTemplateNode.innerHTML,
        tasksNavigationTemplate = Handlebars.compile(tasksNavigationTemplateHtml);

    document.getElementById('task-navigation-entries').innerHTML = tasksNavigationTemplate({ allHomeworkTasks: allHomeworkTasks });

    blinkElements(66);

    $('#homework-title').on('click', function () {
        blinkSingleElement('#homework-title');
    });

    $('#dashboard-pic').on('click', function () {
        blinkSingleElement('#dashboard-pic');
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
            console.log(allHomeworkTasks[parseInt(this.id) - 1].description);
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
    for (var i = 0; i < Math.random() * 2 + 1; i += 1) {
        $(elementSelector).fadeTo(0, Math.random(), function () { }).delay(66).fadeTo(Math.random() * 66, 1, function () { });
    }
    document.getElementById('buzz').play();
};

function blinkElements(interval) {
    for (var i = 0; i < Math.random() * 5 + 1; i += 1) {
        $('#homework-title').fadeTo(0, Math.random(), function () { }).delay(interval).fadeTo(Math.random() * interval, 1, function () {
            $('#dashboard-pic').fadeTo(0, Math.random(), function () { }).fadeTo(Math.random() * interval, 1, function () {
                $('#additional-info').fadeTo(0, Math.random(), function () { }).fadeTo(Math.random() * interval, 1, function () {
                    $('#navigation').fadeTo(0, Math.random(), function () { }).fadeTo(Math.random() * interval, 1, function () {
                        $('#footer').fadeTo(0, Math.random(), function () { }).fadeTo(Math.random() * interval, 1, function () {
                            document.getElementById('buzz').play();
                        });
                    });
                });
            });
        });
    }
}