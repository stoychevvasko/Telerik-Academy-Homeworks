///6. Write a function that groups an array of persons by age, firstname or lastname. 
///The function must return an associative array, with keys - the groups, and values - 
///arrays with persons in these groups. Use function overloading (i.e. just one function).

var student1,
    student2,
    student3,
    student4,
    student5,

    allStudents = [],

    properties = ['fname', 'lname', 'age'],
    groups;

function solve() {
    initializeStudents();
    document.getElementById('result').innerHTML = 'Please check browser console for the results!\n\nUse the triangular arrows to check inside entries.';

    for (var i = 0; i < properties.length; i += 1) {
        groups = groupBy(allStudents, properties[i]);
        console.log('Grouped by ' + properties[i]);
        console.log(groups);
    }
}

function initializeStudents() {
    student1 = buildStudent('Pesho', 'Ivanov', 40);
    student2 = buildStudent('Pesho', 'Peshov', 19);
    student3 = buildStudent('Gosho', 'Goshov', 23);
    student4 = buildStudent('Mimi', 'Goshov', 31);
    student5 = buildStudent('Lili', 'Lilieva', 23);

    allStudents.push(student1, student2, student3, student4, student5);
}

function buildStudent(fname, lname, age) {
    return {
        fname: fname,
        lname: lname,
        age: age,
        toString: function () { return this.fname + ' ' + this.lname; }
    }
}

function groupStudents(students, property) {
    var array = new Array();

    for (var i = 0; i < students.length; i += 1) {
        if (array[students[property]] === undefined) {
            array[students[property]] = [];


        }
        array[students[property]].push(students[i]);
    }

    return array;
}

function groupBy(people, property) {
    switch (property) {
        case 'fname':
        case 'lname':
        case 'age':
            {
                var groups = {};

                people.map(function (currentElement) {
                    if (!groups[currentElement[property]]) {
                        groups[currentElement[property]] = new Array();
                    }
                    groups[currentElement[property]].push(currentElement);
                });

                return groups;
            }
        default:
            throw new Error('No such property');
    }
}








