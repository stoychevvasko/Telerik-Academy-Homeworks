///08. Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

var source;

function solve() {
    source = document.getElementById('string-entry').value;
    source = replaceLinks(source);
    document.getElementById('result').innerHTML = source;
}

function replaceLinks(text) {
    while (text !== text.replace('<a href=', '[URL=') && text !== text.replace('</a>', '[/URL]')) {
        text = text.replace('<a href=', '[URL=');
        text = text.replace('</a>', '[/URL]');
    }

    text = text.split('[URL=');

    for (var i = 0; i < text.length; i+=1) {
        text[i] = text[i].replace('>', ']');
    }

    text = text.join('[URL=');

    return text;
}



