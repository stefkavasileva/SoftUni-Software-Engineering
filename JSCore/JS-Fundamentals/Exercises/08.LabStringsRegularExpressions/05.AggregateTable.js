function aggregateTable(input) {
    let allText = input.join('');
    let elements = allText
        .split('|')
        .filter(x => x !== '')
        .map(x=>x.trim());

    let towns = elements.filter((a,b) => b % 2 === 0);
    let sum = elements
        .filter((a,b) => b % 2 !== 0)
        .map(Number)
        .reduce((a,b) => a + b);

    console.log(towns.join(', '));
    console.log(sum);
}

aggregateTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']
);