function printDistances([x1,y1,x2,y2]) {

    function isValidDistance(x1, y1, x2, y2) {
        if (isDistanceInteger(x1, y1, x2, y2)) {
            return `{${x1}, ${y1}} to {${x2}, ${y2}} is valid`;
        }

        return `{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`;
    }

    console.log(isValidDistance(x1, y1, 0, 0));
    console.log(isValidDistance(x2, y2, 0, 0));
    console.log(isValidDistance(x1, y1, x2, y2));

    function isDistanceInteger(x1, y1, x2, y2) {
        let distance = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));
        return distance === parseInt(distance.toString(), 10);
    }
}

printDistances([2, 1, 1, 1]);
