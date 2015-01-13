///5. Write a function that finds the youngest person in a given array of persons and prints his/her full name. Each person has properties firstname, lastname and age

var student1,
    student2,
    student3, 
    student4,
    student5,
    
    allStudents = [];

function solve() {
    initializeStudents();
    document.getElementById('result').innerHTML =
        'The youngest student is ' + findYoungestStudent(allStudents);
}

function initializeStudents() {
    student1 = buildStudent('Ivan', 'Ivanov', 40);
    student2 = buildStudent('Pesho', 'Peshov', 19);
    student3 = buildStudent('Gosho', 'Goshov', 25);
    student4 = buildStudent('Mimi', 'Mimeva', 31);
    student5 = buildStudent('Lili', 'Lilieva', 23);

    allStudents.push(student1, student2, student3, student4, student5);
}

function buildStudent(fname, lname, age) {
    return {
        fname: fname, 
        lname: lname,
        age: age,
        toString: function (){return this.fname + ' ' + this.lname;}
    }
}

function findYoungestStudent(studentArray) {
    var youngestStudent,
        minAge = studentArray[0].age,
        minAgeIndex = 0,
        agesArray;

    for (var i = 0; i < studentArray.length; i+=1) {
        if (minAge > studentArray[i].age) {
            minAge = studentArray[i].age;
            minAgeIndex = i;
        }
    }

    youngestStudent = studentArray[minAgeIndex];

    return youngestStudent;
}