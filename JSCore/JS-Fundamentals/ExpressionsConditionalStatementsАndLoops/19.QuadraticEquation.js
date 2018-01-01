function print(a,b,c) {
    let d = (b * b) - 4 * a * c;

    if(d > 0){
        let x1 = (-b + Math.sqrt(d)) / (2 * a);
        let x2 = (-b - Math.sqrt(d)) / (2*a);
        let maxX = Math.max(x1,x2);
        let minX = Math.min(x1,x2);
        console.log(minX);
        console.log(maxX);
    }else if(d == 0){
        let x = -b / (2 * a);
        console.log(x);
    }else {
        console.log("No")
    }
}

 print([6,11,-35]);