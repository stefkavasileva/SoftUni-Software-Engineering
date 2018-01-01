function getDegrees(grad) {
    let diffDeg = 400 / 360;
    let convertedGradToDeg = (grad / diffDeg) % 360;

    if (convertedGradToDeg < 0) {
        convertedGradToDeg += 360;
    }

    console.log(convertedGradToDeg)
}

getDegrees(100);