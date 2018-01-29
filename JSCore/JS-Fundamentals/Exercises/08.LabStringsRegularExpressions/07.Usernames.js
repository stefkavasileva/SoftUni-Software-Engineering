function main(input) {
    let result = [];
    for (let i = 0; i < input.length; i++) {
        let elements = input[i].split(/@/g);
        let emailResult = elements[0] + '.';
        let domains = elements[1].split('.')
        for (let j = 0; j < domains.length; j++) {
           emailResult += domains[j][0];
        }

        result.push(emailResult);
    }

    console.log(result.join(', '));
}
main(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com'])
