function solve(args) {
    let n = Number(args[0]);
    let result = '';

    for (let i = 1; i <=n ; i++) {
      if(isSymmetric(i.toString())){
          result+=i+" ";
      }
    }

    console.log(result);
    function isSymmetric(number) {
        for (let i = 0; i < number.length / 2; i++) {
           if (number[i] != number[number.length - i -1]){
               return false;
               break;
           }
        }

        return true;
    }
}
