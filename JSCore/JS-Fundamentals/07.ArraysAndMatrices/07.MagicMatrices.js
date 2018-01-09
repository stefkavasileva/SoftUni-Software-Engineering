function isMagicMatrix(matrix) {
    let magicSum = 0;
    let isMagicMatrix = true;

    for (let row = 0; row < matrix.length; row++) {
        let rowSum = 0;
        let colSum = 0;
        for (let col = 0; col < matrix.length; col++) {
            rowSum += matrix[row][col];
            colSum += matrix[col][row];
        }

        if((magicSum != rowSum || magicSum != colSum )&& row > 0){
            isMagicMatrix = false;
            break;
        }

        magicSum = rowSum;
    }

    console.log(isMagicMatrix)
}

main([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]
);