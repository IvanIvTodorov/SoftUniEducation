(function solve() {

    String.prototype.ensureStart = function (input) {
        if (!this.toString().startsWith(input)) {
            return input + this.toString();
        };
        return this.toString();
    };

    String.prototype.ensureEnd = function (input) {
        if (!this.toString().endsWith(input)) {
            return this.toString() + input;
        };
        return this.toString();
    };

    String.prototype.isEmpty = function () {
        if (this.toString().length  == 0) {
            return true;
        };

        return false;
    };

    String.prototype.truncate = function(n) {

        if(Number(n) < 4) {

            return ".".repeat(Number(n));

        }

        if (Number(n) >= this.length) {
                
            return this.toString();

        }
        
        let lastWhitespace = this.toString().substring(0, n - 2).lastIndexOf(" ");

        return lastWhitespace !== -1 
            ? `${this.toString().substring(0, lastWhitespace)}...` 
            : `${this.toString().substring(0, n - 3)}...`;
        
    }

    String.format = function (string, ...params) {

        for (let i = 0; i < params.length; i++) {
            string = string.replace(`{${i}}`, params[i]);
        }

        return string;
    };

})();