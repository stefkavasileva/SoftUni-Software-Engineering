let getSum = (function () {
    let sum = 0;
    return function add(num) {
        sum += num;
        add.toString = function () {
            return sum;
        };
        return add;
    }
})();

console.log(getSum(1)(5)(-1).toString());;

