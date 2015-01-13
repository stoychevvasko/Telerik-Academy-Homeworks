/// 03. Create a text area and two inputs with type="color". 
/// * Make the font color of the text area as the value of the first color input. 
/// * Make the background color of the text area as the value of the second input.

(function () {
    document.getElementById('submit-button').onclick = solve;

    function solve() {
        var tags = ["cms", "javascript", "javascript", "javascript", "javascript", "javascript", "javascript","javascript", "javascript", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];
        var div = document.getElementById('tags');
        div.style.width = 200 + 'px';
        var tagCloud = generateTagCloud(tags, 17, 42);

        function generateTagCloud(tags, minFontSize, maxFontSize) {
            var counterArr = [];

            for (var i = 0; i < tags.length; i += 1) {
                var count = 0;

                for (var c = i + 1; c < tags.length; c += 1) {
                    if (tags[i].toLowerCase() == tags[c].toLowerCase()) {
                        count+=1;
                        tags.splice(c, 1);
                        c--;
                    }
                }

                counterArr.push(count);
            }

            for (var i = 0; i < tags.length; i += 1) {
                console.log(counterArr[i]);
                var result = document.createElement('span');
                result.style.fontSize = counterArr[i] <= 0 ? minFontSize : (counterArr[i] >= maxFontSize ? maxFontSize : minFontSize + counterArr[i] * 2) + 'px';
                result.appendChild(document.createTextNode(tags[i] + ' '));
                div.appendChild(result);
            }

            return false;
        }


    }
}());