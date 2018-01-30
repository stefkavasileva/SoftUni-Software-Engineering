function main(input) {
    let namePattern = /(\*[A-Z][A-Za-z]*)\s+/;
    let phonePattern =  /\+[0-9-]{10}/;
    let idPattern = /(![A-Za-z\d]+)\s+/;
    let basePattern = /(_[0-9A-Za-z]+)\s+/;

    for (let i = 0; i < input.length; i++) {
        let match = namePattern.exec(input[i]);
        if(match){
            input[i] = input[i].replace(namePattern,'|'.repeat(match[0].length - 1) + ' ');
        }

        match = phonePattern.exec(input[i]);
        if(match){
            input[i] = input[i].replace(phonePattern, '|'.repeat(match[0].length) + ' ');
        }

        match = idPattern.exec(input[i]);
        if(match){
            input[i] = input[i].replace(idPattern, '|'.repeat(match[0].length - 1) + ' ');
        }

        match = basePattern.exec(input[i]);
        if(match){
            input[i] = input[i].replace(basePattern, '|'.repeat(match[0].length - 1) + ' ');
        }
    }

    input.forEach(x => console.log(x));
}
main(['Agent *Ivankov was in the room when it all happened.',
    'The person in the room was heavily armed.' ,
    'Agent *Ivankov had to act quick in order.' ,
    'He picked up his phone and called some unknown number. ' ,
    'I think it was +555-49-796' ,
    'I can\'t really remember...' ,
    'He said something about "finishing work" with subject !2491a23BVB34Q and returning to Base _Aurora21',
    'Then after that he disappeared from my sight.',
    'As if he vanished in the shadows.' ,
    'A moment, shorter than a second, later, I saw the person flying off the top floor.',
    'I really don\'t know what happened there.',
    'This is all I saw, that night.',
    'I cannot explain it myself...']);