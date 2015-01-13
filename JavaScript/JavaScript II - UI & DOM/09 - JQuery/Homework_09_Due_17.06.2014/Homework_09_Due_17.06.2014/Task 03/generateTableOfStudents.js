(function () {
    var listOfStudents = [
    {
        'name': 'Peter',
        'surname': 'Ivanov',
        'grade': 3
    },
    {
        'name': 'Milena',
        'surname': 'Grigorova',
        'grade': 6
    },
    {
        'name': 'Gergana',
        'surname': 'Borisova',
        'grade': 12
    },
    {
        'name': 'Boyko',
        'surname': 'Petrov',
        'grade': 3
    }
    ];

    var $resultDiv = $('#result-div');
    var $table = $('<table>').addClass('centered');

    $table.appendTo($resultDiv);

    $thead = $('<thead>');
    $thead.appendTo($table);

    $theadRow = $('<tr>');
    $theadRow.appendTo($thead);

    $firstNameTitle = $('<th>').text('First name');
    $firstNameTitle.appendTo($theadRow);
    
    $lastNameTitle = $('<th>').text('Last name');
    $lastNameTitle.appendTo($theadRow);
    
    $gradeTitle = $('<th>').text('Grade');
    $gradeTitle.appendTo($theadRow);

    for (var i = 0; i < listOfStudents.length; i+=1) {
        $currentRow = $('<tr>');
        $currentRow.appendTo($table);

        $currentFirstName = $('<td>').text(listOfStudents[i].name);
        $currentFirstName.appendTo($currentRow);

        $currentSurname = $('<td>').text(listOfStudents[i].surname);
        $currentSurname.appendTo($currentRow);

        $currentGrade = $('<td>').text(listOfStudents[i].grade);
        $currentGrade.appendTo($currentRow);
    }
}());

