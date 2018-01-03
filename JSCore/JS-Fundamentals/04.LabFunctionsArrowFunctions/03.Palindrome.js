function isPalindrome(text) {
    let textLength = text.length;
    let leftPart = text.substring(0,textLength / 2);
    text = reverseString(text);
    let rightPart = text.substring(0, textLength / 2);

    let isPalindrome  = leftPart == rightPart;

    console.log(isPalindrome);

    function reverseString(string){
        return string.split("").reverse().join("");
    }
}

isPalindrome("racecar");