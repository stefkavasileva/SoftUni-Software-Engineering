let manipulateVectors = (function () {
    return {
        add: function (firstVector,secondVector) {
            let x1 = firstVector[0];
            let y1 = firstVector[1];
            let x2 = secondVector[0];
            let y2 = secondVector[1];

            return [x1 + x2, y1 + y2];
        },
        multiply: function (firstVector, scalar) {
            let x = firstVector[0];
            let y = firstVector[1];

            return [x * scalar, y * scalar];
        },
        length: function (firstVector) {
            let x = firstVector[0];
            let y = firstVector[1];

            return Math.sqrt((x * x) + (y * y));
        },
        dot: function (firstVector, secondVector) {
            let x1 = firstVector[0];
            let y1 = firstVector[1];
            let x2 = secondVector[0];
            let y2 = secondVector[1];

            return (x1 * x2) + (y1 * y2);
        },
        cross: function (firstVector, secondVector) {
            let x1 = firstVector[0];
            let y1 = firstVector[1];
            let x2 = secondVector[0];
            let y2 = secondVector[1];

            return (x1 * y2) - (y1 * x2)
        }
    }
})();

console.log(manipulateVectors.dot([2, 3], [2, -1]));;