class CheckingAccount {
    constructor(clientId,email,firstName,lastName){
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
        this.products = [];
    }

   set clientId (clientId){
        let reg = /^\d{6}$/;
        if(!reg.test(clientId)){
            throw new TypeError('Client ID must be a 6-digit number');
        }

        return clientId;
   }

   set email(email){
        let reg = /^[A-Za-z]+@[A-Za-z\.]+$/;
        if(!reg.test(email)){
            throw new TypeError('Invalid e-mail');
        }

        return email;
   }

   set firstName(firstName){
        let reg = /^[A-Za-z]+$/;
        if(firstName.length < 3 || firstName.length > 20){
            throw new TypeError('First name must be between 3 and 20 characters long');
        }

        if(!reg.test(firstName)){
            throw new TypeError('First name must contain only Latin characters');
        }

        return firstName;
   }

    set lastName(lastName){
        let reg = /^[A-Za-z]+$/;
        if(lastName.length < 3 || lastName.length > 20){
            throw new TypeError('Last name must be between 3 and 20 characters long');
        }

        if(!reg.test(lastName)){
            throw new TypeError('Last name must contain only Latin characters');
        }

        return lastName;
    }
}

//let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov');
//let acc = new CheckingAccount('131455', 'ivan@', 'Ivan', 'Petrov');
//let acc = new CheckingAccount('131455', 'ivan@some.com', 'I', 'Petrov');
let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov');