function main(inputArr) {
    let matrix=[];
    for (let row = 0; row < inputArr.length; row++) {
        matrix[row] = inputArr[row].split(' ').map(Number);

    }

    let sumMainDiagonal = 0;
    let sumSecondaryDiagonal = 0;
    for (let row = 0; row < matrix.length; row++) {
        for (var col= 0; col < matrix.length; col++) {
            if(col == row){
                sumMainDiagonal += matrix[row][col];
            }

            if(row + col == matrix.length - 1){
                sumSecondaryDiagonal+=matrix[row][col];
            }
        }
    }

    if (sumSecondaryDiagonal == sumMainDiagonal){
        for (let row = 0; row < matrix.length; row++) {
            for (let col= 0; col < matrix.length; col++) {
                if(col != row && row + col != matrix.length-1 ){
                    matrix[row][col] = sumMainDiagonal;
                }
            }
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        console.log(matrix[row].join(' '));
    }
}

main(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']
);