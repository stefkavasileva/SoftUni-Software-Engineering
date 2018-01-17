function composesHtmlTag([fileLocation,alternateText]) {
    let  result = `<img src="${fileLocation}" alt="${alternateText}">`;

    console.log(result);
}

composesHtmlTag(['smiley.gif', 'Smiley Face']);