function getType(input) {
    let fruits = ["banana", "apple", "kiwi", "cherry", "lemon", "grapes", "peach"];
    let vegetables = ["tomato", "cucumber", "pepper", "onion", "garlic", "parsley", "peach"];

    let result = "unknown";

    if(fruits.includes(input)){
        result = "fruit";
    }else if(vegetables.includes(input)){
        result = "vegetable";
    }

    console.log(result);
}

getType("banana");