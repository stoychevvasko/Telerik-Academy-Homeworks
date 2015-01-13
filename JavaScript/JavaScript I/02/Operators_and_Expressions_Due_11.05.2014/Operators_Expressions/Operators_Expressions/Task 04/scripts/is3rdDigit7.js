/// 4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

console.log('Task 04 Solution\n');

for (var i = 9000; i < 11000; i++) {
    var stringI = i.toString();
    var expression = (stringI.length >= 3) && ((stringI.charAt(stringI.length - 3)) === '7');
    if (expression) {
        console.log(i + ' has 7 as its third digit (counting right-to-left).')
    }
}

