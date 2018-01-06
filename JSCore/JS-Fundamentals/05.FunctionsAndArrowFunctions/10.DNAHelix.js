function printDNAHelix(n) {
    let letter = ['A','T','C','G','T','T','A','G','G','G'];
    let letterCount = 0;
    let counter = 0;
    let isStartLine = true;

    for (let i = 1; i <= n; i++) {
        let currentLine = '';
        if(isStartLine){
            //**LetterLetter**
            if(letterCount > letter.length-1){
                letterCount = 0;
            }

            currentLine += `**${letter[letterCount]}`;
            letterCount++;

            if(letterCount > letter.length-1){
                letterCount = 0;
            }

            currentLine += `${letter[letterCount]}**`;
            letterCount++;
            counter=0;
            isStartLine=false;
        }else if(Math.trunc((i%2)==0)){
            //*Letter--Letter*
            if(letterCount > letter.length-1){
                letterCount = 0;
            }
            currentLine += `*${letter[letterCount]}--`;
            letterCount++;

            if(letterCount > letter.length-1){
                letterCount = 0;
            }

            currentLine += `${letter[letterCount]}*`;
            letterCount++;
            counter++;
        }else{
            //Letter----Letter
            if(letterCount > letter.length-1){
                letterCount = 0;
            }
            currentLine += `${letter[letterCount]}----`;
            letterCount++;
            if(letterCount > letter.length-1){
                letterCount = 0;
            }
            currentLine += `${letter[letterCount]}`;
            letterCount++;
            counter++;
        }

        if (counter==3){
            isStartLine = true;
        }

        console.log(currentLine);

    }
}

printDNAHelix(4);