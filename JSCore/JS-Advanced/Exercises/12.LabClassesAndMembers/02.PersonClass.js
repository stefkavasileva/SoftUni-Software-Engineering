class Person{
    constructor(firstName,lastName,age,email){
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.email = email;
    }

    toString(){
        return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
    }
}

let firstPerson = new Person('Maria','Ivanova',15,'mimi@gmail.com');
let secondPerson = new Person('Ivan','Ivaov',56,'ívanInvanov@yahoo.com');

console.log(firstPerson.toString());
console.log(secondPerson.toString());