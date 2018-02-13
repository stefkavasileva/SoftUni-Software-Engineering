function isTextEndWith(text, substring) {
    if(text.endsWith(substring)){
        console.log('true');
        return;
    }

    console.log('false');
}

isTextEndWith('This sentence ends with fun?','fun?');