function getBiggestNumber(matrix) {
   let biggestNum = -1000000;
   for(let row = 0; row < matrix.length; row++){
       for(let col  = 0; col < matrix[row].length; col++){
           if(matrix[row][col] > biggestNum){
               biggestNum = matrix[row][col];
           }
       }
   }

    console.log(biggestNum);
}

getBiggestNumber([[20, 50, 10],[8, 33, 145]]);