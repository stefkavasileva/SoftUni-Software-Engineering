function getBiggestProductByInterval(input) {
    let numbers = input.map(Number);
    let sum = 0;
    let biggestSum = -Infinity;

    for (let i = 0; i < numbers.length - 1; i++) {
       let number = numbers[i];
       if(number > 0 && number < 10){
           sum = numbers
               .slice(i + 1, Math.min(i + number + 1, numbers.length, numbers.length))
               .reduce((a,b) => a * b);

           if(biggestSum < sum){
               biggestSum = sum;
           }
       }
    }

    console.log(biggestSum);
}

getBiggestProductByInterval(['100','100','2','3','2','3','2','1','1']);