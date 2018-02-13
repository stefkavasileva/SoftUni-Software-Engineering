function changeNumber(input) {
    let number = input[0];

    for(let i = 1; i < input.length; i++){
        let operation = input[i];

        switch (operation){
            case "chop":
                number /= 2;
                console.log(number);
                break;
            case  "dice":
                number = Math.sqrt(number);
                console.log(number);
                break;
            case  "spice":
                ++number;
                console.log(number );
                break;
            case "bake":
                number *= 3;
                console.log(number);
                break;
            case  "fillet":
                number -= number * 0.2;
                console.log(number);
                break
        }
    }
}

changeNumber([9, "dice", "spice", "chop", "bake", "fillet"]);