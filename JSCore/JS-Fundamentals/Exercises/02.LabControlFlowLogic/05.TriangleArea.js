function getTriangleArea(firstSide, secondSide, thirdSide) {
    let semiperimeter = (firstSide + secondSide + thirdSide)/2;
    let area = Math.sqrt(semiperimeter*
        (semiperimeter - firstSide)*
        (semiperimeter - secondSide)*
        (semiperimeter - thirdSide));
    console.log(area);
}

getTriangleArea(2,3.5,4)