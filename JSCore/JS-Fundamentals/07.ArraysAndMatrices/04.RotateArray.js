function rotateArray(input) {
    let rotations = input.pop() % input.length;
    for (let i = 0; i < rotations; i++) {
        let firstElement = input[input.length-1];
        input.pop();
        input.unshift(firstElement);
    }

    console.log(input.join(" "));
}

rotateArray([1,2,3,4,2]);