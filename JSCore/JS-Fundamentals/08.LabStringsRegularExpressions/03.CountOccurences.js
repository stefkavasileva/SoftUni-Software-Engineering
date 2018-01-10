//50/100
function countOccurrences(word, text) {
    let regex = new RegExp(word,"g");
    let count = text.match(regex).length;
    console.log(count);
}
//100/100
function main(pattern,text) {
    let countOccurrences = 0;
    let lastIndex = -1;

    while (true){
        lastIndex = text.indexOf(pattern,lastIndex);
        if(lastIndex < 0){
            break;
        }

        lastIndex++;
        countOccurrences++;
    }

    console.log(countOccurrences);
}

main('ee', 'teeeteeeteeethe quick brown fox jumps over the lay dog.');