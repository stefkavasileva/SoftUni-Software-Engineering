function escapeHtml(input) {
    let html = '<ul>\n';
    for (let i = 0; i < input.length; i++) {
        let currentElement = input[i];
        currentElement = currentElement.replace(/&/g,'&amp;');
        currentElement = currentElement.replace(/</g,'&lt;');
        currentElement = currentElement.replace(/>/g,'&gt;');
        currentElement = currentElement.replace(/"/g,'&quot;');
        html += `  <li>${currentElement}</li>\n`
    }

    html += `</ul>`;
    console.log(html);
}

escapeHtml(['<b>unescaped text</b>', 'normal text'])