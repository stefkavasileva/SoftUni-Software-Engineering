function main(input) {
    let words = [];
    for (let i = 0; i < input.length; i++) {
       words = words.concat(input[i]
           .toLowerCase()
           .split(/\W+/)
           .filter(x => x !== ''));
    }

    let map = new Map();
    for (let i = 0; i < words.length; i++) {
        let currentWord = words[i];
        if(!map.has(currentWord)){
            map.set(currentWord, 1);
            continue;
        }

        map.set(currentWord,map.get(currentWord) + 1);
    }

    let arr = Array.from(map).sort();
    for (let key of arr) {
        console.log(`'${key[0]}' -> ${key[1]} times`)
    }
}

main(['Far too slow, you\'re far too slow.']);