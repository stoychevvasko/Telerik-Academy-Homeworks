$(document).ready(function () {
    var students = [
        { 'firstName': 'Ivan', 'lastName': 'Antonov', 'age': 23, 'marks': 5.00 },  
        { 'firstName': 'Ivan', 'lastName': 'Ivanov', 'age': 21, 'marks': 4.75 },   
        { 'firstName': 'Ivan', 'lastName': 'Petrov', 'age': 16, 'marks': 5.00 },
        { 'firstName': 'Georgi', 'lastName': 'Antonov', 'age': 17, 'marks': 3.50 },
        { 'firstName': 'Georgi', 'lastName': 'Georgiev', 'age': 16, 'marks': 6.00 }, // highest marks
        { 'firstName': 'Georgi', 'lastName': 'Ivanov', 'age': 26, 'marks': 5.75 },
        { 'firstName': 'Petur', 'lastName': 'Antonov', 'age': 22, 'marks': 5.50 }, 
        { 'firstName': 'Petur', 'lastName': 'Petrov', 'age': 46, 'marks': 4.00 },
        { 'firstName': 'Petur', 'lastName': 'Todorov', 'age': 56, 'marks': 2.00 }
    ];
    console.log('Original array of students:');
    console.log(students);

    console.log('Student with the highest marks:');
    var topStudent = getStudentWithHighestMarks(students);
    console.log(topStudent);
}());

function getStudentWithHighestMarks(students) {
    var studentsSortedByMarks = _.sortBy(students, 'marks').reverse();
    return studentsSortedByMarks[0];
}