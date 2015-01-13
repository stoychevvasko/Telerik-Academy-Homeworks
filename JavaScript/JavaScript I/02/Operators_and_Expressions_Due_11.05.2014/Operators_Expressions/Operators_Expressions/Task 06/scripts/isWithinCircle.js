/// 6. Write an expression that checks if a given point (x,  y) is within a circle K(O, 5).

console.log('Task 06 Solution\n');

// point to check
var pointX = 5;
var pointY = 0;

// circle
var centerX = 0;
var centerY = 0;
var radius = 5;

// "boolean" expressions
var isPointWithinCircle = (((pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY)) < (radius * radius));
var isPointOnCircle = (((pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY)) == (radius * radius));
var isPointOutOfCircle = (((pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY)) > (radius * radius));

// print results
console.log('Is point (' + pointX + ', ' + pointY + ') IN circle K((' + centerX + ', ' + centerY + '), ' + radius + ')? ==> ' + isPointWithinCircle);
console.log('Is point (' + pointX + ', ' + pointY + ') ON circle border K((' + centerX + ', ' + centerY + '), ' + radius + ')? ==> ' + isPointOnCircle);
console.log('Is point (' + pointX + ', ' + pointY + ') OUT of circle K((' + centerX + ', ' + centerY + '), ' + radius + ')? ==> ' + isPointOutOfCircle);
