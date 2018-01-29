function main(text, substring) {
    if(text.endsWith(substring)){
        console.log('true');
        return;
    }

    console.log('false');
}

main('This sentence ends with fun?','fun?');