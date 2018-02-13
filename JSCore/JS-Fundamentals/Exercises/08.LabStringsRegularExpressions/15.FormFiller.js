function filter(userName,email,phoneNumber,input) {
    let namePattern = /<![A-Za-z]+!>/;
    let emailPattern = /<@[A-Za-z]+@>/;
    let numberPattern = /<\+[A-Za-z]+\+>/;

    for (let i = 0; i < input.length; i++) {
        input[i] = input[i].replace(namePattern, userName);
        input[i] = input[i].replace(emailPattern, email);
        input[i] = input[i].replace(numberPattern, phoneNumber);
    }

    input.forEach(x => console.log(x));
}

filter('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']
);