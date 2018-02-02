function main(input) {
    let uniqueNames = new Set();
    input.forEach(x => uniqueNames.add(x));
    uniqueNames = Array.from(uniqueNames).sort(sortNames);

    uniqueNames.forEach(x => console.log(x));

    function sortNames(a,b) {
        if(a.length < b.length)return -1;
        if(a.length > b.length) return 1;
        return a.localeCompare(b);
    }
}

main(['Ashton',
'Kutcher',
'Ariel',
'Lilly',
'Keyden',
'Aizen',
'Billy',
'Braston']);