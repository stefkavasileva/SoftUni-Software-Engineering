function getDistance([firstSpeed, secondSpeed, seconds]) {

    let firstDistance = firstSpeed * (seconds / 3600);
    let secondDistance = secondSpeed * (seconds / 3600);

    console.log(Math.abs(firstDistance - secondDistance) * 1000);
}

getDistance([0,60,3600]);