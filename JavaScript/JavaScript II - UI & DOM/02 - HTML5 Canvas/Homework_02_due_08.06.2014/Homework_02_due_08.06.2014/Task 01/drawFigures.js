/// 01. Draw the following graphics using canvas:

(function () {
    drawFigures();

    function drawElipse(context, centerX, centerY, horizontalRadius, verticalRadius) {
        context.beginPath();
        context.moveTo(centerX - horizontalRadius, centerY);
        context.bezierCurveTo(centerX - horizontalRadius, centerY + verticalRadius, centerX + horizontalRadius, centerY + verticalRadius, centerX + horizontalRadius, centerY);
        context.bezierCurveTo(centerX + horizontalRadius, centerY - verticalRadius, centerX - horizontalRadius, centerY - verticalRadius, centerX - horizontalRadius, centerY);
    }

    function drawFigures() {
        var canvas = document.getElementById('the-canvas');
        var canvasContext = canvas.getContext('2d');
        canvasContext.lineWidth = '2';

        // draw the man with the hat
        drawHatMan(canvasContext);

        // draw the bicycle
        drawBicycle(canvasContext);

        // draw the house
        drawHouse(canvasContext);

        function drawHatMan(context) {
            context.fillStyle = 'rgb(144, 202, 215)';
            context.strokeStyle = 'rgb(52, 131, 150)';

            drawFace(context);
            drawHat(context);

            function drawFace(context) {
                context.fillStyle = 'rgb(144, 202, 215)';
                context.strokeStyle = 'rgb(52, 131, 150)';
                                
                drawElipse(context, 140, 185, 46, 45);
                context.fill();
                context.stroke();

                drawEye(context, 110, 175);
                drawEye(context, 150, 175);

                drawElipse(context, 130, 207, 20, 10);                
                context.stroke();

                context.beginPath();
                context.moveTo(130, 175);
                context.lineTo(120, 195);
                context.lineTo(130, 195);
                context.stroke();

                function drawEye(context, x, y) {
                    context.fillStyle = 'rgb(144, 202, 215)';
                    drawElipse(context, x, y, 8, 6);
                    context.fill();
                    context.stroke();

                    drawElipse(context, x - 2, y, 2, 5);
                    context.fillStyle = 'rgb(52, 131, 150)';
                    context.fill();
                    context.stroke();
                }
            }

            function drawHat(context) {
                context.fillStyle = 'rgb(57, 102, 147)';
                context.strokeStyle = 'rgb(0, 0, 0)';

                drawElipse(context, 140, 150, 55, 15);
                context.fill();
                context.stroke();

                drawElipse(context, 140, 145, 25, 10);
                context.fill();
                context.stroke();

                context.fillRect(115, 90, 50, 55);
                context.strokeRect(115, 90, 50, 55);

                drawElipse(context, 140, 90, 25, 10);
                context.fill();
                context.stroke();
                drawElipse(context, 140, 145, 24, 9);
                context.fill();
            }
        }

        function drawBicycle(context) {
            context.fillStyle = 'rgb(144, 202, 215)';
            context.strokeStyle = 'rgb(52, 131, 150)';

            drawWheel(context, 95, 340);
            drawWheel(context, 250, 340);
            drawFrame(context);

            function drawFrame(context) {
                context.beginPath();
                context.moveTo(95, 340);
                context.lineTo(145, 290);
                context.lineTo(240, 290);
                context.lineTo(165, 340);
                context.closePath();
                context.stroke();

                context.beginPath();
                context.moveTo(115, 270);
                context.lineTo(150, 270);
                context.moveTo(130, 270);
                context.lineTo(165, 340);
                context.stroke();

                context.beginPath();
                context.moveTo(250, 340);
                context.lineTo(235, 260);
                context.lineTo(205, 270);
                context.moveTo(235, 260);
                context.lineTo(260, 235);
                context.stroke();

                context.beginPath();
                context.arc(165, 340, 10, 0, 2 * Math.PI);
                context.stroke();

                context.beginPath();
                context.moveTo(150, 320);
                context.lineTo(158, 331);
                context.moveTo(172, 348);
                context.lineTo(179, 356);
                context.stroke();
            }

            function drawWheel(context, centerX, centerY) {
                context.beginPath();
                context.arc(centerX, centerY, 42, 0, 2 * 3.14159265359);
                context.fill();
                context.stroke();
            }
        }

        function drawHouse(context) {
            drawRoof(context, 380, 165);

            context.fillRect(380, 165, 195, 150);
            context.strokeRect(380, 165, 195, 150);

            drawWindow(context, 400, 185);
            drawWindow(context, 495, 185);
            drawWindow(context, 495, 245);

            drawDoor(context, 400, 315);

            function drawRoof(context, bottomLeftX, bottomLeftY) {
                context.fillStyle = 'rgb(150, 90, 90)';
                context.strokeStyle = 'rgb(0, 0, 0)';
                context.beginPath();
                context.moveTo(bottomLeftX, bottomLeftY);
                context.lineTo(bottomLeftX + 95, bottomLeftY - 105);
                context.lineTo(bottomLeftX + 195, bottomLeftY);
                context.closePath();
                context.fill();
                context.stroke();
                context.beginPath();
                context.moveTo(515, 140);
                context.lineTo(515, 85);
                context.lineTo(535, 85);
                context.lineTo(535, 140);
                context.fill();
                context.stroke();
                context.beginPath();
                context.moveTo(515, 85);
                context.bezierCurveTo(515, 90, 535, 90, 535, 85);
                context.bezierCurveTo(515, 80, 515, 88, 515, 85);
                context.fill();
                context.stroke();
            }

            function drawWindow(context, xStart, yStart) {
                context.fillStyle = 'rgb(0, 0, 0)';
                context.fillRect(xStart, yStart, 60, 40);

                context.strokeStyle = 'rgb(150, 90, 90)';
                context.beginPath();
                context.moveTo(xStart, yStart + 20);
                context.lineTo(xStart + 60, yStart + 20);
                context.moveTo(xStart + 30, yStart);
                context.lineTo(xStart + 30, yStart + 40);
                context.stroke();
            }

            function drawDoor(context, bottomLeftX, bottomLeftY) {
                context.strokeStyle = 'rgb(0, 0, 0)';
                context.fillStyle = 'rgb(150, 90, 90)';
                context.beginPath();
                context.moveTo(bottomLeftX, bottomLeftY);
                context.lineTo(bottomLeftX, bottomLeftY - 45);
                context.bezierCurveTo(bottomLeftX, bottomLeftY - 65, bottomLeftX + 55, bottomLeftY - 65, bottomLeftX + 55, bottomLeftY - 45);
                context.lineTo(bottomLeftX + 55, bottomLeftY);
                context.stroke();

                context.beginPath();
                context.moveTo(bottomLeftX + 27.5, bottomLeftY - 60);
                context.lineTo(bottomLeftX + 27.5, bottomLeftY);
                context.stroke();

                context.beginPath();
                context.moveTo(420, 295);
                context.arc(420, 295, 3, 0, 2 * 3.14159265359);
                context.stroke();
                context.stroke();
                context.stroke();
                context.fill();

                context.beginPath();
                context.arc(435, 295, 3, 0, 2 * 3.14159265359);
                context.stroke();
                context.stroke();
                context.stroke();
                context.fill();
            }
        }
    }    
}());

