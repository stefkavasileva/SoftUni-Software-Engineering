function printOrderAndDistance([x1,y1,x2,y2,x3,y3]) {
    let firstDistance = Math.sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
    let secondDistance = Math.sqrt(((x3-x2)*(x3-x2))+((y3-y2)*(y3-y2)));
    let thirdDistance = Math.sqrt(((x3-x1)*(x3-x1))+((y3-y1)*(y3-y1)));

    if ((firstDistance <= thirdDistance) && ( thirdDistance => secondDistance)) {
        console.log('1->2->3: ' + (firstDistance + secondDistance));
    }
    else if ((firstDistance <= secondDistance) && (thirdDistance < secondDistance)) {
        console.log('2->1->3: '+ (thirdDistance+firstDistance));
    }
    else {
        console.log('1->3->2: ' + (secondDistance+thirdDistance));
    }
}

printOrderAndDistance([0, 0, 2, 0, 4, 0]);