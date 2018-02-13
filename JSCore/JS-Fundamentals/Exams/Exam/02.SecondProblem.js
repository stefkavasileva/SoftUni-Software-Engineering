function main(matrixAsStr, comands) {
    let matrix  = [];
    for (let i = 0; i < matrixAsStr.length; i++) {
        matrix[i] = matrixAsStr[i].split(' ').filter(x => x !== '').map(Number);
    }

    for (let command of comands) {
        let commandArgs = command.split(' ');
        let name = commandArgs[0];
        let amount = Number(commandArgs[1]);

        if(name === 'breeze'){
            let rowIndex = amount;
            for (let col = 0; col < matrix[rowIndex].length; col++) {
                matrix[rowIndex][col] -= 15;
                if(matrix[rowIndex][col] < 0){
                    matrix[rowIndex][col] = 0;
                }
            }
        }else if(name === 'gale'){
            let colIndex = amount;
            for (var row = 0; row < matrix.length; row++) {
                matrix[row][colIndex] -= 20;
                if(matrix[row][colIndex] < 0){
                    matrix[row][colIndex] = 0;
                }
            }
        }else if(name === 'smog'){
            for (var row = 0; row < matrix.length; row++) {
                for (var col = 0; col < matrix[row].length; col++) {
                    matrix[row][col] += amount;
                }
            }
        }
    }

    let result = 'Polluted areas: ';
    for (var row = 0; row < matrix.length; row++) {
        for (var col = 0; col < matrix[row].length; col++) {
            if(matrix[row][col] >= 50){
                result += `[${row}-${col}], `;
            }
        }

    }

    if(result.length === 16 ){
        console.log('No polluted areas')
        return;
    }
    result = result.trim();
    result = result.substr(0,result.length - 1);
    console.log(result);
}
main([
        "5 7 3 28 32",
        "41 12 49 30 33",
        "3 16 20 42 12",
        "2 20 10 39 14",
        "7 34 4 27 24",
    ],
    [
        "smog 11", "gale 3",
        "breeze 1", "smog 2"
    ]

);