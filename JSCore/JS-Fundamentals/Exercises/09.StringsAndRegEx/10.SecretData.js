//85/100
function main(input) {
    let namePattern = /(\*[A-Z][A-Za-z]*)(\s+|$)/g;
    let phonePattern = /(\+[0-9-]{10})(\s+|$)/g;
    let idPattern = /(![a-zA-Z0-9]+)(\s+|\t|$)/g;
    let basePattern = /(_[0-9A-Za-z]+)(\s+|$)/g;

    for (let i = 0; i < input.length; i++) {
        input[i] = changeMatchText(namePattern,input[i]);
        input[i] = changeMatchText(phonePattern,input[i]);
        input[i] = changeMatchText(idPattern,input[i]);
        input[i] = changeMatchText(basePattern,input[i]);
    }

    input.forEach(x => console.log(x));

    function changeMatchText(pattern,currentLine) {
        let match;
        while (match = pattern.exec(currentLine)){
            currentLine = currentLine.replace(match[1],'|'.repeat(match[1].length));
        }
        return currentLine;
    }
}

main(['Agent *Ivankov was in the room when it all happened.',
    'The person in the room was heavily armed.' ,
    'Agent *Ivankov had to act quick in order.' ,
    'He picked up his phone and called some unknown number. ' ,
    'I think it was +555-49-796' ,
    'I can\'t really remember...' ,
    'He said something about "finishing work" with subject !2491a23BVB34Q and returning to Base _Aurora21 ',
    'Then after that he disappeared from my sight.',
    'As if he vanished in the shadows.' ,
    'A moment, shorter than a second, later, I saw the person flying off the top floor.',
    'I really don\'t know what happened there.',
    'This is all I saw, that night.',
    'I cannot explain it myself...']);