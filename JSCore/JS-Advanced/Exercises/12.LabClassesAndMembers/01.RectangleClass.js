class Rectngle{
    constructor(width,height,color){
        this.width = width;
        this.height = height;
        this.color = color;
    }

    calcArea(){
        let area = this.width * this.height;
        return area;
    }
}


let firstRect = new Rectngle(2,5,'red');
console.log(firstRect.calcArea());

let secondrect = new Rectngle(10.2,10,'yellow');
console.log(secondrect.color);