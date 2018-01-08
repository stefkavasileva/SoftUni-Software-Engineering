function sortArray(inputArr) {
    //80/100
    let sortedArr = inputArr
        .sort((a,b) => a - b)
        .sort((a,b) => a.length  - b.length);

    console.log(sortedArr.join('\n'));
}

sortArray(["alpha","beta","gamma"]);

// 100/100
/*function main(inputArr) {
    let sortedArr=inputArr.sort(function(a,b) {
        a = a.toLowerCase();
        b = b.toLowerCase();
        if( a == b) return 0;
        if( a > b) return 1;
        return -1;
    });

    sortedArr=sortedArr.sort((a,b)=>a.length-b.length);

    console.log(sortedArr.join('\n'));

}*/