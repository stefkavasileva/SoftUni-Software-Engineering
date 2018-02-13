function isEmailValid(email) {
    let pattern = /^[A-Za-z\d]+@[a-z]+\.[a-z]+$/g;
    if(pattern.test(email)){
        console.log('Valid');
        return;
    }

    console.log('Invalid');
}

isEmailValid(['valid@email.bg']);