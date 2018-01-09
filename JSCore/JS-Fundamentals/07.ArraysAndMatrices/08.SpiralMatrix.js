function  main(rows, cols) {
    let matrix=[];

    for (let row = 0; row < rows; row++) {
        matrix[row]=[cols];
        for (let col = 0; col < cols; col++) {
            matrix[row][col]=0;
        }
    }

    let  count = 0;
    let col = -1;
    let row = -1;

    while (count < rows * cols)
    {
        row++;
        col++;

        while (col < cols && matrix[row][col] == 0)
        {
            count++;
            matrix[row][col] = count;
            col++;
        }
        col--;
        row++;

        while (row < rows && matrix[row][col] == 0)
        {
            count++;
            matrix[row][col] = count;
            row++;
        }
        row--;
        col--;

        while (col >= 0 && matrix[row][col] == 0)
        {
            count++;
            matrix[row][col] = count;
            col--;
        }
        row--;
        col++;
        while (row >= 0 && matrix[row][col] == 0)
        {
            count++;
            matrix[row][col] = count;
            row--;
        }


    }

    for (let row = 0; row < rows; row++) {
        console.log(matrix[row].join(' '));
    }

}

main(5,5);