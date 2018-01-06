function getTreasure(arr) {
    let treasures=``;

    for (let i = 0; i < arr.length; i += 2) {
        let x = arr[i];
        let y = arr[i+1];

        if(x >= 1 && x <= 3 && y >= 1 && y <= 3){
            treasures += `Tuvalu\n`;
        }else if(x >= 8 && x <= 9 && y >= 0 && y <= 1){
            treasures += `Tokelau\n`;
        }else if(x >= 5 && x <= 7 && y >= 3 && y <= 6){
            treasures += `Samoa\n`;
        }else if(x >= 0 && x <= 2 && y >= 6 && y <= 8){
            treasures += `Tonga\n`;
        }else if(x >= 4 && x <= 9 && y >= 7 && y <= 8){
            treasures += `Cook\n`;
        }else {
            treasures += `On the bottom of the ocean\n`;
        }
    }

    console.log(treasures);
}

getTreasure([4, 2, 1.5, 6.5, 1, 3]);