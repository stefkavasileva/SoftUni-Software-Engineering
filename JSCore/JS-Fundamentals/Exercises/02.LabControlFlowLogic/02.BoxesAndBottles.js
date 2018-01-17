function boxesCount(bottles, capacity) {
    let result = bottles / capacity;
    console.log(Math.ceil(result));
}

boxesCount(20,5);
