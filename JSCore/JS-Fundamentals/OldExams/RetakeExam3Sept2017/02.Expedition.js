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

    let startPosition = {x: startCoordinates[0], y: startCoordinates[1]};

    let stepCount = 1;
    primaryMatrix[startPosition.x][startPosition.y] = 1;

    while (true){
        let nextPosition = {x: startPosition.x, y: startPosition.y - 1};
        if(nextPosition.y >= 0 && primaryMatrix[nextPosition.x][nextPosition.y] === 0){
            startPosition = nextPosition;
            stepCount++;
            primaryMatrix[nextPosition.x][nextPosition.y] = 1;
            continue;
        }

        nextPosition.y += 2;
        if(nextPosition.y < primaryMatrix[nextPosition.x].length && primaryMatrix[nextPosition.x][nextPosition.y] === 0){
            startPosition = nextPosition;
            primaryMatrix[nextPosition.x][nextPosition.y] = 1;
            stepCount++;
            continue;
        }

        --nextPosition.y;
        --nextPosition.x;
        if(nextPosition.x > 0 && primaryMatrix[nextPosition.x][nextPosition.y] === 0){
            startPosition = nextPosition;
            primaryMatrix[nextPosition.x][nextPosition.y] = 1;
            stepCount++;
            continue;
        }

        nextPosition.x += 2;
        if(nextPosition.x < primaryMatrix.length && primaryMatrix[nextPosition.x][nextPosition.y] === 0){
            startPosition = nextPosition;
            primaryMatrix[nextPosition.x][nextPosition.y] = 1;
            stepCount++;
            continue;
        }

        console.log(stepCount);

        if(nextPosition.x >= primaryMatrix.length){
            console.log("Bottom");
            break;
        }

        if(nextPosition.x <= 0){
            console.log("Top");
            break;
        }

        if(nextPosition.y < 0){
            console.log("Left");
            break;
        }

        if(nextPosition.y >= primaryMatrix[nextPosition.x].length){
            console.log("Right");
            break;
        }

        let quadrantNumber = 0;
        let halfRowCount = parseInt(primaryMatrix.length / 2);
        let halfColCount = parseInt(primaryMatrix[startPosition.x].length / 2);

        if(startPosition.y >= halfRowCount &&  startPosition.x <= halfColCount){
            quadrantNumber = 1;
        }else if(startPosition.y <= halfColCount &&  startPosition.x < halfRowCount){
            quadrantNumber = 2;
        }else if(startPosition.y < halfColCount &&  startPosition.x > halfRowCount){
            quadrantNumber = 3;
        }else {
            quadrantNumber = 4;
        }

        console.log(`Dead end ${quadrantNumber}`);
        break;
    }
}

main([[1, 1, 0, 1],
        [0, 1, 1, 0],
        [0, 0, 1, 0],
        [1, 0, 1, 0]],
    [[0, 0, 1, 0, 1],
        [1, 0, 0, 1, 1],
        [1, 0, 1, 1, 1],
        [1, 0, 1, 0, 1]],
    [[0, 0],
        [2, 1],
        [1, 0]],
    [2, 0]
);