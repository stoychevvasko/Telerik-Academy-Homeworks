/// 5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

console.log('Task 05 Solution\n');

for (var i = 0; i < 22; i++) {
    var isThirdBit1 = (((i >> 2) & 1) > 0);
    console.log(i + ' (dec) / ' + i.toString(2) + ' (bin) has ' +
        (isThirdBit1 ? '1' : '0') + ' as its third bit. isThirdBit1 = ' + isThirdBit1);
}

