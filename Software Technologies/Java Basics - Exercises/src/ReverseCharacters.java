import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String firstLetter = scanner.nextLine();
        String secondLetter = scanner.nextLine();
        String thirdLetter = scanner.nextLine();

        System.out.println(thirdLetter+secondLetter+firstLetter);
    }
}
