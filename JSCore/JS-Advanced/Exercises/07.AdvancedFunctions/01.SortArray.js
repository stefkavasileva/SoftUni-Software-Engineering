function sortArr(arr, sortArg) {
    let sortFunctions = {
        asc: (arr) => arr.sort((a,b) => a - b ),
        desc: (arr) => arr.sort((a,b) => b - a)
    };
    let currentSortFunction = sortFunctions[sortArg];

   return currentSortFunction(arr);
}

sortArr([1,5,4,3],'desc');