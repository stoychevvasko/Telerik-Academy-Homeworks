///1. Write functions for working with shapes in standard Planar coordinate system. 
///*  Points are represented by coordinates P(X, Y)
///*  Lines are represented by two points, marking their beginning and ending e.g. L(P1(X1, Y1), P2(X2, Y2))
///*  Calculate the distance between two points
///*  Check if three segment lines can form a triangle

var x1, y1,
    x2, y2,
    x3, y3,
    point1,
    point2,
    point3;

function solve() {
    readInput();
    buildPoints();
    printResult();
}

function buildPoint(xCoord, yCoord) {
    return {
        x: xCoord,
        y: yCoord,
        toString: function() {
            return ('(' + this.x + ', ' + this.y + ') ');
        }
    }
}

function readInput() {
    x1 = parseFloat(document.getElementById('x1-entry').value);
    y1 = parseFloat(document.getElementById('y1-entry').value);
    x2 = parseFloat(document.getElementById('x2-entry').value);
    y2 = parseFloat(document.getElementById('y2-entry').value);
    x3 = parseFloat(document.getElementById('x3-entry').value);
    y3 = parseFloat(document.getElementById('y3-entry').value);
}

function buildPoints() {
    point1 = buildPoint(x1, y1);
    point2 = buildPoint(x2, y2);
    point3 = buildPoint(x3, y3);
}

function calculateDistanceBetweenTwoPoints(point1, point2) {
    var distance = Math.sqrt((point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y));
    return distance;
}

function canThreePointsFormALine(point1, point2, point3) {
    if (point1.x === point2.x && point2.x === point3.x && point1.y === point2.y && point2.y === point3.y) {
        return 'triplet merging points';
    } else {
        var distance12 = calculateDistanceBetweenTwoPoints(point1, point2);
        var distance13 = calculateDistanceBetweenTwoPoints(point1, point3);
        var distance23 = calculateDistanceBetweenTwoPoints(point2, point3);
        if (distance12 + distance23 === distance13 || distance23 + distance13 === distance12 || distance12 + distance13 === distance23) {
            return 'yes';
        } else {
            return 'no (they form a triangle)';
        }
    }
}

function printResult() {
    document.getElementById('result').innerHTML =
        'You entered:\npoint1 = ' + point1.toString() + '\npoint2 = ' + point2.toString() + '\npoint3 = ' + point3.toString() +
        '\nDistance (point1->point2): ' + calculateDistanceBetweenTwoPoints(point1, point2) +
        '\nCan form a line?: ' + canThreePointsFormALine(point1, point2, point3);
}

