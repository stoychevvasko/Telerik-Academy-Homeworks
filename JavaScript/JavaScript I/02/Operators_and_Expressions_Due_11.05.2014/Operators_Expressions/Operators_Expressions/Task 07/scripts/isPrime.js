/// 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

console.log('Task 07 Solution\n');

// "boolean" expression
var isPrime = true;

for (var i = 1; i < 101; i++) {
    isPrime = !((i == 1) || ((i % 2 == 0) && (i != 2)) || ((i % 3 == 0) && (i != 3)) || ((i % 5 == 0) && (i != 5)) || ((i % 7 == 0) && (i != 7)));
    console.log(i + ' prime? ' + isPrime);
}
