function getTribonacci(n, k) {
    let sequence = [];
    sequence[0] = 1;

    for(let i = 1; i < n; i++){
        let sum = 0;
        for(let j = i - k; j <= i - 1  ; j++){
            if(j >= 0){
                sum += sequence[j];
            }
        }

        sequence[i] = sum;
    }

    console.log(sequence.join(" "));
}

getTribonacci(6,3);