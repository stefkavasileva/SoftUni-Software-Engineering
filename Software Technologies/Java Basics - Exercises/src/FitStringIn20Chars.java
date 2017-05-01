import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] symbols = scanner.nextLine().toCharArray();
        String result = "";

        for (int i = 0; i < Math.min(symbols.length, 20); i++) {
            result += symbols[i];
        }

        int asterisk = 20 - result.length();

        for (int i = 0; i < asterisk; i++) {
            result+="*";
        }

        System.out.println(result);
    }
}
