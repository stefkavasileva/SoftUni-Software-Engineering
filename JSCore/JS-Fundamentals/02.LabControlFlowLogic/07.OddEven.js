function oddEvenOrInvalidNumber(number) {
   let result = "invalid";

    if(number % 2 == 0){
        result = "even";
    }else if (number % 2 == 1 || number % 2 == -1){
        result = "odd";
    }

    console.log(result);
}

oddEvenOrInvalidNumber(5)