(function () {
    $('#submit-button').on('click', updateBackgroundColor);

    function updateBackgroundColor() {
        var currentColor = $('[type=color]').val();
        $('body').css('background', currentColor);
    }
}());