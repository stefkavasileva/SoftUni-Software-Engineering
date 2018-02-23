function wikiParser(selector) {
    let textToBeParsed = $(selector).text();

    let iReg = /''([^']+?)''/;
    let bReg = /'''([^']+?)'''/;
    let h1 = /=([^=]+?)=/;
    let h2 = /==([^=]+?)==/;
    let h3 = /===([^=]+?)===/;
    let firstATagType = /\[\[([^'=\[\]]+?)]]/;
    let secondATagType = /\[\[([^'=\[\]]+?)\|([^'=\[\]]+?)]]/;

    let parsedText = textToBeParsed
        .replace(new RegExp(h3,'g'),(m,g) => `<h3>${g}</h3>`)
        .replace(new RegExp(h2,'g'),(m,g) => `<h2>${g}</h2>`)
        .replace(new RegExp(h1,'g'),(m,g) => `<h1>${g}</h1>`)
        .replace(new RegExp(bReg,'g'),(m,g) => `<b>${g}</b>`)
        .replace(new RegExp(iReg,'g'),(m,g) => `<i>${g}</i>`)
        .replace(new RegExp(secondATagType,'g'),(m,g1,g2) => `<a href="/wiki/${g1}">${g2}</a>`)
        .replace(new RegExp(firstATagType,'g'),(m,g) => `<a href="/wiki/${g}">${g}</a>`);


    $(selector).html(parsedText);

}