/// 02. Draw a circle that flies inside a box. When it reaches an edge, it should bounce that edge.

(function () {
    simulateCircleMotion();

    function simulateCircleMotion() {
        var canvas = document.getElementById('the-canvas'),
            context = canvas.getContext("2d"),
            centreX = 200,
            centreY = 100,
            radius = 19,
            start = 0,
            end = Math.PI * 2,
            arcValue = false,
            update = 4,
            updateX = update,
            updateY = update * -1;

        context.strokeStyle = 'rgb(255, 255, 255)';
        context.fillStyle = 'rgb(255, 255, 255)';
        context.lineWidth = '3';

        context.strokeRect(0, 0, 600, 400);
        context.stroke();

        requestAnimationFrame(moveCircle);

        function drawCircle(centreX, centreY, radius, start, end, arcValue) {
            context.beginPath();
            context.arc(centreX, centreY, radius, start, end, arcValue);
            context.fill();
        }

        function moveCircle() {
            context.clearRect(0, 0, context.canvas.width, context.canvas.height);
            context.strokeRect(0, 0, 600, 400);            
            drawCircle(centreX, centreY, radius, start, end, arcValue);

            if (centreX + radius >= 600) {
                updateX = update * -1;
            }
            if (centreY + radius >= 400) {
                updateY = update * -1;
            }

            if (centreX - radius <= 0) {
                updateX = update;
            }
            if (centreY - radius <= 0) {
                updateY = update;
            }

            centreX += updateX;
            centreY += updateY;

            requestAnimationFrame(moveCircle);
        }
    }
}());
