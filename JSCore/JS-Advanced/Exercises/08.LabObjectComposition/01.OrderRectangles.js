function getSortedRectangles(rectanglesArr) {
    let rectangles = [];
    for (let rectangleAsArr of rectanglesArr) {
        let rectangle = {
            width: Number(rectangleAsArr[0]),
            height: Number(rectangleAsArr[1]),
            area: function () {
                return this.width * this.height;
            },
            compareTo: function (otherRectangle) {
                if(this.area() === otherRectangle.area()){
                    return otherRectangle.width - this.width;
                }

                return otherRectangle.area() - this.area();
            }
        };

        rectangles.push(rectangle);
    }

    let sortedRectangles = rectangles.sort((a,b) => a.compareTo(b));
    return sortedRectangles;
}

console.log(getSortedRectangles([[10,5], [3,20], [5,12]]));;