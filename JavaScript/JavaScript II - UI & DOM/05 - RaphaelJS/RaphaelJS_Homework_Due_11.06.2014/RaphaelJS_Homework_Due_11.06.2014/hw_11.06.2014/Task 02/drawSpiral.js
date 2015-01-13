/// 02. Create a spiral with Raphael. Hint: use many circles with radius 1px

(function () {
    console.log('Task 02 - draw spiral');

    var paper = Raphael('svg-container-task02-spiral', 400, 300);
    paper.setStart();
    drawSpiral();
    var completeSpiral = paper.setFinish();
    completeSpiral.attr(
        {
            stroke: '#ffffff',
            'stroke-width': 2,
            fill: 'none'
        });

    function drawSpiral() {        
        function drawSpiral(centerX, centerY, a, b) {
            var centralPoint = "M" + centerX + ' ' + centerY,
                spiralPoints = [centralPoint];

            for (var i = 0; i < 720; i++) {
                var angle = 0.1 * i,            
                    x = centerX + (a + b * angle) * Math.cos(angle),
                    y = centerY + (a + b * angle) * Math.sin(angle);

                spiralPoints.push('L ' + x + ' ' + y);

            }
            var spiralPointsString = spiralPoints.join(' '),
            spiral = paper.path(spiralPointsString);
        }
        drawSpiral(250, 150, 0, 2);
    }
}());