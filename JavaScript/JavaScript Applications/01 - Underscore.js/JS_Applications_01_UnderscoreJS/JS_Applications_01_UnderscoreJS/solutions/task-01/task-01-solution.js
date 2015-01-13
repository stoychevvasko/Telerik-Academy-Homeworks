$(document).ready(function () {
    var students = [
        { 'firstName': 'Ivan', 'lastName': 'Antonov' },
        { 'firstName': 'Ivan', 'lastName': 'Ivanov' },
        { 'firstName': 'Ivan', 'lastName': 'Petrov' },
        { 'firstName': 'Georgi', 'lastName': 'Antonov' },
        { 'firstName': 'Georgi', 'lastName': 'Georgiev' },
        { 'firstName': 'Georgi', 'lastName': 'Ivanov' },
        { 'firstName': 'Petur', 'lastName': 'Antonov' },
        { 'firstName': 'Petur', 'lastName': 'Petrov' },
        { 'firstName': 'Petur', 'lastName': 'Todorov' }
    ];

    console.log('Original array of students:');
    console.log(students);

    var studentsWithFirstNameBeforeLastNameAlphabetically = _.filter(students, isFirstNameBeforeLastNameAlphabetically);
    var sortedResult = _.sortBy(studentsWithFirstNameBeforeLastNameAlphabetically, getFullName);

    console.log('Array of students with first name before last name in descending order:');
    console.log(sortedResult);

    var resultReversed = sortedResult.reverse();
    console.log('Array of students with first name before last name in ascending order:');
    console.log(resultReversed);
}());

function isFirstNameBeforeLastNameAlphabetically(student) {
    var result = false;
    if (student.firstName < student.lastName) {
        result = true;
    }
    return result;
}

function getFullName(student) {
    return student.firstName + ' ' + student.lastName;
}
