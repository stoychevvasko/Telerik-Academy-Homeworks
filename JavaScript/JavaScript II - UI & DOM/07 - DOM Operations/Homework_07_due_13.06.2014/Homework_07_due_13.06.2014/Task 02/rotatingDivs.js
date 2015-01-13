/// 02. Write a script that creates 5 div elements and moves them in circular path with interval of 100 milliseconds

(function () {

    rotateDivs();
    
    function rotateDivs() {
        var divs = Array(5);

        for (var i = 0; i < divs.length; i += 1) {
            var currentDiv = document.createElement('div');
            currentDiv.innerHTML = 'div ' + (i + 1);
            currentDiv.style.position = 'absolute';
            document.body.appendChild(currentDiv);
            divs[i] = currentDiv;
        }

        var centerX = 900;
        var centerY = 200;
        var radius = 100;

        var angle = 0;

        var functionTimer = setInterval(function moveDivs() {
            angle -= 0.5;
            if (angle <= 0) {
                angle = 360;
            }

            for (var i = 0; i < divs.length; i += 1) {
                var addition = (360 / divs.length) * i;

                var left = centerX + Math.cos((2 * 3.14 / 180) * (angle + addition)) * radius;
                var right = centerY + Math.sin((2 * 3.14 / 180) * (angle + addition)) * radius;
                divs[i].style.left = left + 'px';
                divs[i].style.top = right + 'px';
            }
        }, 100);
    }
}());