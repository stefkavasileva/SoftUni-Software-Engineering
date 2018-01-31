function main(input) {
    let words = [];
    for (let i = 0; i < input.length; i++) {
      words = words.concat(input[i]
            .split(/\W+/)
            .filter(x => x !== ''));
    }
    let obj = {};

    for (let i = 0; i < words.length; i++) {
       if(obj[words[i]] === undefined){
           obj[words[i]] = 1;
           continue;
       }

       obj[words[i]]++;
    }

    console.log(JSON.stringify(obj));
}

main(['Far too slow, you\'re far too slow.']);