function personAndTeacher() {
    class Person{
        constructor(name,email){
            this.name = name;
            this.email = email;
        }
    }

    class Teacher extends Person{
        constructor(name,email,subject){
            super(name,email);
            this.subject = subject;
        }
    }

    return {
        Person,
        Teacher
    }
}

let personAndTeacherClasses = personAndTeacher();
let Person = personAndTeacherClasses.Person;
let Teacher = personAndTeacherClasses.Teacher;

let person = new Person('Peter','pet@test.bg');
let teacher = new Teacher('Ivan','iv@gmail.com','JS');

console.log(person);
console.log(teacher);
