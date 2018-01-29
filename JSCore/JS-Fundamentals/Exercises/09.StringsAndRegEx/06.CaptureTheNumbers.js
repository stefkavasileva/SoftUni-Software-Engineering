function main(input) {
    let result = [];
    for (let i = 0; i < input.length; i++) {
        input[i]
            .split(/\D+/)
            .filter(x => x !=='')
            .forEach(x => result.push(x));
    }

    console.log(result.join(' '));
}

main(['The300',
'What is that?',
'I think it’s the 3rd movie.',
'Lets watch it at 22:45']);