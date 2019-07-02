//85/100
function solve(args) {
    let numbers=args
        .filter(x=>x.length>0)
        .map(x=>Number(x))
        .sort((a,b)=> b - a);

    let largestNum=numbers.splice(0,Math.min(3,numbers.length));
    for (let i = 0; i < largestNum.length; i++) {
        console.log(largestNum[i])

    }
}