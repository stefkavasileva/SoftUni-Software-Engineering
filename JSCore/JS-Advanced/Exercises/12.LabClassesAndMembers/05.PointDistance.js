class Point{
    constructor(x,y){
        this.x = x;
        this.y = y;
    }

    static distance(firstPoint,secondPoint){
        return Math.sqrt(((secondPoint.x - firstPoint.x) * (secondPoint.x - firstPoint.x)) +
            ((secondPoint.y - firstPoint.y) * (secondPoint.y - firstPoint.y)));
    }
}

let firstPoint = new Point(5, 5);
let secondPoint = new Point(9, 8);
console.log(Point.distance(firstPoint, secondPoint));
