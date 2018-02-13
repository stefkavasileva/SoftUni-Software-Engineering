function getUniqueSeq(input) {
    let set = new Set();
    input.forEach(x => set.add(JSON.parse(x).map(Number).sort((a,b) => b - a).join(', ')));

    let arrs = Array.from(set).sort((a,b) => a.split(', ').length - b.split(', ').length); // check number of elements, not string length
    arrs.forEach(x => console.log(`[${x}]`));
}

getUniqueSeq(['[-3, -2, -1, 0, 1, 2, 3, 4]',
'[10, 1, -17, 0, 2, 13]',
'[4, -3, 3, -2, 2, -1, 1, 0]']);