function main(number) {
    let result = "<ul>";
    for(i = 1; i <= number; i++){
        let color = "green";
        if(i % 2 == 0){
            color = "blue";
        }
        result += "\n";
        result += `  <li><span style='color:${color}'>${i}</span></li>`;
    }

    result += "\n";
    result += "</ul>";
    console.log(result);
}

main(10);
