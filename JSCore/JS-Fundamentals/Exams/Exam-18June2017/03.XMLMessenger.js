function main(input) {
    let pattern = /^<message((?:\s+[a-z]+="[A-Za-z .\d]+")*)>((?:.|\n)+)<\/message>$/;
    let match = pattern.exec(input);
    if(!match){
        console.log('Invalid message format');
        return;
    }

    let toMatch = /\bto="([A-Za-z0-9 .]+)"/.exec(match[1]);
    let fromMatch = /\bfrom="([A-Za-z0-9 .]+)"/.exec(match[1]);

    if(!toMatch || !fromMatch){
        console.log('Missing attributes');
        return;
    }

    let messages = match[2].split(/\n/);
    let html = '<article>\n';
    html += `  <div>From: <span class="sender">${fromMatch[1]}</span></div>\n`;
    html += `  <div>To: <span class="recipient">${toMatch[1]}</span></div>\n`;
    html += `  <div>\n`;

    for (let message of messages) {
        html += `    <p>${message}</p>\n`;
    }

    html += `  </div>\n`;
    html += `</article>`;

    console.log(html);
}


main('<message to="Bob" from="Alice" timestamp="1497254092">Hey man, what\'s up?</message>');