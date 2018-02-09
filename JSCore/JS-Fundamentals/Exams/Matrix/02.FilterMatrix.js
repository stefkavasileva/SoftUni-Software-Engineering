function filterMatrix(input) {
    let k = Number(input.pop());
    let letRowsCount = {};
    for (let i = 0; i < input.length; i++) {
        letRowsCount[i] = input[i].split(' ').filter(x => x !== '').length;
    }

    let numbers = input.join(' ').split(' ').filter(x => x !== '');

    let equalElementsCount = 0;
    for (let i = 0; i < numbers.length; i++) {
        let isEqual = true;
        for (let j = i; j < i + k - 1; j++) {
            if(numbers[j] !== numbers[j + 1]){
                isEqual = false;
            }
        }

        if(isEqual){
            for (let j = i; j < i + k ; j++) {
                numbers[j] = '';
            }
        }
    }

    let elementInRow = '';
    let lastIndex = 0;
    for (let i = 0; i < input.length; i++) {
        let rowCount = letRowsCount[i];
        let currentNumbers = numbers.slice(lastIndex,rowCount + lastIndex ).filter(x => x !== '');

        if(currentNumbers.length === 0){
            console.log('(empty)')
        }else{
            console.log(currentNumbers.join(' '));
        }
        lastIndex += rowCount;
    }
}

filterMatrix(['3 3 3 2 5 9 9 9 9 1 2',
'1 1 1 1 1 2 5 8 1 1 7',
'7 7 1 2 3 5 7 4 4 1 2',
'2']);

