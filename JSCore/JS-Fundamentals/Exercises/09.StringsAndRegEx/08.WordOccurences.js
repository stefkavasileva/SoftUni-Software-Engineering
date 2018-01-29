//80/100
function main(text, word) {
    word = word.toLowerCase();
    text = text.toLowerCase();

    let elements = text.split(/\W+/);
    let count = 0;
    for (let i = 0; i < elements.length; i++) {
        if(elements[i] === word){
            count++;
        }
    }

    console.log(count);
}

//100/100
function main(sentence,word) {
    word=`\\b`+ word +`\\b`;
    let reg = new RegExp(word,'gi');
    let counter = 0;
    let match = reg.exec(sentence);

    while (match){
        counter++;
        match = reg.exec(sentence);
    }

    console.log(counter);
}

main('The waterfall was so high, that the child couldn’t see its peak.',  'the');