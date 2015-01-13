/// 01. Write a script that creates a number of div elements. Each div element must have the following: 
/// * Random width and height between 20px and 100px
/// * Random background color, Random font color
/// * Random position on the screen (position:absolute)
/// * A strong element with text "div" inside the div
/// * Random border radius
/// * Random border color
/// * Random border width between 1px and 20px

(function () {
    var section = document.querySelector('section');
    createDivs();

    function createDivs() {
        var numberOfDivs = Math.floor((Math.random() * 15) + 5);
        
        for (var i = 0; i < numberOfDivs; i+=1) {
            createRandomDiv();            
        }
    }

    function createRandomDiv()
    {
        var div = document.createElement('div');
        
        div.style.height = Math.floor((Math.random() * 100) + 20) + 'px';        
        div.style.width = Math.floor((Math.random() * 100) + 20) + 'px';                   
        
        div.style.position = 'absolute';
        div.style.left = Math.floor((Math.random() * 500) + 650) + 'px';
        div.style.top = Math.floor((Math.random() * 300) + 1) + 'px';

        div.style.backgroundColor = randomColor();
        div.style.color = randomColor();        
        div.style.borderRadius = Math.floor((Math.random() * 20) + 1) + 'px';
        div.style.border = Math.floor((Math.random() * 20) + 1) + 'px solid ' + randomColor();
        div.innerHTML = '<strong>div</strong>';
        console.dir(div);
        section.appendChild(div);
    }
    
    function randomColor() {
        var red = Math.floor((Math.random() * 255) + 1);
        var green = Math.floor((Math.random() * 255) + 1);
        var blue = Math.floor((Math.random() * 255) + 1);
        return 'rgb(' + red + ', ' + green + ', ' + blue + ')';
    }
}());