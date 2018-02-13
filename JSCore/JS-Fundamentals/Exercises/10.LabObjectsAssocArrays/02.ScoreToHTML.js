function getHtml(objectsAsString) {
    let objects = JSON.parse(objectsAsString);
    let html = `<table>\n`;
    let keys = takeKeys(objects[0]);
    html = addTableHead(html,keys);

    for (let i = 0; i < objects.length; i++) {
        html = addTableTd(html,keys,objects[i])
    }

    html += '</table>';

    console.log(html);

    function addTableTd(html, keys, obj) {
        html += `    <tr>`;
        for (let key  of keys) {
            html += `<td>${escapeHtml(obj[key].toString())}</td>`
        }
        html += `</tr>\n`;
        return html;
    }

    function addTableHead(html, keys) {
        html += `    <tr>`;
        for (let key  of keys) {
            html += `<th>${key}</th>`
        }
        html += `</tr>\n`;
        return html;
    }

    function takeKeys(obj) {
        return Object.keys(obj);
    }

    function escapeHtml(html) {
        html = html.replace(/&/g,'&amp;');
        html = html.replace(/</g,'&lt;');
        html = html.replace(/>/g,'&gt;');
        html = html.replace(/"/g,'&quot;');
        html = html.replace(/'/g,'&#39;');
        return html;
    }
}

getHtml('[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]');