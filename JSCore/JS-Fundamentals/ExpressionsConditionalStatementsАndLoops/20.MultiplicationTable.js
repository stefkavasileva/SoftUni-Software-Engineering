function multiplicationTable(n) {
    let html = "";
    html += '<table border="1">\n';
    html += '\t<tr><th>x</th>';

    for(let i = 1; i<= n; i++) {
        html += `<th>${i}</th>`;
    }

    html += '</tr>\n';

    for(let i=1; i <= n; i++) {
        html += `\t<tr><th>${i}</th>`;

        for(let j=1; j<= n; j++) {
            html += `<td>${i * j}</td>`
        }

        html += '</tr>\n';
    }

    html += '</table>\n';

    console.log(html);

}

multiplicationTable(5);