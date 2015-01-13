/// 1. Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

var array = [];

for (var i = 0; i < 20; i++) {
    array[i] = i * 5;    
}

console.log(array);