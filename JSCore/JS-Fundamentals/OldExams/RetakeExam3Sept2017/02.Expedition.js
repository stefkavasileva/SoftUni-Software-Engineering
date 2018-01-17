function main(primaryMatrix, secondaryMatrix,overlayCoordinates, startCoordinates) {

    for (let startPosition of overlayCoordinates) {
        let x = startPosition[0];
        let y = startPosition[1];
        for(let row = 0; row < secondaryMatrix.length; row++){
            for(let col = 0; col < secondaryMatrix[row].length; col++){
                if(secondaryMatrix[row][col] != 1){
                    y++;
                    continue;
                }

                if(y >= primaryMatrix[x].length){
                    break;
                }

                let currentNumResult = primaryMatrix[x][y] === 1 ? 0 : 1;
                primaryMatrix[x][y]= currentNumResult;

                y++;

            }

            y = startPosition[1];
            x++;

            if(x >= primaryMatrix.length){
                break;
            }

        }
    }

    let startX = startCoordinates[0];
    let startY = startCoordinates[1];

    let stepCount = 0;

    


        }

main([[1, 1, 0, 1, 1, 1, 1, 0],
        [0, 1, 1, 1, 0, 0, 0, 1],
        [1, 0, 0, 1, 0, 0, 0, 1],
        [0, 0, 0, 1, 1, 0, 0, 1],
        [1, 0, 0, 1, 1, 1, 1, 1],
        [1, 0, 1, 1, 0, 1, 0, 0]],
    [[0, 1, 1],
        [0, 1, 0],
        [1, 1, 0]],
    [[1, 1],
        [2, 3],
        [5, 3]],
    [0, 2]
);