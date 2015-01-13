$(document).ready(function () {
    (function () {
        function hideAllEntries() {
            $('div#wrapper #line-entry').addClass('hidden');
            $('div#wrapper #rect-entry').addClass('hidden');
            $('div#wrapper #circle-entry').addClass('hidden');
        }

        // rect entry navigation
        $('div#wrapper #add-rect').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
            $('div#wrapper #rect-entry').removeClass('hidden');
        });

        $('div#wrapper #cancel-rect').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
        });

        $('div#wrapper #submit-rect').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
            var value = readRectEntries();
            canvasModule.rect(value[0], value[1], value[2], value[3]);
        });

        function readRectEntries() {
            var x = parseFloat($('div#wrapper #rect-x').val());
            var y = parseFloat($('div#wrapper #rect-y').val());
            var width = parseFloat($('div#wrapper #rect-width').val());
            var height = parseFloat($('div#wrapper #rect-height').val());
            var result = [x, y, width, height];
            return result;
        }

        // circle entry navigation
        $('div#wrapper #add-circle').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
            $('div#wrapper #circle-entry').removeClass('hidden');
        });

        $('div#wrapper #cancel-circle').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
        });

        $('div#wrapper #submit-circle').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
            $('div#wrapper #circle-entry').addClass('hidden');
            var value = readCircleEntries();
            canvasModule.circle(value[0], value[1], value[2]);
        });

        function readCircleEntries() {
            var x = parseFloat($('div#wrapper #circle-x').val());
            var y = parseFloat($('div#wrapper #circle-y').val());
            var radius = parseFloat($('div#wrapper #circle-radius').val());
            var result = [x, y, radius];
            return result;
        }

        // line entry navigation
        $('div#wrapper #submit-line').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
            $('div#wrapper #line-entry').addClass('hidden');
            var value = readLineEntries();            
            canvasModule.line(value[0], value[1], value[2], value[3]);
        });

        $('div#wrapper #cancel-line').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
        });

        $('div#wrapper #add-line').click(function () {
            document.getElementById('buzz').play();
            hideAllEntries();
            $('div#wrapper #line-entry').removeClass('hidden');            
        });

        function readLineEntries() {
            var x1 = parseFloat($('div#wrapper #line-x1').val());
            var y1 = parseFloat($('div#wrapper #line-y1').val());
            var x2 = parseFloat($('div#wrapper #line-x2').val());
            var y2 = parseFloat($('div#wrapper #line-y2').val());
            var result = [x1, y1, x2, y2];            
            return result;
        }

        // clear canvas
        $('div#wrapper #clear').click(function () {
            document.getElementById('buzz').play();
            canvasModule.clear();
        });
    }());

    var canvasModule = (function () {
        var canvas = document.getElementById('the-canvas');
        var context = canvas.getContext('2d');
        context.strokeStyle = '#a2e0ff';
        context.strokeWidth = '20px';

        function rect(x, y, width, height) {
            context.strokeRect(x, y, width, height);
        }

        function circle(x, y, radius) {
            context.beginPath();
            context.arc(x, y, radius, 0, 2 * Math.PI);
            context.stroke();
        }

        function line(x1, y1, x2, y2) {
            context.beginPath();
            context.moveTo(x1, y1);
            context.lineTo(x2, y2);
            context.stroke();
        }

        function clear() {
            context.clearRect(0,0,400,300);
        }

        return {
            rect: rect,
            circle: circle,
            line: line,
            clear: clear
        };
    })();
});