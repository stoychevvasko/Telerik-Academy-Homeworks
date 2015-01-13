///04. You are given a text. Write a function that changes the text in all regions:
/// <upcase>text</upcase> to uppercase.
/// <lowcase>text</lowcase> to lowercase
/// <mixcase>text</mixcase> to mix casing(random)

var originalText = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

function solve() {
    originalText = applyTags(originalText, '<upcase>', '</upcase>', applyUpCaseTags);
    originalText = applyTags(originalText, '<lowcase>', '</lowcase>', applyLowCaseTags);
    originalText = applyTags(originalText, '<mixcase>', '</mixcase>', applyMixCaseTags);
    var finalText = originalText;
    document.getElementById('result').innerHTML = finalText;
}

function removeAdditionalWhiteSpaces(text) {
    return text.replace(/\s{2,}/ig, ' ');
}

function removeAllTags(text) {
    return text.replace(/<.+?case>/ig, '');
}

function applyTags(text, openTagName, closeTagName, action) {
    var openTagIndexes = [];

    var lastOccurance = text.indexOf(openTagName), nextOpenTagIndex, nextCloseTagIndex, originalBlock, updateBlock;
    if (lastOccurance > -1) {
        openTagIndexes.push(lastOccurance);
    }

    while (openTagIndexes.length > 0) {

        lastOccurance = openTagIndexes[openTagIndexes.length - 1];
        nextOpenTagIndex = text.indexOf(openTagName, lastOccurance + openTagName.length);
        nextCloseTagIndex = text.indexOf(closeTagName, lastOccurance + openTagName.length);

        if (nextCloseTagIndex < nextOpenTagIndex || nextOpenTagIndex === -1) {
            originalBlock = text.substring(lastOccurance, nextCloseTagIndex + closeTagName.length);
            updateBlock = removeAllTags(originalBlock);
            updateBlock = removeAdditionalWhiteSpaces(updateBlock);
            updateBlock = action(updateBlock);


            text = text.replace(originalBlock, updateBlock);
            openTagIndexes.pop();

            if (nextOpenTagIndex !== -1 && openTagIndexes.length === 0) {
                openTagIndexes.push(text.indexOf(openTagName, lastOccurance + openTagName.length));
            }

        }
        else {
            openTagIndexes.push(nextOpenTagIndex);
        }
    }

    text = removeAdditionalWhiteSpaces(text).trim();
    return text;
}

function applyUpCaseTags(text) {
    return text.toUpperCase();
}

function applyLowCaseTags(text) {
    return text.toLowerCase();
}

function applyMixCaseTags(text) {
    var result = '', i, tmpRand;
    for (i = 0; i < text.length; ++i) {
        tmpRand = parseInt(Math.random() * 2);
        if (tmpRand === 0) {
            result += text[i].toUpperCase();
        }
        else {
            result += text[i].toLowerCase();
        }
    }
    return result;
}

