function stringFormat() {
        if (arguments.length === 0) {
            return undefined;
        }

        var formatted = String(arguments[0]);

        for (var i = 1; i < arguments.length; i++) {
            var replaceString = '{' + (i - 1) + '}';
            while (formatted.indexOf(replaceString) > -1) {
                formatted = formatted.replace(replaceString, arguments[i]);
            }
        }

        return formatted;
    }