function main(text, substring) {
    if(text.startsWith(substring)){
        console.log('true');
        return;
    }

    console.log('false');
}

main('How have you been?','how');