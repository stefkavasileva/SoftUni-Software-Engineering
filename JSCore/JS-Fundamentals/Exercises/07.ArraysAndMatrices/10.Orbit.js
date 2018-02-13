function changeMatrix([rows, cols, y, x]) {
    let matrix=[];

    for (let row = 0; row < rows; row++) {
        matrix[row]=[cols];
        for (let col = 0; col < cols; col++) {
            matrix[row][col]=0;
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix.length; col++) {
            matrix[row][col] = Math.max(Math.abs(y - row),Math.abs(x - col)) + 1;

        }
    }

    for (let row = 0; row < matrix.length; row++) {
        console.log(matrix[row].join(' '));
    }
}

changeMatrix([5, 5, 2, 2]);