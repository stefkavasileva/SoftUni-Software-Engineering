function isPrimeNumber(num) {
    let isPrimeNum=true;
    if(num <= 1){
        isPrimeNum = false;
    }

    for (let i = 2; i <= Math.sqrt(num) ; i++) {
        if(num%i == 0) {
            isPrimeNum = false;
        }
    }

    console.log(isPrimeNum);
}

isPrimeNumber(8)