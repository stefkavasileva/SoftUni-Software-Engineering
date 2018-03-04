class Circle{
    constructor(raduis){
        this.radius = raduis;
    }

    set diameter(diameter){
        this.radius = diameter / 2;
    }

    get diameter (){
        return this.radius * 2;
    }

    get area(){
        return Math.PI * this.radius * this.radius;
    }
}

let circle = new Circle(2);

console.log(`Radius: ${circle.radius}`);
console.log(`Diameter: ${circle.diameter}`);
console.log(`Area: ${circle.area}`);
circle.diameter = 1.6;
console.log(`Radius: ${circle.radius}`);
console.log(`Diameter: ${circle.diameter}`);
console.log(`Area: ${circle.area}`);
