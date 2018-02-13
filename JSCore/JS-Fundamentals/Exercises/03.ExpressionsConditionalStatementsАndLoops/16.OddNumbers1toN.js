function oddNumbers(endNumber) {
    for(let i = 1; i <= endNumber; i++){
        if(i % 2 != 0){
            console.log(i);
        }
    }
}

oddNumbers(5);