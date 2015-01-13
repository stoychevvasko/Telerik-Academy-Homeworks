/// 9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

console.log('Task 09 Solution\n');

// point to check
var pointX = 2;
var pointY = 2;

// circle
var centerX = 1;
var centerY = 1;
var radius = 3;

// "boolean" expressions
var isPointWithinCircle = (((pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY)) < (radius * radius));
var isPointOutsideRectangle = !((pointX > -1 && pointX < 5) && (pointY < 1 && pointY > -1));
var result = (isPointWithinCircle && isPointOutsideRectangle);

// print result
console.log('Point (' + pointX + ', ' + pointY + ') is within the circle? [' + isPointWithinCircle + ']     is out of the rectangle? [' + isPointOutsideRectangle + ']');
console.log('Point (' + pointX + ', ' + pointY + ') ' + (result ? 'meets ' : 'does not meet ') + 'the requirements of this task.');
