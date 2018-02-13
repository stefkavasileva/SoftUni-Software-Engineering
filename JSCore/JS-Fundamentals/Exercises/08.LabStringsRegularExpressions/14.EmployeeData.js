function getPersonInfo(input) {
    let pattern = /(^[A-Z][A-Za-z]*) - ([1-9]+[0-9]*) - ([A-Za-z\d \-]+)$/;
    for (let i = 0; i < input.length; i++) {
       let currentEmployee = input[i];
       let match = pattern.exec(currentEmployee);
       if(match){
           console.log(`Name: ${match[1]}`);
           console.log(`Position: ${match[3]}`);
           console.log(`Salary: ${match[2]}`);
       }
    }
}

getPersonInfo(['Jonathan - 2000 - Manager',
    'Peter- 1000- Chuck',
    'George - 1000 - Team Leader']);