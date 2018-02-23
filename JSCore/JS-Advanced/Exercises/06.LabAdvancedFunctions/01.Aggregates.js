function aggregateElements(arr) {
    function reducer(arr,currentFunction) {
        let result = arr[0];
        for (let element of arr.slice(1)) {
            result = currentFunction(result,element);
        }

        return result;
    }

    let sum = reducer(arr,(a,b) => a + b);
    let min = reducer(arr,(a,b) => Math.min(a,b));
    let max = reducer(arr,(a,b) => Math.max(a,b));
    let product = reducer(arr,(a,b) => a * b);
    let join = reducer(arr,(a,b) => a.toString() + b.toString());

    let result = `Sum = ${sum}\nMin = ${min}\nMax = ${max}\nProduct = ${product}\nJoin = ${join}`;
    console.log(result);

}

aggregateElements([2,3,10,5]);