function getUniqueWords(input) {
   let set = new Set();
    for (let i = 0; i < input.length; i++) {
       let currentWords = input[i]
           .toLowerCase()
           .split(/\W+/)
           .filter(x => x !== '');

       currentWords.forEach(x => set.add(x));
    }

    console.log(Array.from(set).join(", "));
}

getUniqueWords(['Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui.Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.',
'Vestibulum dolor diam, dignissim quis varius non, fermentum non felis. ',
'Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut. ',
'Morbi in ipsum varius, pharetra diam vel, mattis arcu. ',
'Integer ac turpis commodo, varius nulla sed, elementum lectus. ',
'Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.']);