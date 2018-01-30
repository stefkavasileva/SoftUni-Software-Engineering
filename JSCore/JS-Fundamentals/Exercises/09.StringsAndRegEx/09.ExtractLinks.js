function mai(input) {
    let pattern  =/www\.[A-Za-z-\d]+(?:\.[a-z]+)+/;
    let links = [];
    for (let i = 0; i < input.length; i++) {
       let match = pattern.exec(input[i]);
       if(match){
            links.push(match[0]);
        }
    }

    links.forEach(x => console.log(x));
}

mai(['Join WebStars now for free, at www.web-stars.com',
'You can also support our partners:',
'    Internet - www.internet.com',
'WebSpiders - www.webspiders101.com',
'Sentinel - www.sentinel.-ko']
);