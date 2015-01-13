/// 2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

console.log('Task 02 Solution\n');

console.log('numbers, simultaneously divisible by 7 and 5 without remainder:')

for (var i = 1; i < 350; i++) {
    if ((i % 7 == 0) && (i % 5 == 0)) {
        console.log(i);
    }    
}