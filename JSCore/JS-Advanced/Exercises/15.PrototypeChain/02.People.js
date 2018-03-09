function employees() {
    class Employee{
        constructor(name,age){
            if(this.constructor.name === 'Employee'){
                throw new Error('Cannot instantiate directly');
            }

            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }

        work(){
            let currentTask = this.tasks.shift();
            console.log(this.name + ' ' + currentTask);
            this.tasks.push(currentTask);
        }

        collectSalary(){
            console.log(`${this.name} received ${this.getSalary()} this month.`)
        }

        getSalary(){
            return this.salary;
        }
    }

    class Junior extends Employee{
        constructor(name,age){
            super(name,age);
            this.tasks.push('is working on a simple task.');
        }
    }

    class Senior extends Employee{
        constructor(name,age){
            super(name,age);
            this.tasks.push('is working on a complicated task.');
            this.tasks.push('is taking time off work.');
            this.tasks.push('is supervising junior workers.');
        }
    }


    class Manager extends Employee{
        constructor(name, age){
            super(name, age);
            this.dividend = 0;
            this.tasks.push("scheduled a meeting.");
            this.tasks.push("is preparing a quarterly report.");
        }

        getSalary(){
            return super.getSalary() + this.dividend;
        }
    }

    return{Employee,Junior,Senior,Manager}
}

let empls = employees();
let Employee = empls.Employee;
let Junior = empls.Junior;
let Senior = empls.Senior;
let Manager = empls.Manager;

//let employee = new Employee('Jo',25); // error
let junior = new Junior('Jo',24);
let senior = new Senior('Senior', 45);
let manager = new Manager('Manager', 55);

console.log(junior);
console.log(senior);
console.log(manager);