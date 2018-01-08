function main(commands) {
    let numbers = [];
    let counter = 1;

    for(let command of commands){
        if(command == "add"){
            numbers.unshift(counter);
        }else{
            numbers.shift();
        }

        counter++;
    }

    if(numbers.length == 0){
        console.log("Empty");
        return;
    }

    console.log(numbers.reverse().join(`\n`));
}

main(["add","add","remove","add","add"]);