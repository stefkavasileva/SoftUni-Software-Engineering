function main(arr){
    let keysName = arr[0]
        .split(/[|]/)
        .filter(x => x !== '')
        .map(x => x.trim());

    let objects = [];
    for (let i = 1; i < arr.length; i++) {
        let currentRowArgs = arr[i]
            .split(/[|]/)
            .filter(x => x!== '' )
            .map(x => x.trim());

        let obj = {};
        for (let j = 0; j < keysName.length; j++) {
            if(!isNaN(currentRowArgs[j])){
                obj[keysName[j]]= Number(currentRowArgs[j]);
                continue;
            }

            obj[keysName[j]]= currentRowArgs[j];
        }

        objects.push(obj);
    }

    console.log(JSON.stringify(objects));
}

main(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']);