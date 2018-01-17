function main(n) {
    let result = `<div class=\"chessboard"> `
    for (let row = 0; row < n; row++) {
        result += "\n" + `   <div>`;
        for (let col = 0; col < n; col++) {
           result += "\n" + `    <span class=${(col+row)%2==0?"\"black\"":"\"white\""}></span>`;
        }
        result += "\n" + `   </div>`;
    }
    result += "\n" + `</div>`;

    console.log(result);
}

main(3)