function buildStringBuilder() {
		    return {
		        string: [],
		        length: 0,
		        append: function (stringArgument) {
		            this.string[this.length++] = stringArgument;
		            return this;
		        },
		        toString: function () {
		            return this.string.join('');
		        }
		    };