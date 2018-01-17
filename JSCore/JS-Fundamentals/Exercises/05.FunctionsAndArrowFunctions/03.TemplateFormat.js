function getHTML(input) {
    let xml = `<?xml version="1.0" encoding="UTF-8"?>\n`;
    xml += `<quiz>\n`;

    for (let i = 0; i < input.length; i+=2) {
        xml += `\t<question>\n`;
        xml += `\t\t${input[i]}\n`;
        xml += `\t</question>\n`;
        xml += `\t<answer>\n`;
        xml += `\t\t${input[i+1]}\n`;
        xml += `\t</answer>\n`;

    }

    xml += `</quiz>\n`;
    console.log(xml);
}

getHTML(["Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton"]);