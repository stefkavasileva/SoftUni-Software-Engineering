function getDiagonalsSums(matrix) {
    let sumPrimaryDiagonal = 0;
    let sumSecondaryDiagonal = 0;

    for(let row = 0; row < matrix.length; row++){
        sumPrimaryDiagonal += matrix[row][row];
        sumSecondaryDiagonal += matrix[row][matrix.length - row - 1];
    }

    let result = `${sumPrimaryDiagonal} ${sumSecondaryDiagonal}`;
    console.log(result);
}

getDiagonalsSums([[20, 40],[10, 60]]);