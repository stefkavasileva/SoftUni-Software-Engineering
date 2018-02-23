function getLargestElement(arr) {
   return Math.max.apply(null,arr);
}

console.log(getLargestElement([1, 44, 123, 33]));

//0/100 in judge system
/*function getLargestElement(arr) {
    let result = reducer(arr,(a,b) => Math.max(a,b));
    console.log(result);

    function reducer(arr, currentFunction) {
     let result = arr[0];
        for (let element of arr.slice(1)) {
            result = currentFunction(result,element);
        }

        return result;
    }
}*/