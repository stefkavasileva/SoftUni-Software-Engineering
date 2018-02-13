function isTextStartWith(text, substring) {
    if(text.startsWith(substring)){
        console.log('true');
        return;
    }

    console.log('false');
}

isTextStartWith('How have you been?','how');