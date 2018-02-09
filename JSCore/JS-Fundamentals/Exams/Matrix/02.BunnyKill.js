//40/100
function countKilledBunny(matrixAsStr) {
    let matrix = [];
    matrixAsStr.pop();
    let coordinatesAsStr = matrixAsStr.pop();
    for (let i = 0; i < matrixAsStr.length; i++) {
        let currentRow = matrixAsStr[i].split(' ').filter(x => x !== '').map(Number);
        matrix[i] = currentRow;
    }

    let coordinates = coordinatesAsStr.split(' ').filter(x => x !== '');
    for (let i = 0; i < coordinates.length; i++) {
        let [newRow,newCol] = coordinates[i].split(',').filter(x => x !== '').map(Number);
        let damage = matrix[newRow][newCol];
        for (let row = 0, n = matrix.length; row < n; row++) {
            for (let col = 0, m = matrix[row].length; col < m; col++) {
                if ((Math.abs(row - newRow) <= 1 && Math.abs(col - newCol) <= 1) && (col !== newCol || row !== newRow)) {
                    matrix[row][col] = Math.max(0, matrix[row][col] - damage);
                }
            }
        }

    }

    let damage = 0;
    let killedBunny = 0;


    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if(matrix[row][col] > 0){
                damage += matrix[row][col];
                killedBunny++;
            }
        }
    }

    console.log(damage);
    console.log(killedBunny);

    //matrix.forEach(x => console.log(x.join(' ')));

    function explode(matrix,newPosition, row, col, coordinates,index) {
        let newRow = newPosition[0];
        let newCol = newPosition[1];
        let bunnyValue = matrix[row][col];

        matrix[newRow][newCol] -= bunnyValue;
        let hasBunny = isBunny(newRow,newCol,coordinates);
        if(hasBunny){
            coordinates.slice(index,1);
            index--;
        }

    }

    function isBunny(row,col,coordinates) {
        let isBunny = false;
        for (let [currentRow, currentCol] of coordinates) {
            if(row === currentRow && col === currentCol){
                isBunny = true;
                break;
            }
        }

        return isBunny;
    }
}


countKilledBunny([  '5 10 15 20',
                    '10 10 10 10',
                    '10 15 10 10',
                    '10 10 10 10',
    '1,2 0,1','']);