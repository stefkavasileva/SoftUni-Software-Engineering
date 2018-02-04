//(.*?(\n)) ===> match new line
//80/100
function main(input) {
    let pattern = /^<message((?:\s+[a-z]+="[A-Za-z \.\d]+")*)>(.+(\n)*.+)*<\/message>$/;
    let match = pattern.exec(input);
    if(!pattern.test(input)){
        console.log('Invalid message format');
        return;
    }

    let attributeMatch ;
    let attributesPattern = /(from=|to=)"(.+?)"/;
    let attributes = [];
    let sender;
    let recipient;

    while (attributeMatch = attributesPattern.exec(input)){
        if(attributeMatch[1] === 'from='){
            sender = attributeMatch[2];
            input = input.replace('from=','');
            continue;
        }

        recipient = attributeMatch[2];
        input = input.replace('to=','');
    }

    if(sender === undefined || recipient === undefined){
        console.log('Missing attributes');
        return;
    }

    let messages = match[2].split(/\n/).filter(x => x !== '');
    let html = '<article>\n';
    html += `  <div>From: <span class="sender">${sender}</span></div>\n`;
    html += `  <div>To: <span class="recipient">${recipient}</span></div>\n`;
    html += `  <div>\n`;

    for (let message of messages) {
        html += `    <p>${message}</p>\n`;
    }

    html += `  </div>\n`;
    html += `</article>`;

    console.log(html);
}
main('<message to="Bob" from="Alice" timestamp="1497254092">Hey man, what\'s up?</message>');