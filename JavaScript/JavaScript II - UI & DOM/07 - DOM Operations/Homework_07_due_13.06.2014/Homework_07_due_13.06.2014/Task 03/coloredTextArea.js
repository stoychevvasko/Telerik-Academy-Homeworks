/// 03. Create a text area and two inputs with type="color". 
/// * Make the font color of the text area as the value of the first color input. 
/// * Make the background color of the text area as the value of the second input.

(function () {
    document.getElementById('submit-button').onclick = solve;

    function solve() {        
        var fontColorInput = document.getElementById('font-color-input');
        var fontColor = fontColorInput.value;
        console.dir(fontColor);

        var backgroundColorInput = document.getElementById('background-color-input');        
        var backgroundColor = backgroundColorInput.value;
        console.dir(backgroundColor);

        var textarea = document.getElementById('the-text-area');
        textarea.style.color = fontColor;
        textarea.style.backgroundColor = backgroundColor;                
    }
}());

