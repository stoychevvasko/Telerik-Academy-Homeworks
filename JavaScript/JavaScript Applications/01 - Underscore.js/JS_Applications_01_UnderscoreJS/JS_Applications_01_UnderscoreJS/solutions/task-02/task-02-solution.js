$(document).ready(function () {
    var students = [
        { 'firstName': 'Ivan', 'lastName': 'Antonov', 'age': 23 },  // in range
        { 'firstName': 'Ivan', 'lastName': 'Ivanov', 'age': 21 },   // in range
        { 'firstName': 'Ivan', 'lastName': 'Petrov', 'age': 16 },   
        { 'firstName': 'Georgi', 'lastName': 'Antonov', 'age': 17 },
        { 'firstName': 'Georgi', 'lastName': 'Georgiev', 'age': 16 },
        { 'firstName': 'Georgi', 'lastName': 'Ivanov', 'age': 26 },
        { 'firstName': 'Petur', 'lastName': 'Antonov', 'age': 22 }, // in range
        { 'firstName': 'Petur', 'lastName': 'Petrov', 'age': 46 },
        { 'firstName': 'Petur', 'lastName': 'Todorov', 'age': 56 }
    ];
    console.log('Original array of students:');
    console.log(students);

    console.log('Array of students ages 18-24:');
    var youngAdultStudents = getFirstAndLastNameOfStudentsBetweenAges18And24(students);
    console.log(youngAdultStudents);
}());

function getFirstAndLastNameOfStudentsBetweenAges18And24(originalArray) {
    var studentsInAgeRange = _.filter(originalArray, isStudentAgeBetween18And24);
    var result = [];
    for (var i = 0, length = studentsInAgeRange.length; i < length; i += 1) {
        result.push({ "firstName": studentsInAgeRange[i].firstName, "lastName": studentsInAgeRange[i].lastName });
    };

    return result;
}

function isStudentAgeBetween18And24(student) {
    var result = true;
    if (student.age < 18) {
        result = false;
    }

    if (student.age > 24) {
        result = false;
    }

    return result;
}