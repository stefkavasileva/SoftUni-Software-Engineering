function filterElements(input) {
    let filteredElements = input.filter((a,b) => b % 2 == 0);
    let elements = filteredElements.join(" ");
    console.log(elements);
}

filterElements(['20', '30', '40']);