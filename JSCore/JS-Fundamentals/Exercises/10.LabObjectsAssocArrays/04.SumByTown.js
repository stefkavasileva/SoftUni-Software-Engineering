function main(arr) {
    let obj = {};
    for (let i = 0; i < arr.length; i+= 2) {
        let townName = arr[i];
        let sum = Number(arr[i + 1]);
        if(obj[townName] === undefined){
            obj[townName] = sum;
            continue;
        }

        obj[townName] += sum;
    }

    console.log(JSON.stringify(obj));
}

main(['Sofia','20','Varna','3','Sofia','5','Varna','4']);