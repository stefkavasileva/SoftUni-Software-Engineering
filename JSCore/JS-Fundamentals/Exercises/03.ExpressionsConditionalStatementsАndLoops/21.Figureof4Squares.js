function  printSquare(n) {
    let middleLine = Math.trunc((n+1) / 2) ;

    let lines = n % 2 == 0 ? n - 1 : n ;

    for (let i = 1; i <= lines ; i++) {
        if (i == 1 || i == lines || i == middleLine) {
            let curentLine = "+";

            for (let j = 0; j < n - 2; j++) {
                curentLine += "-"
            }

            curentLine += "+";

            for (let j = 0; j < n - 2; j++) {
                curentLine += "-"
            }

            curentLine += "+";

            console.log(curentLine);
        }else{
            let curentLine = "|";

            for (let j = 0; j < n - 2; j++) {
                curentLine += " "
            }

            curentLine += "|";

            for (let j = 0; j < n - 2; j++) {
                curentLine += " "
            }
            curentLine += "|";
            console.log(curentLine);
        }
    }
}

printSquare(6);
