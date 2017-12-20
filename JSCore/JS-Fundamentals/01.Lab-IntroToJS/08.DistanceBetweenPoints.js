function getDistance(x1, y1, x2, y2) {
    let firstPoint={x1:Number(x1), y1:Number(y1)};
    let secondPoint={x2:Number(x2), y2:Number(y2)};

    let distance=Math.sqrt(
        (secondPoint.x2 - firstPoint.x1)*
        (secondPoint.x2 - firstPoint.x1)+
        (secondPoint.y2 - firstPoint.y1)*
        (secondPoint.y2 - firstPoint.y1));

    return distance;
}

console.log(getDistance(2, 4, 5, 0));