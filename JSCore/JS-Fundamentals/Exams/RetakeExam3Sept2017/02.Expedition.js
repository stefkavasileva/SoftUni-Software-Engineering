function main(primaryMatrix, secondaryMatrix,overlayCoordinates, startCoordinates) {
    for (let currentCoordinates of overlayCoordinates) {
        changePrimaryMatrix(currentCoordinates,primaryMatrix,secondaryMatrix);
    }

    let stringResult = getExit(primaryMatrix,startCoordinates);




    function getExit(matrix,startPosition) {
        let startRow = startPosition[0];
        let startCol = startPosition[1];

        while(true){
            
        }
    }
   function changePrimaryMatrix (coordinates,primaryMatrix,secondaryMatrix) {
       let startRow = coordinates[0];
       let startCol = coordinates[1];

       for (let row = 0; row < secondaryMatrix.length; row++) {
           if(row + startRow < secondaryMatrix.length){
               for (let col = 0; col < secondaryMatrix[row].length; col++) {
                   let currentValue = primaryMatrix[row + startRow][col + startCol];
                  if(currentValue !== undefined || currentValue === 1 ){
                    let newValue = primaryMatrix[row + startRow][col + startCol] === 1 ? 0 : 1;
                    primaryMatrix[row + startRow] [col + startCol] = newValue;
                 }
               }
           }
       }
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