/// 8. Write an expression that calculates trapezoid's area by given sides a and b and height h.

console.log('Task 08 Solution\n');

// trapezoid
var sideA = 5.0;
var sideB = 10.0;
var height = 7.25;

// surface area
var trapezoidArea = ((sideA + sideB) / 2.0) * height;

// print results
if (trapezoidArea <= 0) {
    console.log('ERROR! Invalid parameters')
}
else {
    console.log('Trapezoid:');
    console.log('sideA ' + sideA);
    console.log('sideB ' + sideB);
    console.log('height ' + height + '\n');
    console.log('trapezoidArea ' + trapezoidArea);
}