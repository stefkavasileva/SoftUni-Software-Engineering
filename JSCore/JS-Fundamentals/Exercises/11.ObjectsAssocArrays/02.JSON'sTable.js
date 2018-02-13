function printHtml(input) {
    let html = `<table>\n`;
    for (let i = 0; i < input.length; i++) {
        let obj = JSON.parse(input[i]);
        html+= `	<tr>\n		<td>${obj['name']}</td>\n		<td>${obj['position']}</td>\n		<td>${obj['salary']}</td>\n	<tr>\n`;
    }

    html += `</table>`
    console.log(html);
}

printHtml(['{"name":"Pesho","position":"Promenliva","salary":100000}',
'{"name":"Teo","position":"Lecturer","salary":1000}',
'{"name":"Georgi","position":"Lecturer","salary":1000}']);