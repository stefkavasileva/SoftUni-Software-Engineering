import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        int startIndex = text.indexOf("<upcase>");
        int endIndex = text.indexOf("</upcase>");

        while (startIndex != -1) {
            String textToUpper = text.substring(startIndex+8,endIndex);

            String textToBeRepleace = "<upcase>"+textToUpper+"</upcase>";
            text = text.replace(textToBeRepleace,textToUpper.toUpperCase());

            startIndex = text.indexOf("<upcase>");
            endIndex = text.indexOf("</upcase>");
        }

        System.out.println(text);
    }
}