(function extensionArray() {
    Array.prototype.last = function () {
        return this[this.length - 1];
    };

    Array.prototype.skip = function( count) {
        return this.slice(count);
    };

    Array.prototype.take = function (count) {
        return this.slice(0,count + 1);
    };

    Array.prototype.sum = function () {
       return this.reduce((a,b) => a + b);
    };

    Array.prototype.average = function () {
        return this.reduce((a,b) => a + b) / this.length;
    }
})();


