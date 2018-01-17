function printTriangleOfStars(n) {
    printTop(n);
    printBottom(n);

    function printTop(n) {
       for(i = 0; i <= n; i++){
           console.log('*'.repeat(i));
       }
    }

    function printBottom(n) {
        for(i = n - 1; i > 0 ; i--){
            console.log('*'.repeat(i));
        }
    }
}

printTriangleOfStars(1);