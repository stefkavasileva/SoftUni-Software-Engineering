import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char [] vowels =  {'a','e','o','u','i','y'};
        char symbol =scanner.nextLine().charAt(0);

        boolean isDigit = Character.isDigit(symbol);
        boolean isVowel = false;
        for (int i = 0; i < vowels.length; i++) {
            if(symbol == vowels[i]){
                isVowel = true;
                break;
            }
        }

        if(isDigit){
            System.out.println("digit");
        }else if (isVowel){
            System.out.println("vowel");
        }else{
            System.out.println("other");
        }

    }
}
